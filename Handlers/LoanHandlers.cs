using ClientLoanManagementSystemByHulom.Entities;
using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    [Author]
    [Serializable]
    internal class LoanHandlers : LoanCalculations, IDisposable
    {
        [Required(ErrorMessage = "No Database Connection")]
        private readonly hulomdbEntities _context;
        private readonly BindingSource _bindingSource;

        [Required]
        private readonly int _clientId;
        public decimal LoanAmount { get; set; }
        public decimal Interest { get; set; }
        public PaymentTerm Term { get; set; }
        public int NoOfPayment { get; set; }
        public decimal Deduction { get; set; }

        private readonly int _op;


        public LoanHandlers(int _clientId, BindingSource _bindingSource, int _op = 0)
        {
            _context = new hulomdbEntities();
            this._clientId = _clientId;
            this._bindingSource = _bindingSource;

            this._op = _op;

            RefreshBindingSource = _op;
        }


        public int RefreshBindingSource
        {
            set
            {
                switch (value)
                {
                    case 1:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId).OrderByDescending(_ => _.LoanAmount).ToList();
                        break;
                    case 2:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId && _.PaidStatus.Equals(LoanStatus.Ongoing.ToString())).OrderBy(_ => _.DueDate).ToList();
                        break;
                    case 3:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId && _.PaidStatus.Equals(LoanStatus.Ongoing.ToString())).ToList();
                        break;
                    case 4:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId && _.PaidStatus.Equals(LoanStatus.Paid.ToString())).ToList();
                        break;
                    case 5:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId && _.PaidStatus.Equals(LoanStatus.Penalized.ToString())).ToList();
                        break;
                    default:
                        _bindingSource.DataSource = _context.Loans.Where(_ => _.ClientID == _clientId).ToList();
                        break;
                }
            }
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

                RefreshBindingSource = _op;
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
                List<Loan> loansToDelete = context.Loans.Where(_ => _.ClientID == _id).ToList();

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
            Loan l = _context.Loans.FirstOrDefault(_ => _.LoanID == loanId);

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

                RefreshBindingSource = _op;
            }
        }

        private bool CheckIfLoanDue(int _id)
        {
            Loan loanDue = _context.Loans.FirstOrDefault(_ => _.LoanID == _id);

            if (loanDue != null)
            {
                return DateTime.Now > loanDue.DueDate;
            }

            return false;
        }

        public (bool confirm, int ID) AutoSetPenalized
        {
            set
            {
                if (value.confirm == true)
                {
                    List<Loan> setPenal = _context.Loans.Where(_ => _.DueDate <= DateTime.Now && _.PaidStatus == LoanStatus.Ongoing.ToString() && _.ClientID == value.ID).ToList();

                    foreach (Loan loan in setPenal)
                    {
                        loan.PaidStatus = LoanStatus.Penalized.ToString();

                        _context.SaveChanges();

                        RefreshBindingSource = _op;
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

        public (string Firstname, string Lastname) GetName
        {
            get
            {
                Client getClient = _context.Clients.Where(_ => _.ID == _clientId).FirstOrDefault();
                return (getClient.Firstname, getClient.Lastname);
            }
        }

        public void SearchLoan(string text)
        {
            try
            {
                bool isLoanId = int.TryParse(text, out int loanId);
                bool isDueDate = DateTime.TryParse(text, out DateTime dueDate);

                var result = _context.Loans
                    .Where(l => l.ClientID == _clientId &&
                                ((isLoanId && l.LoanID == loanId) ||
                                 l.PaymentTerm.Contains(text) ||
                                 l.PaidStatus.Contains(text) ||
                                 (isDueDate && l.DueDate == dueDate)))
                    .Select(l => new
                    {
                        l.LoanID,
                        l.ClientID,
                        l.LoanAmount,
                        l.Interest,
                        l.NoOfPayments,
                        l.PaymentTerm,
                        l.Deduction,
                        l.InterestedAmount,
                        l.ReceivableAmount,
                        l.TotalPayable,
                        l.DueDate,
                        l.PaidStatus
                    })
                    .ToList();

                _bindingSource.DataSource = result;
            }
            catch (Exception)
            { }
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
