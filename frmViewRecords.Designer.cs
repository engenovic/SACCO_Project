namespace INUA_JAMII_SACCO
{
    partial class frmViewRecords
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
            this.dgtmembers = new System.Windows.Forms.DataGridView();
            this.btnDispl = new System.Windows.Forms.Button();
            this.btnPrint = new System.Windows.Forms.Button();
            this.btnExtie = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.gBoxFilter = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgtmembers)).BeginInit();
            this.gBoxFilter.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgtmembers
            // 
            this.dgtmembers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgtmembers.Location = new System.Drawing.Point(-2, 108);
            this.dgtmembers.Name = "dgtmembers";
            this.dgtmembers.Size = new System.Drawing.Size(736, 337);
            this.dgtmembers.TabIndex = 0;
            // 
            // btnDispl
            // 
            this.btnDispl.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDispl.Location = new System.Drawing.Point(11, 32);
            this.btnDispl.Name = "btnDispl";
            this.btnDispl.Size = new System.Drawing.Size(162, 23);
            this.btnDispl.TabIndex = 1;
            this.btnDispl.Text = "&DISPLAY ALL RECORDS";
            this.btnDispl.UseVisualStyleBackColor = true;
            this.btnDispl.Click += new System.EventHandler(this.btnDispl_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPrint.Location = new System.Drawing.Point(14, 71);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(159, 23);
            this.btnPrint.TabIndex = 3;
            this.btnPrint.Text = "&PRINT RECORDS";
            this.btnPrint.UseVisualStyleBackColor = true;
            this.btnPrint.Click += new System.EventHandler(this.btnPrint_Click);
            // 
            // btnExtie
            // 
            this.btnExtie.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnExtie.ForeColor = System.Drawing.Color.Blue;
            this.btnExtie.Location = new System.Drawing.Point(648, 0);
            this.btnExtie.Name = "btnExtie";
            this.btnExtie.Size = new System.Drawing.Size(75, 33);
            this.btnExtie.TabIndex = 4;
            this.btnExtie.Text = "EXIT";
            this.btnExtie.UseVisualStyleBackColor = true;
            this.btnExtie.Click += new System.EventHandler(this.btnExtie_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // gBoxFilter
            // 
            this.gBoxFilter.Controls.Add(this.btnPrint);
            this.gBoxFilter.Controls.Add(this.btnDispl);
            this.gBoxFilter.ForeColor = System.Drawing.Color.Red;
            this.gBoxFilter.Location = new System.Drawing.Point(-2, 2);
            this.gBoxFilter.Name = "gBoxFilter";
            this.gBoxFilter.Size = new System.Drawing.Size(197, 100);
            this.gBoxFilter.TabIndex = 5;
            this.gBoxFilter.TabStop = false;
            this.gBoxFilter.Text = "Display Records";
            // 
            // frmViewRecords
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(735, 444);
            this.Controls.Add(this.gBoxFilter);
            this.Controls.Add(this.btnExtie);
            this.Controls.Add(this.dgtmembers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "frmViewRecords";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Member Reports";
           // this.Load += new System.EventHandler(this.frmViewRecords_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgtmembers)).EndInit();
            this.gBoxFilter.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgtmembers;
        private System.Windows.Forms.Button btnDispl;
        private System.Windows.Forms.Button btnPrint;
        private System.Windows.Forms.Button btnExtie;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.GroupBox gBoxFilter;
    }
}