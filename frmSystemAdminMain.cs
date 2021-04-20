using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO.Ports;
using System.Data.SqlClient;
namespace INUA_JAMII_SACCO
{
    public partial class frmSystemAdminMain : Form
    {
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";
        public frmSystemAdminMain()
        {
            InitializeComponent();
        }
        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "insert into login(Username, Password,StaffTitle) values('" + txtUsernme.Text + "', '" + txtPasss.Text + "','" + txtStaff.Text + "')";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" New Staff Has been Added!", "Staff Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            txtPasss.Text = "";
            txtUsernme.Text = "";
            txtStaff.Text = "";
            Random randNm = new Random();
            int randNo = randNm.Next(1111,4444);
            lblNewPass.Text = randNo.ToString();
        }

        private void btnLogoutt_Click(object sender, EventArgs e)
        {
            frmLogin frmLog = new frmLogin();
            frmLog.Show();
            this.Close();
        }

        private void btnBusUpdate_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
           SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "UPDATE UpdateSacco SET SInterest= '" + textBox1.Text + "', LInterest='" + txtLInt.Text+ "', LRepayPeriod = '" + txtLInt.Text+ "' WHERE upId='" + textBox2.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Records Updated Succcessfully!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "delete from login WHERE Username='" + txtUsernme.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                MessageBox.Show("Are Sure you want to delete these data? ", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                DialogResult dlg = new DialogResult();
                if (dlg == DialogResult.OK)
                {
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    MessageBox.Show("Deleted Successfully", " Deletion Report", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                }
                else
                {
                    this.Show();
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }


        }

        private void btnView_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from UpdateSacco WHERE upId='" + textBox2.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtPasss.Text = dataReader.GetValue(1).ToString();
                    txtStaff.Text = dataReader.GetValue(2).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from login WHERE Username='" + txtUsernme.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtPasss.Text = dataReader.GetValue(1).ToString();
                    txtStaff.Text = dataReader.GetValue(2).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }

        }
    }
}