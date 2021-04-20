using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
namespace INUA_JAMII_SACCO
{
    public partial class frmViewRecords : Form
    {
        public frmViewRecords()
        {
            InitializeComponent();
        }

        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";
        private void btnExtie_Click(object sender, EventArgs e)
        {
            frmLoanOfficerMain from1 = new frmLoanOfficerMain();
            from1.Show();
            this.Hide();
        }

        private void btnDispl_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM MemberDetails";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "MemberDetails");
            connection.Close();
            dgtmembers.DataSource = ds;
           dgtmembers.DataMember = "MemberDetails";
        }

        private void btnPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            Bitmap bm = new Bitmap(this.dgtmembers.Width, this.dgtmembers.Height);
            dgtmembers.DrawToBitmap(bm, new Rectangle(0, 0, this.dgtmembers.Width, this.dgtmembers.Height));
            e.Graphics.DrawImage(bm, 0, 0);
        }

        
      

        private void button2_Click(object sender, EventArgs e)
        {
            string sql = "SELECT * FROM memberSavings WHERE amount>0";
            SqlConnection connection = new SqlConnection(connectionString);
            SqlDataAdapter dataadapter = new SqlDataAdapter(sql, connection);
            DataSet ds = new DataSet();
            connection.Open();
            dataadapter.Fill(ds, "Member Details");
            connection.Close();
            dgtmembers.DataSource = ds;
            dgtmembers.DataMember = "MemberDetails";
        }
    }
}
