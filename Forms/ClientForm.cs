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

            if (getNewClient.ShowDialog() == DialogResult.OK)
            {
                _clientDb.AddClient(getNewClient.Firstname, getNewClient.Lastname, getNewClient.Residency, getNewClient.Birthdate);
            }
        }

        private int _getSelectedId;
        private readonly HashSet<int> _getSelectedIds = new HashSet<int>();
        private void ClientTable_SelectionChanged(object sender, EventArgs e)
        {
            _getSelectedIds.Clear();
            if (ClientTable.SelectedRows.Count == 0)
            {
                return;
            }

            _getSelectedId = (int)ClientTable.SelectedRows[0].Cells[0].Value;
            
            foreach (DataGridViewRow row in ClientTable.SelectedRows)
            {
                int ids = (int)row.Cells[0].Value;
                _getSelectedIds.Add(ids);
            }
        }
        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            foreach (int id in _getSelectedIds)
            {
                MessageBox.Show(id.ToString());
            }
        }

        private int _getSelectedCol;
        private void ClientTable_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && e.ColumnIndex >= 0)
            {
                _getSelectedCol = e.ColumnIndex;
            }
        }

        private void ClientTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {

        }

        private void ClientTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
