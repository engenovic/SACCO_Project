using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO.Ports;
using CrystalDecisions.CrystalReports.Engine;
using System.Data.SqlClient;

namespace INUA_JAMII_SACCO
{
    public partial class frmAccountantMain : Form
    {
        public frmAccountantMain()
        {
            InitializeComponent();
            loadPorts();

        }
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";
        public string fn, ln;
        private void btnSendSing_Click(object sender, EventArgs e)
        {
            string number, message;
            number = txtPhone.Text;
            message = "Dear" + " " + fn + rchMessage.Text;
            SMS sm = new SMS(cboComPorts.Text);
            sm.Opens();
            sm.sendSMS(number, message);
            sm.Closes();
            MessageBox.Show("Message Was Sent Successfully!", "Messaging Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
        private void loadPorts()
        {
            string[] ports = SerialPort.GetPortNames();
            foreach (string port in ports)
            {
                cboComPorts.Items.Add(port);
            }
        }



        private void btnLogout_Click(object sender, EventArgs e)
        {
            frmLogin logingrm1 = new frmLogin();
            logingrm1.Show();
            this.Close();
        }

        private void btnFind_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from Loan WHERE MemberNumber='" + masktxtMember.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cboLoanStatus.Text = dataReader.GetValue(1).ToString();
                    cboLoanStatus.Text = dataReader.GetValue(2).ToString();
                    txtLoanAmt.Text = dataReader.GetValue(3).ToString();
                    cboDisburseMode.Text = dataReader.GetValue(5).ToString();
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

        private void button2_Click(object sender, EventArgs e)
        {
            CachedCrystalReport1 rpt = new CachedCrystalReport1();
            crystalReportViewer1.ReportSource = rpt;
        }

        private void frmAccountantMain_Load(object sender, EventArgs e)
        {

        }

        private void btnSendBulk_Click(object sender, EventArgs e)
        {
            int a;

            progressBar1.Minimum = 0;
            progressBar1.Maximum = 200;

            for (a= 0; a <= 200; a++)
            {
                progressBar1.Value = a;
                label16.Text = "Sending Message.This will take a few more seconds seconds. Please wait...";

            }
           
            SqlConnection connection;
            SqlCommand command;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataSet ds = new DataSet();
            int i = 0;
            string sql = null;
            sql = "Select firstname, phoneNo from MemberDetails";

            connection = new SqlConnection(connectionString);

            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                adapter.SelectCommand = command;
                adapter.Fill(ds);
                adapter.Dispose();
                command.Dispose();
                connection.Close();

                for (i = 0; i <= ds.Tables[0].Rows.Count - 1; i++)
                {
                    string jina = (ds.Tables[0].Rows[i].ItemArray[0]).ToString();
                    string number = ((ds.Tables[0].Rows[i].ItemArray[1])).ToString();
                    string messo = "Hi " + jina + ". " + rchMessageBulk.Text;
                    SMS sm = new SMS(cboComPorts.Text);
                    sm.Opens();
                    sm.sendSMS(number, messo);
                    sm.Closes();

                }
                MessageBox.Show("All Messages sent!","Bulk SMS Report", MessageBoxButtons.OK, MessageBoxIcon.Information);
                label16.Text = "Sending Bulk SMS";
                progressBar1.Visible = false;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlCommand command1;
            SqlCommand command2;
            string sql = null;
            SqlDataReader dataReader1;
            SqlDataReader dataReader2;
            string sql1 = null;
            string sql2 = null;
            sql = "insert into contribute(amount, date) values(" + textBox2.Text + ",'" + dateTimePicker1.Text + "' WHERE memberNumber='" + mtxtMNumber.Text + "')";
            sql1 = "Select firstname, phoneNo from MemberDetails WHERE memberNumber=" + mtxtMNumber.Text + "";
            sql2 = "Select TotalSaved from contribute WHERE memberNumber=" + mtxtMNumber.Text + "";

            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command1 = new SqlCommand(sql1, connection);
                dataReader1 = command1.ExecuteReader();
                command2 = new SqlCommand(sql1, connection);
                dataReader2 = command1.ExecuteReader();
                string number = null, message, firstName = null;
                int totalsavings = 0;
                while (dataReader1.Read())
                {
                    number = dataReader1.GetValue(0).ToString();
                    firstName = dataReader1.GetValue(2).ToString();
                }
                dataReader2 = command.ExecuteReader();
                while (dataReader2.Read())
                {
                    totalsavings = dataReader2.GetInt32(0);
                }
                dataReader1.Close();
                dataReader2.Close();
                command.Dispose();
                command1.Dispose();
                command2.Dispose();
                connection.Close();
                message = "Dear" + firstName + ",Your Savings of Kshs." + textBox2.Text + "" + "has been received. Your total Savings as at" + DateTime.Now.ToString("M - d - yyyy") + "was Kshs." + totalsavings + "" + "Thank you";
                SMS sm = new SMS(cboComPorts.Text);
                sm.Opens();
                sm.sendSMS(number, message);
                sm.Closes();
                MessageBox.Show(" Records Succcessfully Saved.", "Member Savings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show( ex.Message);
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select firstname,lastname, phoneNo from MemberDetails WHERE memberNumber='" + txtMemberNumber.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtPhone.Text = dataReader.GetValue(2).ToString();
                    fn = dataReader.GetValue(0).ToString();
                    ln = dataReader.GetValue(1).ToString();
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

        private void btnFindL_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from LoanRepayment WHERE MemberNumber='" + masktxtMember.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    txtRepaidL.Text = dataReader.GetValue(1).ToString();
                    txtLoanAmt.Text = dataReader.GetValue(2).ToString();
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

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlCommand command1;
            SqlCommand command2, command3;
            string sql = null;
            SqlDataReader dataReader1;
            SqlDataReader dataReader2;
            string sql1 = null;
            string sql2 = null;
            int LoanBalance = 0;
            sql = "insert into LoanRepayment(Amount, date) values(" + txtRepaidL.Text + "," + dtpOfRepay.Text + " WHERE memberNumber=" + maskedtxtMeN.Text + ")";
            sql1 = "Select firstname, phoneNo from MemberDetails WHERE memberNumber=" + maskedtxtMeN.Text + "";
            sql2 = "Select LoanBalance from LoanRepament WHERE memberNumber=" + maskedtxtMeN.Text + "";
            string sql3 = "update LoanRepament set LoanBalance= " + LoanBalance + "WHERE memberNumber=" + maskedtxtMeN.Text + "";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command1 = new SqlCommand(sql1, connection);
                dataReader1 = command1.ExecuteReader();
                command2 = new SqlCommand(sql2, connection);
                dataReader2 = command1.ExecuteReader();
                string number = null, message, firstName = null;
                while (dataReader1.Read())
                {
                    number = dataReader1.GetValue(0).ToString();
                    firstName = dataReader1.GetValue(2).ToString();
                }
                dataReader2 = command.ExecuteReader();
                while (dataReader2.Read())
                {
                    LoanBalance = dataReader2.GetInt32(0);
                }
                LoanBalance = LoanBalance - Convert.ToInt32(txtRepaidL.Text);
                command3 = new SqlCommand(sql3, connection);
                command3.ExecuteNonQuery();
                message = "Dear" + firstName + ",Your loan repayment of Kshs." + txtRepaidL.Text+ "" + "has been received. Your outstanding Loan Balance as at " + DateTime.Now.ToString("M - d - yyyy") + "was Kshs." + LoanBalance + "" + "Thank you";
                SMS sm = new SMS(cboComPorts.Text);
                sm.Opens();
                sm.sendSMS(number, message);
                command1 = new SqlCommand(sql1, connection);

                dataReader1.Close();
                dataReader2.Close();
                command.Dispose();
                command1.Dispose();
                command2.Dispose();
                connection.Close();
                MessageBox.Show(" Records Succcessfully Saved.", "Member Savings", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Save the records" + ex.Message, "Member Savings", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnDisburse_Click_1(object sender, EventArgs e)
        {

        }

        private void btnDisburse_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            SqlCommand command1;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select LoanStatus from loan WHERE memberNumber='" + masktxtMember.Text + "'";
            string sq2 = " update Loan set LoanStatus='Disbursed' WHERE memberNumber='" + masktxtMember.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    if ((dataReader.GetValue(0).ToString()) == "Approved")
                    {
                        command1 = new SqlCommand(sql, connection);
                        command1.ExecuteNonQuery();
                    }
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
                MessageBox.Show("Records Updated Successfully", "Savings Update", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }

        }
    }
}