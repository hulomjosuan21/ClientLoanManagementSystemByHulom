using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    public partial class AddLoanForm : Form, LoanCalculations
    {
        private const double MIN_LOAN = 1000;

        public double LoanAmount { get; set; }
        public double Interest { get; set; }
        public PaymentTerm SelectedTerm { get; set; }
        public int NoOfPayment { get; set; }
        public double Deduction { get; set; }

        public AddLoanForm()
        {
            InitializeComponent();
            InitializeAddedComponent();
        }

        protected override void WndProc(ref Message message)
        {
            const int WM_SYSCOMMAND = 0x0112;
            const int SC_MOVE = 0xF010;

            switch (message.Msg)
            {
                case WM_SYSCOMMAND:
                    int command = message.WParam.ToInt32() & 0xfff0;
                    if (command == SC_MOVE)
                        return;
                    break;
            }

            base.WndProc(ref message);
        }

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            TermComboBox.DataSource = Enum.GetValues(typeof(PaymentTerm));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            Add_loan();
            DialogResult = DialogResult.Yes;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void Add_loan()
        {
            try
            {
                if (LoanAmount < MIN_LOAN)
                {
                    MessageBox.Show($"Loan amount must be greater than or equal to {MIN_LOAN}.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }

                if (SelectedTerm.Equals(null))
                {
                    SelectedTerm = PaymentTerm.Daily;
                }

                if (NoOfPayment <= 0)
                {
                    MessageBox.Show("Number of payments must be greater than 0.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void InputChanges(object sender, EventArgs e)
        {
            LoanAmount = AddLoanForm.ParseDoubleOrDefault(LoanAmountTextBox.Text.Trim());
            Interest = AddLoanForm.ParseDoubleOrDefault(InterestTextBox.Text.Trim());
            NoOfPayment = AddLoanForm.ParseIntOrDefault(NoOfPaymentTextBox.Text.Trim());
            double insurance = AddLoanForm.ParseDoubleOrDefault(InsuranceTextBox.Text.Trim());
            double others = AddLoanForm.ParseDoubleOrDefault(OthersTextBox.Text.Trim());

            SelectedTerm = (PaymentTerm)TermComboBox.SelectedItem;
            Deduction = insurance + others;

            double interestedAmount = InterestedAmount(LoanAmount, Interest);
            double receivableAmount = ReceivableAmount(LoanAmount, interestedAmount);
            double totalPayable = TotalPayable(LoanAmount, interestedAmount, Deduction);
            DateTime dueDate = GetDueDate(NoOfPayment, SelectedTerm).Due;

            AmountsLabel.Text = $"\n₱ {interestedAmount}\n₱ {receivableAmount}\n₱ {Deduction}\n{dueDate:MM/dd/yyyy}\n₱ {totalPayable}\n";
        }

        public static void CatchNonNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        public static double ParseDoubleOrDefault(string input)
        {
            return double.TryParse(input, out double result) ? result : 0;
        }

        public static int ParseIntOrDefault(string input)
        {
            return int.TryParse(input, out int result) ? result : 0;
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

        public double InterestedAmount(double loanAmount, double interest) => (LoanAmount * interest) / 100;

        public double ReceivableAmount(double loanAmount, double interestedAmount) => (LoanAmount + interestedAmount);

        public double TotalPayable(double loanAmount, double interestedAmount, double deduction) => (loanAmount + interestedAmount) - deduction;
    }
}
