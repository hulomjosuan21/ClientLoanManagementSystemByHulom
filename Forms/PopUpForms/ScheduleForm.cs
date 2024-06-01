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

namespace ClientLoanManagementSystemByHulom.Forms.PopUpForms
{
    public partial class ScheduleForm : Form
    {
        private readonly int loanID, clientID;
        public ScheduleForm(int loanID, int clientID)
        {
            InitializeComponent();
            this.loanID = loanID;
            this.clientID = clientID;
        }

        private void ScheduleForm_Load(object sender, EventArgs e)
        {
            Text = $"Loan #{loanID} : #{clientID}";

            using (hulomdbEntities _con = new hulomdbEntities())
            {
                List<Schedule> _source = _con.Schedules.Where(_ => _.LoanID == loanID && _.ClientID == clientID).ToList();
                scheduleBindingSource.DataSource = _source;
            }
        }
    }
}
