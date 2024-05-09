using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    public partial class AddLoanForm : Form
    {
        public double LoanAmt { get; set; }
        public double Interest { get; set; }
        public PaymentTerm SelectedTerm { get; set; }
        public int NoOfPayment { get; set; }
        public double Deduction { get; set; }

        public AddLoanForm()
        {
            InitializeComponent();
            InitializeAddedComponent();
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

        private void AddLoanForm_Load(object sender, EventArgs e)
        {
            TermComboBox.DataSource = Enum.GetValues(typeof(PaymentTerm));
        }

        private void AddButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        private void InputChanges(object sender, EventArgs e)
        {

        }

        public static void CatchNonNumericInput(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
