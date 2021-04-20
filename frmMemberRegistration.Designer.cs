namespace INUA_JAMII_SACCO
{
    partial class frmMemberRegistration
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label11 = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.cboGend = new System.Windows.Forms.ComboBox();
            this.mtxtPhonee = new System.Windows.Forms.TextBox();
            this.maskedTextBox1 = new System.Windows.Forms.MaskedTextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.dtpRegdate = new System.Windows.Forms.DateTimePicker();
            this.txtLastN = new System.Windows.Forms.TextBox();
            this.txtFirstN = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.btnSearh = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.ccc = new System.Windows.Forms.TextBox();
            this.txtContact = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnGen = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.btnReg = new System.Windows.Forms.Button();
            this.btnUpdte = new System.Windows.Forms.Button();
            this.btnDelte = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.cboModemPorts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label11);
            this.groupBox1.Controls.Add(this.progressBar1);
            this.groupBox1.Controls.Add(this.cboGend);
            this.groupBox1.Controls.Add(this.mtxtPhonee);
            this.groupBox1.Controls.Add(this.maskedTextBox1);
            this.groupBox1.Controls.Add(this.label10);
            this.groupBox1.Controls.Add(this.dtpRegdate);
            this.groupBox1.Controls.Add(this.txtLastN);
            this.groupBox1.Controls.Add(this.txtFirstN);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnSearh);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(352, 339);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Personal Details";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(17, 290);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(151, 15);
            this.label11.TabIndex = 25;
            this.label11.Text = "Account Deletion Progress";
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(17, 308);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(183, 25);
            this.progressBar1.TabIndex = 24;
            this.progressBar1.Click += new System.EventHandler(this.progressBar1_Click);
            // 
            // cboGend
            // 
            this.cboGend.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboGend.FormattingEnabled = true;
            this.cboGend.Location = new System.Drawing.Point(121, 193);
            this.cboGend.Name = "cboGend";
            this.cboGend.Size = new System.Drawing.Size(200, 21);
            this.cboGend.TabIndex = 23;
            // 
            // mtxtPhonee
            // 
            this.mtxtPhonee.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mtxtPhonee.Location = new System.Drawing.Point(121, 144);
            this.mtxtPhonee.MaxLength = 13;
            this.mtxtPhonee.Name = "mtxtPhonee";
            this.mtxtPhonee.Size = new System.Drawing.Size(200, 28);
            this.mtxtPhonee.TabIndex = 22;
            this.mtxtPhonee.Text = "+2547";
            // 
            // maskedTextBox1
            // 
            this.maskedTextBox1.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.maskedTextBox1.Location = new System.Drawing.Point(121, 11);
            this.maskedTextBox1.Mask = "0000";
            this.maskedTextBox1.Name = "maskedTextBox1";
            this.maskedTextBox1.Size = new System.Drawing.Size(200, 28);
            this.maskedTextBox1.TabIndex = 21;
            this.maskedTextBox1.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.maskedTextBox1_MaskInputRejected);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(13, 19);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(102, 15);
            this.label10.TabIndex = 20;
            this.label10.Text = "Member Number";
            // 
            // dtpRegdate
            // 
            this.dtpRegdate.Location = new System.Drawing.Point(121, 250);
            this.dtpRegdate.Name = "dtpRegdate";
            this.dtpRegdate.Size = new System.Drawing.Size(200, 20);
            this.dtpRegdate.TabIndex = 15;
            // 
            // txtLastN
            // 
            this.txtLastN.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLastN.Location = new System.Drawing.Point(121, 85);
            this.txtLastN.Name = "txtLastN";
            this.txtLastN.Size = new System.Drawing.Size(200, 28);
            this.txtLastN.TabIndex = 14;
            // 
            // txtFirstN
            // 
            this.txtFirstN.Font = new System.Drawing.Font("Palatino Linotype", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtFirstN.Location = new System.Drawing.Point(121, 45);
            this.txtFirstN.Name = "txtFirstN";
            this.txtFirstN.Size = new System.Drawing.Size(200, 28);
            this.txtFirstN.TabIndex = 13;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(6, 255);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(77, 15);
            this.label9.TabIndex = 12;
            this.label9.Text = "Date Of Reg.";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(5, 144);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(91, 15);
            this.label8.TabIndex = 11;
            this.label8.Text = "Phone Number";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(14, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 10;
            this.label5.Text = "Gender ";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(13, 90);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(67, 15);
            this.label3.TabIndex = 8;
            this.label3.Text = "Last Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(14, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 15);
            this.label2.TabIndex = 7;
            this.label2.Text = "First Name";
            // 
            // btnSearh
            // 
            this.btnSearh.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSearh.Location = new System.Drawing.Point(238, 297);
            this.btnSearh.Name = "btnSearh";
            this.btnSearh.Size = new System.Drawing.Size(91, 36);
            this.btnSearh.TabIndex = 6;
            this.btnSearh.Text = "&SEACRH";
            this.btnSearh.UseVisualStyleBackColor = true;
            this.btnSearh.Click += new System.EventHandler(this.btnSearh_Click_1);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.ccc);
            this.groupBox2.Controls.Add(this.txtContact);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Location = new System.Drawing.Point(419, 211);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(265, 157);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Other Details";
            // 
            // ccc
            // 
            this.ccc.Location = new System.Drawing.Point(111, 24);
            this.ccc.MaxLength = 13;
            this.ccc.Name = "ccc";
            this.ccc.Size = new System.Drawing.Size(148, 20);
            this.ccc.TabIndex = 3;
            this.ccc.Text = "+2547";
            // 
            // txtContact
            // 
            this.txtContact.Location = new System.Drawing.Point(111, 70);
            this.txtContact.Name = "txtContact";
            this.txtContact.Size = new System.Drawing.Size(148, 20);
            this.txtContact.TabIndex = 2;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(10, 70);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(95, 15);
            this.label7.TabIndex = 1;
            this.label7.Text = "Contact Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(7, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(104, 15);
            this.label6.TabIndex = 0;
            this.label6.Text = "Next Of KinPhone";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnGen);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Location = new System.Drawing.Point(419, 50);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(238, 112);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Get Member Number ";
            // 
            // btnGen
            // 
            this.btnGen.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnGen.Location = new System.Drawing.Point(98, 64);
            this.btnGen.Name = "btnGen";
            this.btnGen.Size = new System.Drawing.Size(102, 34);
            this.btnGen.TabIndex = 2;
            this.btnGen.Text = "&GENERATE";
            this.btnGen.UseVisualStyleBackColor = true;
            this.btnGen.Click += new System.EventHandler(this.btnGen_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("MS Reference Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(75, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 15);
            this.label1.TabIndex = 0;
            this.label1.Text = "New Member Number";
            // 
            // btnReg
            // 
            this.btnReg.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReg.Location = new System.Drawing.Point(69, 376);
            this.btnReg.Name = "btnReg";
            this.btnReg.Size = new System.Drawing.Size(98, 39);
            this.btnReg.TabIndex = 3;
            this.btnReg.Text = "&REGISTER";
            this.btnReg.UseVisualStyleBackColor = true;
            this.btnReg.Click += new System.EventHandler(this.btnReg_Click);
            // 
            // btnUpdte
            // 
            this.btnUpdte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdte.Location = new System.Drawing.Point(251, 375);
            this.btnUpdte.Name = "btnUpdte";
            this.btnUpdte.Size = new System.Drawing.Size(90, 39);
            this.btnUpdte.TabIndex = 4;
            this.btnUpdte.Text = "&UPDATE";
            this.btnUpdte.UseVisualStyleBackColor = true;
            this.btnUpdte.Click += new System.EventHandler(this.btnUpdte_Click);
            // 
            // btnDelte
            // 
            this.btnDelte.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDelte.Location = new System.Drawing.Point(391, 376);
            this.btnDelte.Name = "btnDelte";
            this.btnDelte.Size = new System.Drawing.Size(75, 39);
            this.btnDelte.TabIndex = 5;
            this.btnDelte.Text = "&DELETE";
            this.btnDelte.UseVisualStyleBackColor = true;
            this.btnDelte.Click += new System.EventHandler(this.btnDelte_Click);
            // 
            // button5
            // 
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button5.ForeColor = System.Drawing.Color.Blue;
            this.button5.Location = new System.Drawing.Point(530, 375);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(75, 40);
            this.button5.TabIndex = 7;
            this.button5.Text = "&EXIT";
            this.button5.UseVisualStyleBackColor = true;
            this.button5.Click += new System.EventHandler(this.button5_Click);
            // 
            // button6
            // 
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button6.ForeColor = System.Drawing.Color.Red;
            this.button6.Location = new System.Drawing.Point(419, 12);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(238, 32);
            this.button6.TabIndex = 8;
            this.button6.Text = "DELETE ACCOUNT MEMBERSHIP ACCOUNT ";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // toolTip1
            // 
            this.toolTip1.ToolTipIcon = System.Windows.Forms.ToolTipIcon.Warning;
            this.toolTip1.ToolTipTitle = "Remove member Account";
            this.toolTip1.Popup += new System.Windows.Forms.PopupEventHandler(this.toolTip1_Popup);
            // 
            // cboModemPorts
            // 
            this.cboModemPorts.FormattingEnabled = true;
            this.cboModemPorts.Location = new System.Drawing.Point(486, 179);
            this.cboModemPorts.Name = "cboModemPorts";
            this.cboModemPorts.Size = new System.Drawing.Size(171, 21);
            this.cboModemPorts.TabIndex = 9;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(388, 182);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "COM Ports";
            // 
            // frmMemberRegistration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 417);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboModemPorts);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.btnDelte);
            this.Controls.Add(this.btnUpdte);
            this.Controls.Add(this.btnReg);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmMemberRegistration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Registration";
            this.Load += new System.EventHandler(this.frmMemberRegistration_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnGen;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnReg;
        private System.Windows.Forms.Button btnUpdte;
        private System.Windows.Forms.Button btnDelte;
        private System.Windows.Forms.Button btnSearh;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.DateTimePicker dtpRegdate;
        private System.Windows.Forms.TextBox txtLastN;
        private System.Windows.Forms.TextBox txtFirstN;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtContact;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TextBox mtxtPhonee;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
        private System.Windows.Forms.TextBox ccc;
        private System.Windows.Forms.ComboBox cboGend;
        private System.Windows.Forms.ComboBox cboModemPorts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.ProgressBar progressBar1;
    }
}