using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO.Ports;
namespace INUA_JAMII_SACCO
{
    public partial class frmLoanProcessing : Form
    {
        public frmLoanProcessing()
        {
            InitializeComponent();
            loadPorts();
        }
        public string connectionString = "Data Source=LAPTOP-TFPVGSED;Initial Catalog=SaccoDB;Integrated Security = True";
        public string fn, ln, phone;
        private string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 1; i < size + 1; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            else
                return builder.ToString();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection;


            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select * from Loan  WHERE memberNumber='" + mtxtMNo.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    cboLoan.Text= dataReader.GetValue(2).ToString();
                    txtAmount.Text = dataReader.GetValue(3).ToString();
                    dtpDte.Text = dataReader.GetValue(4).ToString();
                    cboLoanStat.Text = dataReader.GetValue(5).ToString();
                    cboDisburse.Text = dataReader.GetValue(6).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }

            catch (Exception)
            {
                MessageBox.Show("Failed to Establish Connection! ");
            }
            button2.Enabled = true;
        }


        private void frmLoanProcessing_Load(object sender, EventArgs e)

        {

            cboDisburse.Items.Add("MPESA");
            cboDisburse.Items.Add("CASH");
            cboLoan.Items.Add("Normal");
            cboLoan.Items.Add("Emergency");
            cboLoanStat.Items.Add("Registered");
            cboLoanStat.Items.Add("Approved");
            cboLoanStat.Items.Add("Denied");
 
            btnApprov.Enabled = false;
            button2.Enabled = false;
        }

        private void button2_Click(object sender, EventArgs e)
        {

            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select LoanBalance from LoanRepayment WHERE memberNumber='" + mtxtMNo.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    int LoanBalance = dataReader.GetInt32(0);
                    if (LoanBalance > 0)
                    {
                        MessageBox.Show("Kshs. " + LoanBalance + " Exist!", "Member Loan Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboLoanStat.Text = "Denied";
                    }
                    else
                    {
                        MessageBox.Show("No existing Loan Was found. Click Update Status to Continue", "Member Loan Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        cboLoanStat.Text = "Approved";
                    }
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

        private void cboComPorts_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cboComPorts.Text != null)
            {
                btnApprov.Enabled = true;
            }
        }

        private void btnSve_Click(object sender, EventArgs e)
        {
            
            SqlConnection connection;
            SqlCommand command;
            string sql = null;



            sql = "insert into Loan(memberNumber,LoanType,LoanAmount,date, LoanStatus, DisbursementMode) values("+mtxtMNo.Text+",'" + cboLoan.Text + "'," + txtAmount.Text + ",'" + dtpDte.Text + "','" + cboLoanStat.Text + "','"+ cboDisburse.Text+ "')";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                command.ExecuteNonQuery();
                command.Dispose();
                connection.Close();
                MessageBox.Show(" Loan Applied Successfully.","Loan Application", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Application Failed!" + ex.Message, "Loan Appliaction", MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
            }
        }

        private void btnExit_Click(object sender, EventArgs e)
        {frmLoanOfficerMain lom1 = new frmLoanOfficerMain();
            lom1.Show();
            this.Hide();
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "UPDATE Loan SET Loan Type= '" + cboLoan.Text + "', Loan Amount='" + cboLoan.Text + "', Date= '" + dtpDte.Text + "',Loan Status='" + cboLoanStat.Text + "',ReffCode='" + txtReffcode.Text + "',Disbursment Mode='"+cboDisburse.Text+"' WHERE memberNumber='" + mtxtMNo.Text + "'";
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

        private void cboLoan_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void btnDletee_Click(object sender, EventArgs e)
        {

            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            sql = "delete from loan WHERE memberNumber='" + mtxtMNo.Text + "'";
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

        private void btnApprov_Click(object sender, EventArgs e)
        {

            SqlConnection connection;
            SqlCommand command;
            string sql = null;
            SqlDataReader dataReader;
            sql = "Select firstname,lastname, phoneNo from MemberDetails WHERE memberNumber='" + mtxtMNo.Text + "'";
            connection = new SqlConnection(connectionString);
            try
            {
                connection.Open();
                command = new SqlCommand(sql, connection);
                dataReader = command.ExecuteReader();
                while (dataReader.Read())
                {
                    phone = dataReader.GetValue(2).ToString();
                    fn = dataReader.GetValue(0).ToString();
                    ln = dataReader.GetValue(1).ToString();
                }
                dataReader.Close();
                command.Dispose();
                connection.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
            string number, message1, message2,message3;
            txtReffcode.Text = (RandomString(8, false));
            number = phone;
            message1 = "Dear" + " " + fn + " " + ln + ". Your Loan Of Kshs. " + " " + txtAmount.Text + "  REF.NO"+" " +txtReffcode.Text+ " has been Approved." + " You will receive the money within 24 hrs. Thank You.";
            message2 = "Dear" + " " + fn + " " + ln + ". Your Loan request Of Kshs. " + " " + txtAmount.Text + " REF.NO "+" " + txtReffcode.Text + " was denied. Please pay the existing loan.";
            message3 = "Dear" + " " + fn + " " + ln + ". Your Loan Application Of Kshs. " + " " + txtAmount.Text + " REF.NO "+" " + txtReffcode.Text + " has been Received. You shall be notified upon processing.";
            SMS sm = new SMS(cboComPorts.Text);
            sm.Opens();
            if (cboLoanStat.Text == "Approved")
            {
                sm.sendSMS(number, message1);
            }
            else if(cboLoanStat.Text=="Denied")
            {
                sm.sendSMS(number, message2);
            }
            else if(cboLoanStat.Text=="Registered")
            {
                sm.sendSMS(number, message3);
            }
            else
            {
                cboLoanStat.Visible = false;
            }

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
    }
}
   