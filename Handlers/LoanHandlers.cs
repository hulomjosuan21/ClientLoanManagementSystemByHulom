using ClientLoanManagementSystemByHulom.Entities;
using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    internal class LoanHandlers : LoanCalculations, IDisposable
    {
        private readonly hulomdbEntities _context;
        private readonly BindingSource _bindingSource;

        private readonly int _clientId;
        public decimal LoanAmount { get; set; }
        public decimal Interest { get; set; }
        public PaymentTerm Term { get; set; }
        public int NoOfPayment { get; set; }
        public decimal Deduction { get; set; }

        public LoanHandlers(int _clientId, BindingSource _bindingSource)
        {
            _context = new hulomdbEntities();
            this._clientId = _clientId;
            this._bindingSource = _bindingSource;

            _bindingSource.DataSource = new hulomdbEntities().Loans.Where(l => l.ClientID == _clientId).ToList();
        }
        public void AddLoanData()
        {
            try
            {
                decimal interestedAmount = InterestedAmount(LoanAmount, Interest);
                Loan addLoan = new Loan
                {
                    ClientID = _clientId,
                    LoanAmount = LoanAmount,
                    Interest = Interest,
                    PaymentTerm = Term.ToString(),
                    NoOfPayments = NoOfPayment,
                    Deduction = Deduction,
                    InterestedAmount = interestedAmount,
                    ReceivableAmount = ReceivableAmount(LoanAmount, interestedAmount),
                    TotalPayable = TotalPayable(LoanAmount, interestedAmount, Deduction),
                    DueDate = GetDueDate(NoOfPayment, Term).Due,
                    PaidStatus = LoanStatus.Ongoing.ToString()
                };

                _context.Loans.Add(addLoan);
                _context.SaveChanges();

                _bindingSource.DataSource = _context.Loans.Where(q => q.ClientID == _clientId).ToList();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
        public static void DeleteLoanOfClient(int _id)
        {
            using (hulomdbEntities context = new hulomdbEntities())
            {
                List<Loan> loansToDelete = context.Loans.Where(loan => loan.ClientID == _id).ToList();

                foreach (Loan loan in loansToDelete)
                {
                    context.Loans.Remove(loan);
                }

                try
                {
                    context.SaveChanges();
                }
                catch (Exception) { }
            }
        }

        public void SetStatus(int loanId, string stat)
        {
            Loan l = _context.Loans.FirstOrDefault(q => q.LoanID == loanId);

            if (l != null)
            {
                if (!CheckIfLoanDue(loanId) || stat != LoanStatus.Ongoing.ToString())
                {
                    l.PaidStatus = stat;
                    _context.SaveChanges();
                }
                else
                {
                    MessageBox.Show("Cannot set to Ongoing status because the loan has already reached the due date", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }

                _bindingSource.DataSource = _context.Loans.Where(q => q.ClientID == _clientId).ToList();
            }
        }

        private bool CheckIfLoanDue(int _id)
        {
            Loan loanDue = _context.Loans.FirstOrDefault(l => l.LoanID == _id);

            if (loanDue != null)
            {
                return DateTime.Now > loanDue.DueDate;
            }

            return false; // Return false if loan with given ID is not found
        }


        public (bool confirm, int ID) AutoSetPenalized
        {
            set
            {
                if (value.confirm == true)
                {
                    List<Loan> setPenal = _context.Loans.Where(l => l.DueDate <= DateTime.Now && l.PaidStatus == LoanStatus.Ongoing.ToString() && l.ClientID == value.ID).ToList();

                    foreach (Loan loan in setPenal)
                    {
                        loan.PaidStatus = LoanStatus.Penalized.ToString();

                        _context.SaveChanges();

                        _bindingSource.DataSource = _context.Loans.Where(q => q.ClientID == _clientId).ToList();
                    }
                }
            }
        }

        public (DateTime Start, DateTime Due) GetDueDate(int numberOfPayments, PaymentTerm frequency)
        {
            DateTime loanStartDate = DateTime.Now;
            int daysBetweenPayments = 0;
            switch (frequency)
            {
                case PaymentTerm.Daily:
                    daysBetweenPayments = 1;
                    break;
                case PaymentTerm.Weekly:
                    daysBetweenPayments = 7;
                    break;
                case PaymentTerm.Monthly:
                    daysBetweenPayments = 30;
                    break;
                case PaymentTerm.Yearly:
                    daysBetweenPayments = 365;
                    break;
            }

            DateTime nextDueDate = loanStartDate.AddDays(1);

            if (frequency == PaymentTerm.Weekly)
            {
                int daysUntilNextWeek = 7 - (int)loanStartDate.DayOfWeek;
                nextDueDate = nextDueDate.AddDays(daysUntilNextWeek);
            }
            else if (frequency == PaymentTerm.Monthly)
            {
                nextDueDate = nextDueDate.AddMonths(1);
                nextDueDate = new DateTime(nextDueDate.Year, nextDueDate.Month, loanStartDate.Day);
            }
            else if (frequency == PaymentTerm.Yearly)
            {
                nextDueDate = nextDueDate.AddYears(1);
                nextDueDate = new DateTime(nextDueDate.Year, loanStartDate.Month, loanStartDate.Day);
            }

            nextDueDate = nextDueDate.AddDays(daysBetweenPayments * (numberOfPayments - 1));

            return (Start: nextDueDate, Due: nextDueDate);
        }

        public decimal InterestedAmount(decimal loanAmount, decimal interest) => (loanAmount * interest) / 100;

        public decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount) => (loanAmount + interestedAmount);

        public decimal TotalPayable(decimal loanAmount, decimal interestedAmount, decimal deduction) => (loanAmount + interestedAmount) - deduction;

        public void Dispose()
        {
            _context?.Dispose();
        }
    }
}
