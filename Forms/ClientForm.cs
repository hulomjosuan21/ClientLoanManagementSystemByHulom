using ClientLoanManagementSystemByHulom.Forms.PopUpForms;
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
    public partial class ClientForm : Form
    {
        private readonly ClientHandler _clientDb;
        public ClientForm()
        {
            InitializeComponent();
            _clientDb = new ClientHandler(clientBindingSource);
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            
        }

        private void ViewLoanButton_Click(object sender, EventArgs e)
        {
            LoanForm openLoan = new LoanForm(1);
            openLoan.ShowDialog();
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddClientForm getNewClient = new AddClientForm();

            getNewClient.ShowDialog();
        }
    }
}
