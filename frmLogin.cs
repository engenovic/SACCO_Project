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
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";

        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (txtUsername.Text == "" || maskedTextBox1.Text == "")
            {
                MessageBox.Show("Both fields are needed!", "Invalid Input", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }
            SqlConnection con = new SqlConnection(connectionString);
            try
            {
                SqlCommand cmd = new SqlCommand("Select * from login where UserName=@username and Password=@password", con);
                cmd.Parameters.AddWithValue("@username", txtUsername.Text);
                cmd.Parameters.AddWithValue("@password", maskedTextBox1.Text);
                con.Open();
                SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                DataSet ds = new DataSet();
                adapt.Fill(ds);
                con.Close();
                int count = ds.Tables[0].Rows.Count;
                if (count == 1)
                {
                    
                    frmMainForm fm = new frmMainForm();
                    fm.Show();
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("You have entered wrong information!", "Wrong Information", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Are you Sure you want to Leave?", "Confirm Exit", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            DialogResult Dres = new DialogResult();
            if (Dres == DialogResult.Yes)
            {
                Close();
            }


        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }
    }
}
