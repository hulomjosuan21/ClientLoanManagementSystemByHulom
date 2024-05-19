using ClientLoanManagementSystemByHulom.Entities;
using System;
using System.Linq;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms
{
    [Author]
    public partial class DashboardForm : Form
    {
        public DashboardForm()
        {
            InitializeComponent();
        }

        private void DashboardForm_Load(object sender, EventArgs e)
        {
            TotalClientsLabel.Text = GetVal._TotalClients.ToString();
            TotalLoanLabel.Text = GetVal._TotalLoans.ToString();

            DisbursedLabel.Text = ToShordHand(GetTotal._Disbursed);
            FullValueFormatToolTip.SetToolTip(DisbursedLabel, GetTotal._Disbursed.ToString());

            PayablesLabel.Text = ToShordHand(GetTotal._PayableByClients);
            FullValueFormatToolTip.SetToolTip(PayablesLabel, GetTotal._PayableByClients.ToString());
        }

        private (int _TotalClients, decimal _TotalLoans) GetVal
        {
            get
            {
                using (hulomdbEntities con = new hulomdbEntities())
                {
                    int getTotalClient = con.Clients.Count();
                    int getTotalLoan = con.Loans.Count();

                    return (_TotalClients: getTotalClient, _TotalLoans: getTotalLoan);
                }
            }
        }

        private (decimal _Disbursed, decimal _PayableByClients) GetTotal
        {
            get
            {
                using (hulomdbEntities con = new hulomdbEntities())
                {
                    decimal totalLoanAmt = con.Loans.Sum(_ => _.LoanAmount);
                    decimal totalPayableByClients = con.Loans.Sum(_ => _.TotalPayable);

                    return (_Disbursed: totalLoanAmt, _PayableByClients: totalPayableByClients);
                }
            }
        }

        public static string ToShordHand(decimal number)
        {
            if (number >= 1000000000)
            {
                return (number / 1000000000M).ToString("0.0") + "B";
            }
            if (number >= 1000000)
            {
                return (number / 1000000M).ToString("0.0") + "M";
            }
            if (number >= 1000)
            {
                return (number / 1000M).ToString("0.0") + "K";
            }
            return number.ToString("0.0");
        }
    }
}
