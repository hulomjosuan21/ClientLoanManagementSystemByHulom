using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Maximized;
            LoadForm(new Forms.DashboardForm());
            
        }

        private void DashboardButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.DashboardForm());
        }

        private void ClientsButton_Click(object sender, EventArgs e)
        {
            LoadForm(new Forms.ClientForm());
        }
    }
}
