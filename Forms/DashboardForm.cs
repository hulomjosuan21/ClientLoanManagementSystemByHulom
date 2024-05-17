using ClientLoanManagementSystemByHulom.Entities;
using ClientLoanManagementSystemByHulom.Handlers;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms
{
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
    }
}
