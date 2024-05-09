using ClientLoanManagementSystemByHulom.Entities;
using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Handlers
{
    internal class LoanHandlers : LoanCalculations
    {
        private readonly hulomdbEntities _context;
        private readonly BindingSource _bindingSource;

        private readonly int _clientId;
        protected readonly double _loanAmount;
        protected readonly double _interest;
        private readonly PaymentTerm _term;
        private readonly int _noOfPayment;
        private readonly double _deduction;
        private readonly DateTime _dueDate;

        public LoanHandlers()
        { }

        public static hulomdbEntities Con
        {
            get
            {
                return new hulomdbEntities();
            }
        }
        public LoanHandlers(int _clientId, double _loanAmount, double _interest, PaymentTerm _term, int _noOfPayment, double _deduction, BindingSource _bindingSource) : this()
        {
            _context = new hulomdbEntities();
            this._clientId = _clientId;
            this._loanAmount = _loanAmount;
            this._interest = _interest;
            this._term = _term;
            this._noOfPayment = _noOfPayment;
            this._deduction = _deduction;
            _dueDate = GetDueDate(this._noOfPayment, this._term).Due;

            this._bindingSource = _bindingSource;
        }

        public void AddLoanData()
        {
            try
            {
                Loan addLoan = new Loan
                {
                    ClientId = _clientId,
                    Loan_AMT = _loanAmount,
                    Interest = _interest,
                    Term = _term.ToString(),
                    NoOf_Payment = _noOfPayment,
                    Deduction = _deduction,
                    Interested_AMT = InterestedAmount(_loanAmount, _interest),
                    Receivable_AMT = ReceivableAmount(_loanAmount, _interest),
                    Total_Payable = TotalPayable(_loanAmount, InterestedAmount(_loanAmount, _interest), _deduction),
                    Due_Date = _dueDate,
                    Status_Paid = LoanStatus.Active.ToString()
                };

                _context.Loans.Add(addLoan);
                _context.SaveChanges();

                _bindingSource.DataSource = _context.Loans.Where(q => q.ClientId == _clientId).ToList();
            }
            catch (Exception ex)
            {
                _ = MessageBox.Show(ex.Message, ex.StackTrace, MessageBoxButtons.OK, MessageBoxIcon.Error);
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

        public double InterestedAmount(double loanAmount, double interest) => (loanAmount * interest) / 100;

        public double ReceivableAmount(double loanAmount, double interest) => (loanAmount + interest);

        public double TotalPayable(double loanAmount, double interestedAmount, double deduction) => (loanAmount + interestedAmount) - deduction;
    }
}
