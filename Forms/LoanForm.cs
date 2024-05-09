using ClientLoanManagementSystemByHulom.Entities;
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
        private int _currentClientId;
        public LoanForm(int _currentClientId = 0)
        {
            InitializeComponent();
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
            loanBindingSource.DataSource = new hulomdbEntities().Loans.Where(l => l.ClientId == _currentClientId).ToList();
        }
    }
}
