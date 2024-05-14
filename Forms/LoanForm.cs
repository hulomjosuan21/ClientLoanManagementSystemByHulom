﻿using ClientLoanManagementSystemByHulom.Entities;
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
    public partial class LoanForm : Form
    {
        private const string CURRENCY = "en-PH";
        private int _currentClientId;
        private LoanHandlers _loanDb;
        public LoanForm(int _currentClientId = 0)
        {
            InitializeComponent();
            InitializeAddedComponent();
            this._currentClientId = _currentClientId;

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
        
        private void LoanForm_Load(object sender, EventArgs e)
        {
            Text = $"Cliend ID #{_currentClientId}";
            _loanDb = new LoanHandlers(_currentClientId,loanBindingSource);
        }

        private void StatusButton_Click(object sender, EventArgs e)
        {
            SetStatusForm getStatus = new SetStatusForm();
            if (getStatus.ShowDialog() == DialogResult.OK)
            {
                _loanDb.SetStatus(_loanId, getStatus.SelectedStatus.ToString());
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
            }
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
    }
}
