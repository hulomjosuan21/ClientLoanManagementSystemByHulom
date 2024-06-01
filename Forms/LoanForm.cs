using ClientLoanManagementSystemByHulom.Entities;
using ClientLoanManagementSystemByHulom.Forms.PopUpForms;
using ClientLoanManagementSystemByHulom.Handlers;
using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms
{
    [Author]
    public partial class LoanForm : Form
    {
        private const string CURRENCY = "en-PH";

        private readonly string[] ListOfOption = { "All Loans (Default)", "All Loans (Largest First)", "Due Date (Nearest First)", LoanStatus.Ongoing.ToString(), LoanStatus.Paid.ToString(), LoanStatus.Penalized.ToString() };

        private readonly int _currentClientId;
        private LoanHandlers _loanDb;

        public LoanForm(int _currentClientId = 0)
        {
            InitializeComponent();
            InitializeAddedComponent();
            this._currentClientId = _currentClientId;
        }

        private void LoanForm_Load(object sender, EventArgs e)
        {
            _loanDb = new LoanHandlers(_currentClientId, loanBindingSource)
            {
                AutoSetPenalized = (true, _currentClientId)
            };

            Text = $"Cliend ID #{_currentClientId} {_loanDb.GetName.Firstname} {_loanDb.GetName.Lastname}";

            FilterOption.DataSource = ListOfOption;

            RefreshValues();
        }

        private (int _TotalLoan, decimal _TotalPayable, decimal _TotalReceivable, int _TotalOngoing) ClientInfo
        {
            get
            {
                using (hulomdbEntities con = new hulomdbEntities())
                {
                    int totalLoan = con.Loans?.Count(l => l.ClientID == _currentClientId) ?? 0;

                    decimal? totalPayableNullable = con.Loans.Where(s => s.ClientID == _currentClientId && s.PaidStatus != LoanStatus.Paid.ToString()).Sum(s => (decimal?)s.TotalPayable);
                    decimal totalPayable = totalPayableNullable ?? 0;

                    decimal? totalRecNullable = con.Loans.Where(s => s.ClientID == _currentClientId).Sum(s => (decimal?)s.ReceivableAmount);
                    decimal totalRec = totalRecNullable ?? 0;

                    int countOngoing = con.Loans?.Where(l => l.ClientID == _currentClientId && l.PaidStatus == LoanStatus.Ongoing.ToString()).Count() ?? 0;

                    return (_TotalLoan: totalLoan, _TotalPayable: totalPayable, _TotalReceivable: totalRec, _TotalOngoing: countOngoing);
                }
            }
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            SetStatusForm getStatus = new SetStatusForm();
            getStatus.Text = $"Select Loan Status for Loan ID #{_loanId}";
            if (getStatus.ShowDialog() == DialogResult.OK)
            {
                RefreshValues();
            }
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddLoanForm newLoan = new AddLoanForm();
            if (newLoan.ShowDialog() == DialogResult.Yes)
            {
                _loanDb.LoanAmount = newLoan.LoanAmount;
                _loanDb.Interest = newLoan.Interest;
                _loanDb.Term = newLoan.SelectedTerm;
                _loanDb.NoOfPayment = newLoan.NoOfPayment;
                _loanDb.Deduction = newLoan.Deduction;
                _loanDb.AddLoanData();

                RefreshValues();
            }
        }

        private void RefreshValues()
        {
            totalLoanLabel.Text = ClientInfo._TotalLoan.ToString();
            totalPayableLabel.Text = DashboardForm.ToShordHand(ClientInfo._TotalPayable);
            FullValueFormatToolTip.SetToolTip(totalPayableLabel, ClientInfo._TotalPayable.ToString());
            totalReceivableLabel.Text = DashboardForm.ToShordHand(ClientInfo._TotalReceivable);
            FullValueFormatToolTip.SetToolTip(totalReceivableLabel, ClientInfo._TotalReceivable.ToString());
            ongoingLoansLabel.Text = ClientInfo._TotalOngoing.ToString();
        }

        private void LoanTable_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {

            if (e.ColumnIndex == 11 && e.RowIndex >= 0)
            {

                string cellValue = LoanTable.Rows[e.RowIndex].Cells[e.ColumnIndex].Value.ToString();

                Color ongoingColor = Color.FromArgb(56, 146, 227);
                Color paidColor = Color.FromArgb(121, 207, 24);
                Color penalizedColor = Color.FromArgb(210, 0, 12);

                switch (cellValue)
                {
                    case "Ongoing":
                        e.CellStyle.BackColor = ongoingColor;
                        break;
                    case "Paid":
                        e.CellStyle.BackColor = paidColor;
                        break;
                    case "Penalized":
                        e.CellStyle.BackColor = penalizedColor;
                        break;
                    default:
                        e.CellStyle.BackColor = LoanTable.DefaultCellStyle.BackColor;
                        break;
                }
            }
        }

        private int _loanId;
        private void LoanTable_SelectionChanged(object sender, EventArgs e)
        {
            if (LoanTable.SelectedRows.Count == 0)
            {
                return;
            }

            _loanId = (int)LoanTable.SelectedRows[0].Cells[0].Value;
        }

        private void LoanForm_ResizeEnd(object sender, EventArgs e)
        {
            //MessageBox.Show(Size.ToString());
        }

        private void FilterOption_SelectedIndexChanged(object sender, EventArgs e)
        {
            _loanDb = new LoanHandlers(_currentClientId, loanBindingSource, FilterOption.SelectedIndex)
            {
                AutoSetPenalized = (true, _currentClientId)
            };
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            _loanDb.SearchLoan(SearchTextbox.Text.Trim());
        }

        private void LoanTable_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            using (ScheduleForm viewSchedule = new ScheduleForm(_loanId, _currentClientId))
            {
                viewSchedule.ShowDialog();
            }
        }
    }
}