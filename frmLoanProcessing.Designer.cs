namespace INUA_JAMII_SACCO
{
    partial class frmLoanProcessing
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.dtpDte = new System.Windows.Forms.DateTimePicker();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnDletee = new System.Windows.Forms.Button();
            this.txtReffcode = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cboLoanStat = new System.Windows.Forms.ComboBox();
            this.cboDisburse = new System.Windows.Forms.ComboBox();
            this.cboLoan = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnApprov = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.btnSve = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.mtxtMNo = new System.Windows.Forms.MaskedTextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.btnExit = new System.Windows.Forms.Button();
            this.cboComPorts = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(-2, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(114, 14);
            this.label2.TabIndex = 1;
            this.label2.Text = "Loan Type Applied";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(17, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 14);
            this.label3.TabIndex = 2;
            this.label3.Text = "Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(6, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(98, 14);
            this.label5.TabIndex = 4;
            this.label5.Text = "Amount Applied";
            // 
            // dtpDte
            // 
            this.dtpDte.Location = new System.Drawing.Point(118, 157);
            this.dtpDte.Name = "dtpDte";
            this.dtpDte.Size = new System.Drawing.Size(160, 20);
            this.dtpDte.TabIndex = 6;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnDletee);
            this.groupBox1.Controls.Add(this.txtReffcode);
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.cboLoanStat);
            this.groupBox1.Controls.Add(this.cboDisburse);
            this.groupBox1.Controls.Add(this.cboLoan);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnUpdate);
            this.groupBox1.Controls.Add(this.btnApprov);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.txtAmount);
            this.groupBox1.Controls.Add(this.btnSve);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.mtxtMNo);
            this.groupBox1.Controls.Add(this.dtpDte);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Location = new System.Drawing.Point(1, 46);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(499, 363);
            this.groupBox1.TabIndex = 8;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Request Loan";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // btnDletee
            // 
            this.btnDletee.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDletee.Location = new System.Drawing.Point(402, 236);
            this.btnDletee.Name = "btnDletee";
            this.btnDletee.Size = new System.Drawing.Size(91, 48);
            this.btnDletee.TabIndex = 27;
            this.btnDletee.Text = "&DELETE";
            this.btnDletee.UseVisualStyleBackColor = true;
            this.btnDletee.Click += new System.EventHandler(this.btnDletee_Click);
            // 
            // txtReffcode
            // 
            this.txtReffcode.Location = new System.Drawing.Point(119, 236);
            this.txtReffcode.Name = "txtReffcode";
            this.txtReffcode.ReadOnly = true;
            this.txtReffcode.Size = new System.Drawing.Size(160, 20);
            this.txtReffcode.TabIndex = 26;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(17, 236);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(95, 14);
            this.label8.TabIndex = 25;
            this.label8.Text = "Reference Code";
            // 
            // cboLoanStat
            // 
            this.cboLoanStat.BackColor = System.Drawing.Color.Red;
            this.cboLoanStat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoanStat.FormattingEnabled = true;
            this.cboLoanStat.Location = new System.Drawing.Point(118, 196);
            this.cboLoanStat.Name = "cboLoanStat";
            this.cboLoanStat.Size = new System.Drawing.Size(160, 21);
            this.cboLoanStat.TabIndex = 24;
            // 
            // cboDisburse
            // 
            this.cboDisburse.FormattingEnabled = true;
            this.cboDisburse.Location = new System.Drawing.Point(119, 276);
            this.cboDisburse.Name = "cboDisburse";
            this.cboDisburse.Size = new System.Drawing.Size(160, 21);
            this.cboDisburse.TabIndex = 23;
            // 
            // cboLoan
            // 
            this.cboLoan.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboLoan.FormattingEnabled = true;
            this.cboLoan.Location = new System.Drawing.Point(118, 71);
            this.cboLoan.Name = "cboLoan";
            this.cboLoan.Size = new System.Drawing.Size(160, 21);
            this.cboLoan.TabIndex = 22;
            this.cboLoan.SelectedIndexChanged += new System.EventHandler(this.cboLoan_SelectedIndexChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(-2, 283);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(120, 14);
            this.label7.TabIndex = 16;
            this.label7.Text = "Disbursement Mode";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 196);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(73, 14);
            this.label1.TabIndex = 14;
            this.label1.Text = "Loan Status";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnUpdate.Location = new System.Drawing.Point(402, 172);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(91, 48);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "&UPDATE";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnApprov
            // 
            this.btnApprov.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApprov.Location = new System.Drawing.Point(402, 296);
            this.btnApprov.Name = "btnApprov";
            this.btnApprov.Size = new System.Drawing.Size(91, 54);
            this.btnApprov.TabIndex = 8;
            this.btnApprov.Text = "&CONFIRM";
            this.btnApprov.UseVisualStyleBackColor = true;
            this.btnApprov.Click += new System.EventHandler(this.btnApprov_Click);
            // 
            // button2
            // 
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(118, 303);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(143, 47);
            this.button2.TabIndex = 9;
            this.button2.Text = "&CHECK STATUS";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(119, 114);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.Size = new System.Drawing.Size(160, 20);
            this.txtAmount.TabIndex = 8;
            // 
            // btnSve
            // 
            this.btnSve.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSve.Location = new System.Drawing.Point(402, 86);
            this.btnSve.Name = "btnSve";
            this.btnSve.Size = new System.Drawing.Size(91, 48);
            this.btnSve.TabIndex = 11;
            this.btnSve.Text = "&SAVE";
            this.btnSve.UseVisualStyleBackColor = true;
            this.btnSve.Click += new System.EventHandler(this.btnSve_Click);
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(402, 13);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(91, 43);
            this.button1.TabIndex = 10;
            this.button1.Text = "S&EARCH";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // mtxtMNo
            // 
            this.mtxtMNo.Location = new System.Drawing.Point(119, 22);
            this.mtxtMNo.Mask = "0000";
            this.mtxtMNo.Name = "mtxtMNo";
            this.mtxtMNo.Size = new System.Drawing.Size(109, 20);
            this.mtxtMNo.TabIndex = 6;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Lucida Fax", 8.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(6, 25);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(107, 14);
            this.label6.TabIndex = 2;
            this.label6.Text = "Member Number ";
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExit.ForeColor = System.Drawing.Color.Blue;
            this.btnExit.Location = new System.Drawing.Point(403, -1);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(91, 41);
            this.btnExit.TabIndex = 12;
            this.btnExit.Text = "E&XIT";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // cboComPorts
            // 
            this.cboComPorts.FormattingEnabled = true;
            this.cboComPorts.Location = new System.Drawing.Point(71, 6);
            this.cboComPorts.Name = "cboComPorts";
            this.cboComPorts.Size = new System.Drawing.Size(201, 21);
            this.cboComPorts.TabIndex = 13;
            this.cboComPorts.SelectedIndexChanged += new System.EventHandler(this.cboComPorts_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(58, 13);
            this.label4.TabIndex = 14;
            this.label4.Text = "COM Ports";
            // 
            // frmLoanProcessing
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(512, 402);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboComPorts);
            this.Controls.Add(this.btnExit);
            this.Controls.Add(this.groupBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "frmLoanProcessing";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Loan Processing ";
            this.Load += new System.EventHandler(this.frmLoanProcessing_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.DateTimePicker dtpDte;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.MaskedTextBox mtxtMNo;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnApprov;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnSve;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cboComPorts;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.ComboBox cboDisburse;
        private System.Windows.Forms.ComboBox cboLoan;
        private System.Windows.Forms.ComboBox cboLoanStat;
        private System.Windows.Forms.TextBox txtReffcode;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnDletee;
    }
}