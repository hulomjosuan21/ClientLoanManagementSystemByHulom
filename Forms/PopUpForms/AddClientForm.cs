using System;
using System.ComponentModel.DataAnnotations;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    [Author]
    public partial class AddClientForm : Form
    {
        [Required]
        public string Firstname { get; set; }
        [Required]
        public string Lastname { get; set; }
        [Required]
        public string Residency { get; set; }
        [Required]
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
