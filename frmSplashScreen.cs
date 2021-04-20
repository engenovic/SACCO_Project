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
    public partial class frmSplashScreen : Form
    {
        public frmSplashScreen()
        {
            InitializeComponent();
           
        }
        Timer tmr;
        private void frmSplashScreen_Load(object sender, EventArgs e)
        {
            tmr = new Timer();
            //set time interval 3 sec
            tmr.Interval = 10000;
            //starts the timer
            tmr.Start();
            tmr.Tick += timer1_Tick;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            tmr.Stop();
            frmLogin frmL = new frmLogin();
            frmL.Show();
            this.Hide();
        }
    }
}
