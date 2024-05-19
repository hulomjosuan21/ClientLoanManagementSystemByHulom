using ClientLoanManagementSystemByHulom.Utilities;
using System;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    [Author]
    public partial class SetStatusForm : Form
    {
        public string SelectedStatus = LoanStatus.Ongoing.ToString();

        public SetStatusForm()
        {
            InitializeComponent();
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

        private void SetStatusForm_Load(object sender, EventArgs e)
        {
            ComboBox.DataSource = Enum.GetValues(typeof(LoanStatus));
        }

        private void SetButton_Click(object sender, EventArgs e)
        {
            SelectedStatus = ComboBox.SelectedItem.ToString();
            DialogResult = DialogResult.OK;
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }
    }
}
