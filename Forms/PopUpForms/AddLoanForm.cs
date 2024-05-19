using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    [Author]
    public partial class AddLoanForm : Form, LoanCalculations
    {
        private const decimal MIN_LOAN = 1000;

        [Required]
        public decimal LoanAmount { get; set; }
        [Required]
        public decimal Interest { get; set; }
        [Required]
        public PaymentTerm SelectedTerm { get; set; }
        [Required]
        public int NoOfPayment { get; set; }
        [Required]
        public decimal Deduction { get; set; }

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
            LoanAmount = AddLoanForm.ParseDecimalOrDefault(LoanAmountTextBox.Text.Trim());
            Interest = AddLoanForm.ParseDecimalOrDefault(InterestTextBox.Text.Trim());
            NoOfPayment = AddLoanForm.ParseIntOrDefault(NoOfPaymentTextBox.Text.Trim());
            decimal insurance = AddLoanForm.ParseDecimalOrDefault(InsuranceTextBox.Text.Trim());
            decimal others = AddLoanForm.ParseDecimalOrDefault(OthersTextBox.Text.Trim());

            SelectedTerm = (PaymentTerm)TermComboBox.SelectedItem;
            Deduction = insurance + others;

            decimal interestedAmount = InterestedAmount(LoanAmount, Interest);
            decimal receivableAmount = ReceivableAmount(LoanAmount, interestedAmount);
            decimal totalPayable = TotalPayable(LoanAmount, interestedAmount, Deduction);
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

        public static decimal ParseDecimalOrDefault(string input)
        {
            return decimal.TryParse(input, out decimal result) ? result : 0;
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

        public decimal InterestedAmount(decimal loanAmount, decimal interest) => (loanAmount * interest) / 100;

        public decimal ReceivableAmount(decimal loanAmount, decimal interestedAmount) => (loanAmount + interestedAmount);

        public decimal TotalPayable(decimal loanAmount, decimal interestedAmount, decimal deduction) => (loanAmount + interestedAmount) - deduction;
    }
}
