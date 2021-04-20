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
using System.IO.Ports;

namespace INUA_JAMII_SACCO
{
    public partial class frmMemberRegistration : Form
    {
        public frmMemberRegistration()
        {
            InitializeComponent();
            loadPorts();
        }

        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";
        public string fn, ln;
        private void mtxtPhonee_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void btnUpdte_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "UPDATE MemberDetails SET firstName= '" + txtFirstN.Text + "', lastname='" + txtLastN.Text + "', Gender = '" + cboGend.Text + "',phoneNo='" + mtxtPhonee.Text + "',NKPhone='" + ccc.Text + "', DateOfReg= '" + dtpRegdate.Text + "'WHERE memberNumber='" + maskedTextBox1.Text + "'";
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

        private void btnReg_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "insert into MemberDetails(memberNumber,firstname, lastname,phoneNo, Gender,NKPhone, contactAddress,DateOfReg) values(" + Convert.ToInt32(maskedTextBox1.Text) + ",'" + txtFirstN.Text + "','" + txtLastN.Text + "','" + mtxtPhonee.Text + "','" + cboGend.Text + "','" + ccc.Text + "','" + txtContact.Text + "','" + dtpRegdate.Text + "')";

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Member Registered Succcessfully.", "Member Registration", MessageBoxButtons.OK, MessageBoxIcon.Information);
                string number, message3;
                number = mtxtPhonee.Text;
                message3 = "Dear" + txtFirstN.Text + " "+txtLastN.Text+ "Your Unique Member Number is "+label1.Text+" You are now a member of INUA JAMII Sacco. Pamoja Tuinuke. Karibu";
                SMS sm = new SMS(cboModemPorts.Text);
                sm.Opens();
                sm.sendSMS(number, message3);
                sm.Closes();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration Failed!" + ex.Message, "Member Registration", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }
        private void loadPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboModemPorts.Items.Add(port);
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            int i;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (i = 0; i <= 200; i++)
            {
                progressBar1.Value = i;
                label11.Text = "Deleting All Member Details.This May take upto 30 seconds. Please wait...";
            }
            SqlConnection connection;
            SqlCommand command;
            SqlCommand command1;
            string sql = null, sql1 = null;
            SqlDataReader dataReader, dataReader1;
            sql1 = "Select firstname,lastname, phoneNo from MemberDetails WHERE memberNumber='" + maskedTextBox1.Text + "'";
            sql= "delete  from MemberDetails,Loan,contribute,LoanRepayment,memberSavings WHERE memberNumber='" + maskedTextBox1.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
               
                command= new SqlCommand(sql, connection);

                command1 = new SqlCommand(sql1, connection);
                dataReader1 = command1.ExecuteReader();
                connection.Open();
                MessageBox.Show("Are Sure you want to Remove all data for this Member? ", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning);
                DialogResult dlg = new DialogResult();
                if (dlg == DialogResult.OK)
                {
                    command = new SqlCommand(sql, connection);
                    command.ExecuteNonQuery();
                    command.Dispose();
                    connection.Close();
                    dataReader = command.ExecuteReader();
                }
                dataReader = command1.ExecuteReader();
                while (dataReader.Read())
                    {
                        string fn = dataReader.GetValue(2).ToString();
                        string ln = dataReader.GetValue(3).ToString();
                        string phone = dataReader.GetValue(4).ToString();
                        string message = "Dear" + " " + fn + " " + ln + ". Your are no longer a member of INUA JAMII SACCO. We Regret your exit. Please consider Reapplying again.";
                    
                        SMS sm = new SMS(cboModemPorts.Text);
                        sm.sendSMS(phone, message);
                        sm.Opens();
                        sm.Closes();
                        MessageBox.Show("All Member Details Removed!", "Member Account Deletion", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        label11.Text = "Action Deletion Progress";
                        progressBar1.Visible = false;
                    }

                    dataReader.Close();
                    command.Dispose();
                    connection.Close();
                }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void toolTip1_Popup(object sender, PopupEventArgs e)
        {

        }

        private void frmMemberRegistration_Load(object sender, EventArgs e)
        {
            toolTip1.SetToolTip(button6, "Will Remove All Member Records!");
            cboGend.Items.Add("Male");
            cboGend.Items.Add("Female");
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnGen_Click(object sender, EventArgs e)
        {
            Random random = new Random();
            int randNo = random.Next(1111, 9999);
            label1.Text = randNo.ToString();
        }

        private void btnSearh_Click(object sender, EventArgs e)
        {

            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from MemberDetails WHERE memberNumber='" + maskedTextBox1.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtFirstN.Text = dataReader.GetValue(0).ToString();
                    txtLastN.Text = dataReader.GetValue(2).ToString();
                    mtxtPhonee.Text = dataReader.GetValue(3).ToString();
                    cboGend.Text = dataReader.GetValue(4).ToString();
                    ccc.Text = dataReader.GetValue(5).ToString();
                    txtContact.Text = dataReader.GetValue(6).ToString();
                    dtpRegdate.Text = dataReader.GetValue(7).ToString();
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

        private void btnDelte_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "delete from MemberDetails WHERE memberNumber='" + maskedTextBox1.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                // MessageBox.Show("Are Sure you want to delete these data? ", "Confirm Deletion", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);
                // DialogResult dlg = new DialogResult();
                // if (dlg == DialogResult.OK)
                // {
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Deleted Successfully  ", "Deletion Report", MessageBoxButtons.OKCancel, MessageBoxIcon.Question);

          //  }
               // else
               // {
                 //   this.Show();
                //}
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
     


        }

        private void btnSearh_Click_1(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from MemberDetails WHERE memberNumber='" + maskedTextBox1.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtFirstN.Text = dataReader.GetValue(1).ToString();
                    txtLastN.Text = dataReader.GetValue(2).ToString();
                    mtxtPhonee.Text = dataReader.GetValue(3).ToString();
                    cboGend.Text = dataReader.GetValue(4).ToString();
                    ccc.Text = dataReader.GetValue(5).ToString();
                    txtContact.Text = dataReader.GetValue(6).ToString();
                    dtpRegdate.Text = dataReader.GetValue(7).ToString();
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

        private void maskedTextBox1_MaskInputRejected(object sender, MaskInputRejectedEventArgs e)
        {

        }

        private void button5_Click(object sender, EventArgs e)
        {
            frmLoanOfficerMain lom2 = new frmLoanOfficerMain();
            lom2.Show();
            this.Hide();
        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {

        }
    }
}
   