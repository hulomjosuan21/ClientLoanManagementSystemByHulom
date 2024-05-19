using System;
using System.Windows.Forms;

namespace ClientLoanManagementSystemByHulom
{
    [Author]
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

            AuthorAttribute classAttribute = (AuthorAttribute)Attribute.GetCustomAttribute(typeof(MainForm), typeof(AuthorAttribute));

            FooterLabel.Text += classAttribute.Name;
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

    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Interface | AttributeTargets.Enum, Inherited = false, AllowMultiple = false)]
    sealed class AuthorAttribute : Attribute
    {
        public string Name = "Josuan Leonardo Hulom BSIT 2A";
    }
}
