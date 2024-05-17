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

        private ClientHandler _clientDb;

        public ClientForm()
        {
            InitializeComponent();
        }

        private void ClientForm_Load(object sender, EventArgs e)
        {
            _clientDb = new ClientHandler(clientBindingSource);
        }

        private void ViewLoanButton_Click(object sender, EventArgs e)
        {
            if (_getSelectedId > 0)
            {
                LoanForm openLoan = new LoanForm(_getSelectedId);
                openLoan.ShowDialog();
            }
            else
            {
                MessageBox.Show("No Selected Client!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private void AddButton_Click(object sender, EventArgs e)
        {
            AddClientForm getNewClient = new AddClientForm();

            if (getNewClient.ShowDialog() == DialogResult.OK)
            {
                _clientDb.AddClient(getNewClient.Firstname, getNewClient.Lastname, getNewClient.Residency, getNewClient.Birthdate);
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (_getSelectedCol > 0 && _getSelectedId > 0 && _getNewCellVal != null)
                {
                    if (!_getNewCellVal.ToString().Equals(_getOldCellVal.ToString(), StringComparison.OrdinalIgnoreCase))
                    {
                        _clientDb.UpdateClient(_getSelectedId, _getSelectedCol - 1, _getNewCellVal);
                    }
                    else
                    {
                        MessageBox.Show("No Changes!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                else
                {
                    MessageBox.Show("No Cell is being edit!",
                        "Info", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception) { }
        }

        private void DeleteButton_Click(object sender, EventArgs e)
        {
            if (_getSelectedIds.Count != 0)
            {
                HashSet<int> selectedIdsCopy = new HashSet<int>(_getSelectedIds);

                foreach (int id in selectedIdsCopy)
                {
                    DialogResult result = MessageBox.Show($"Do you want to delete the client ID {id}", "Delete Confirmation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        LoanHandlers.DeleteLoanOfClient(id);
                        _clientDb.DeleteClient(id);
                        _getSelectedIds.Remove(id);
                        
                    }
                }
            }
            else
            {
                MessageBox.Show("No Client Selected", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

        private object _getOldCellVal;
        private void ClientTable_CellBeginEdit(object sender, DataGridViewCellCancelEventArgs e)
        {
            if (sender is DataGridView dgv && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                _getOldCellVal = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private object _getNewCellVal;
        private void ClientTable_CellEndEdit(object sender, DataGridViewCellEventArgs e)
        {
            if (sender is DataGridView dgv && e.ColumnIndex >= 0 && e.RowIndex >= 0)
            {
                _getNewCellVal = dgv.Rows[e.RowIndex].Cells[e.ColumnIndex].Value;
            }
        }

        private void ClientTable_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                if (!DateTime.TryParse(e.FormattedValue.ToString(), out _))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter a valid date and time format (e.g., MM/dd/yyyy HH:mm:ss).", "Invalid Date", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SearchTextbox_TextChanged(object sender, EventArgs e)
        {
            _clientDb.SearchClient(SearchTextbox.Text.Trim());
        }

        private void FilterLargest_CheckedChanged(object sender, EventArgs e)
        {
           
        }
    }
}
