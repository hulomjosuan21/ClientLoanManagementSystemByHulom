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
                    int getTotalClient = con.Clients?.Count() ?? 0;
                    int getTotalLoan = con.Loans?.Count() ?? 0;

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
                    decimal totalLoanAmt = con.Loans?.Sum(_ => (decimal?)_.LoanAmount) ?? 0;
                    decimal totalPayableByClients = con.Loans?.Sum(_ => (decimal?)_.TotalPayable) ?? 0;

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
