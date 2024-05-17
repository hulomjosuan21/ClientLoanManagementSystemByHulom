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
    public partial class AddClientForm : Form
    {
        public string Firstname { get; set; }
        public string Lastname { get; set; }
        public string Residency { get; set; }
        public DateTime Birthdate { get; set; }

        public AddClientForm()
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

        private void AddButton_Click_1(object sender, EventArgs e)
        {
            Firstname = FirstnameTextbox.Text.Trim();
            Lastname = LastnameTextbox.Text.Trim();
            Residency = ResidencyTextbox.Text.Trim();
            Birthdate = BdayInput.Value;

            if (string.IsNullOrWhiteSpace(Firstname) || string.IsNullOrWhiteSpace(Lastname) || string.IsNullOrWhiteSpace(Residency))
            {
                MessageBox.Show("Please fill out all fields.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (AddClientForm.CalculateAge(Birthdate) >= 18)
            {
                DialogResult = DialogResult.OK;
            }
            else
            {
                MessageBox.Show("Clients must be at least 18 years old.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void CancelButton_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
        }

        public static void ValidateStringOnlyTextBox(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        public static int CalculateAge(DateTime birthDate)
        {
            DateTime currentDate = DateTime.Today;
            int age = currentDate.Year - birthDate.Year;
            if (birthDate.Date > currentDate.AddYears(-age))
            {
                age--;
            }
            return age;
        }
    }
}
