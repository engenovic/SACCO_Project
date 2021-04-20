using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace INUA_JAMII_SACCO
{
    public partial class frmLoanOfficerMain : Form
    {
        public frmLoanOfficerMain()
        {
            InitializeComponent();
        }

        private void lblLoanOfficer_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
           
        }

        private void membersToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmMemberRegistration membr = new frmMemberRegistration();
            membr.Show();
            this.Hide();
        }
        private void reportsToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            frmViewRecords frmrepot = new frmViewRecords();
            frmrepot.Show();
            this.Hide();
        }

        private void lOGOUTToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLogin frmLog1 = new frmLogin();
            frmLog1.Show();
            this.Close();
        }

        private void mEMBERLOANSToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLoanProcessing lp = new frmLoanProcessing();
            lp.Show();
            this.Hide();
        }
    }
}