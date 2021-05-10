namespace MasterCardTool
{
    partial class frmCheckFilterOverDraftsAccount
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
            this.openFileDialogRequestFile = new System.Windows.Forms.OpenFileDialog();
            this.btnFileRequestFromCW = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.txtRequestFile = new System.Windows.Forms.TextBox();
            this.grdRequestValidAccount = new System.Windows.Forms.DataGridView();
            this.txtResponseFileFailAccount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnFileResponseFailAccount = new System.Windows.Forms.Button();
            this.txtResponseFileFromLP = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnFileResponseFromLP = new System.Windows.Forms.Button();
            this.btnProcessRequestFile = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnProcessResponseFile = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.openFileDialogResponseFailAccount = new System.Windows.Forms.OpenFileDialog();
            this.openFileDialogResponseFile = new System.Windows.Forms.OpenFileDialog();
            this.Number = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Account = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.HolderName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.grdRequestInvalidAccount = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.grdResponseFile = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.datetime = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequestValidAccount)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequestInvalidAccount)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdResponseFile)).BeginInit();
            this.SuspendLayout();
            // 
            // openFileDialogRequestFile
            // 
            this.openFileDialogRequestFile.FileName = "openFileDialog1";
            // 
            // btnFileRequestFromCW
            // 
            this.btnFileRequestFromCW.Location = new System.Drawing.Point(850, 17);
            this.btnFileRequestFromCW.Name = "btnFileRequestFromCW";
            this.btnFileRequestFromCW.Size = new System.Drawing.Size(75, 23);
            this.btnFileRequestFromCW.TabIndex = 0;
            this.btnFileRequestFromCW.Text = "Browser ...";
            this.btnFileRequestFromCW.UseVisualStyleBackColor = true;
            this.btnFileRequestFromCW.Click += new System.EventHandler(this.btnBrowser_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(149, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Request File (From CardWork)";
            // 
            // txtRequestFile
            // 
            this.txtRequestFile.Location = new System.Drawing.Point(206, 19);
            this.txtRequestFile.Name = "txtRequestFile";
            this.txtRequestFile.ReadOnly = true;
            this.txtRequestFile.Size = new System.Drawing.Size(634, 20);
            this.txtRequestFile.TabIndex = 2;
            // 
            // grdRequestValidAccount
            // 
            this.grdRequestValidAccount.AllowUserToAddRows = false;
            this.grdRequestValidAccount.AllowUserToDeleteRows = false;
            this.grdRequestValidAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequestValidAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.Number,
            this.Account,
            this.HolderName,
            this.Amount});
            this.grdRequestValidAccount.Location = new System.Drawing.Point(9, 19);
            this.grdRequestValidAccount.Name = "grdRequestValidAccount";
            this.grdRequestValidAccount.ReadOnly = true;
            this.grdRequestValidAccount.Size = new System.Drawing.Size(493, 243);
            this.grdRequestValidAccount.TabIndex = 3;
            // 
            // txtResponseFileFailAccount
            // 
            this.txtResponseFileFailAccount.Location = new System.Drawing.Point(206, 19);
            this.txtResponseFileFailAccount.Name = "txtResponseFileFailAccount";
            this.txtResponseFileFailAccount.ReadOnly = true;
            this.txtResponseFileFailAccount.Size = new System.Drawing.Size(634, 20);
            this.txtResponseFileFailAccount.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(196, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Response File (Fail OverDrafts Account)";
            // 
            // btnFileResponseFailAccount
            // 
            this.btnFileResponseFailAccount.Location = new System.Drawing.Point(850, 17);
            this.btnFileResponseFailAccount.Name = "btnFileResponseFailAccount";
            this.btnFileResponseFailAccount.Size = new System.Drawing.Size(75, 23);
            this.btnFileResponseFailAccount.TabIndex = 4;
            this.btnFileResponseFailAccount.Text = "Browser ...";
            this.btnFileResponseFailAccount.UseVisualStyleBackColor = true;
            this.btnFileResponseFailAccount.Click += new System.EventHandler(this.btnFileResponseFailAccount_Click);
            // 
            // txtResponseFileFromLP
            // 
            this.txtResponseFileFromLP.Location = new System.Drawing.Point(206, 48);
            this.txtResponseFileFromLP.Name = "txtResponseFileFromLP";
            this.txtResponseFileFromLP.ReadOnly = true;
            this.txtResponseFileFromLP.Size = new System.Drawing.Size(634, 20);
            this.txtResponseFileFromLP.TabIndex = 9;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(179, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Response File (From Local Payment)";
            // 
            // btnFileResponseFromLP
            // 
            this.btnFileResponseFromLP.Location = new System.Drawing.Point(850, 46);
            this.btnFileResponseFromLP.Name = "btnFileResponseFromLP";
            this.btnFileResponseFromLP.Size = new System.Drawing.Size(75, 23);
            this.btnFileResponseFromLP.TabIndex = 7;
            this.btnFileResponseFromLP.Text = "Browser ...";
            this.btnFileResponseFromLP.UseVisualStyleBackColor = true;
            this.btnFileResponseFromLP.Click += new System.EventHandler(this.btnFileResponseFromLP_Click);
            // 
            // btnProcessRequestFile
            // 
            this.btnProcessRequestFile.Location = new System.Drawing.Point(942, 17);
            this.btnProcessRequestFile.Name = "btnProcessRequestFile";
            this.btnProcessRequestFile.Size = new System.Drawing.Size(75, 23);
            this.btnProcessRequestFile.TabIndex = 10;
            this.btnProcessRequestFile.Text = "Process";
            this.btnProcessRequestFile.UseVisualStyleBackColor = true;
            this.btnProcessRequestFile.Click += new System.EventHandler(this.btnProcessRequestFile_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnProcessResponseFile);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.btnFileResponseFailAccount);
            this.groupBox1.Controls.Add(this.txtResponseFileFromLP);
            this.groupBox1.Controls.Add(this.txtResponseFileFailAccount);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.btnFileResponseFromLP);
            this.groupBox1.Location = new System.Drawing.Point(12, 64);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(1027, 80);
            this.groupBox1.TabIndex = 11;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Instruction Response File";
            // 
            // btnProcessResponseFile
            // 
            this.btnProcessResponseFile.Location = new System.Drawing.Point(942, 32);
            this.btnProcessResponseFile.Name = "btnProcessResponseFile";
            this.btnProcessResponseFile.Size = new System.Drawing.Size(75, 23);
            this.btnProcessResponseFile.TabIndex = 11;
            this.btnProcessResponseFile.Text = "Process";
            this.btnProcessResponseFile.UseVisualStyleBackColor = true;
            this.btnProcessResponseFile.Click += new System.EventHandler(this.btnProcessResponseFile_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.btnFileRequestFromCW);
            this.groupBox2.Controls.Add(this.btnProcessRequestFile);
            this.groupBox2.Controls.Add(this.txtRequestFile);
            this.groupBox2.Location = new System.Drawing.Point(12, 2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1027, 52);
            this.groupBox2.TabIndex = 12;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Instruction Request File";
            // 
            // openFileDialogResponseFailAccount
            // 
            this.openFileDialogResponseFailAccount.FileName = "openFileDialog1";
            // 
            // openFileDialogResponseFile
            // 
            this.openFileDialogResponseFile.FileName = "openFileDialog2";
            // 
            // Number
            // 
            this.Number.HeaderText = "No";
            this.Number.Name = "Number";
            this.Number.ReadOnly = true;
            this.Number.Width = 40;
            // 
            // Account
            // 
            this.Account.HeaderText = "Account";
            this.Account.Name = "Account";
            this.Account.ReadOnly = true;
            this.Account.Width = 110;
            // 
            // HolderName
            // 
            this.HolderName.HeaderText = "Holder Name";
            this.HolderName.Name = "HolderName";
            this.HolderName.ReadOnly = true;
            this.HolderName.Width = 170;
            // 
            // Amount
            // 
            this.Amount.HeaderText = "Payment Amount";
            this.Amount.Name = "Amount";
            this.Amount.ReadOnly = true;
            this.Amount.Width = 110;
            // 
            // grdRequestInvalidAccount
            // 
            this.grdRequestInvalidAccount.AllowUserToAddRows = false;
            this.grdRequestInvalidAccount.AllowUserToDeleteRows = false;
            this.grdRequestInvalidAccount.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdRequestInvalidAccount.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4});
            this.grdRequestInvalidAccount.Location = new System.Drawing.Point(9, 19);
            this.grdRequestInvalidAccount.Name = "grdRequestInvalidAccount";
            this.grdRequestInvalidAccount.ReadOnly = true;
            this.grdRequestInvalidAccount.Size = new System.Drawing.Size(493, 243);
            this.grdRequestInvalidAccount.TabIndex = 13;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "Account";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 110;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "Holder Name";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 170;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Payment Amount";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 110;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdRequestValidAccount);
            this.groupBox3.Location = new System.Drawing.Point(12, 146);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(510, 268);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Request Valid Account";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdRequestInvalidAccount);
            this.groupBox4.Location = new System.Drawing.Point(528, 146);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(511, 268);
            this.groupBox4.TabIndex = 15;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Request Not Valid Account";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.grdResponseFile);
            this.groupBox5.Location = new System.Drawing.Point(12, 416);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(510, 268);
            this.groupBox5.TabIndex = 15;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Request Valid Account";
            // 
            // grdResponseFile
            // 
            this.grdResponseFile.AllowUserToAddRows = false;
            this.grdResponseFile.AllowUserToDeleteRows = false;
            this.grdResponseFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdResponseFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn8,
            this.datetime,
            this.status});
            this.grdResponseFile.Location = new System.Drawing.Point(6, 19);
            this.grdResponseFile.Name = "grdResponseFile";
            this.grdResponseFile.ReadOnly = true;
            this.grdResponseFile.Size = new System.Drawing.Size(496, 243);
            this.grdResponseFile.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "No";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 40;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.HeaderText = "Account";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.HeaderText = "Payment Amount";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            this.dataGridViewTextBoxColumn8.Width = 110;
            // 
            // datetime
            // 
            this.datetime.HeaderText = "DateTime";
            this.datetime.Name = "datetime";
            this.datetime.ReadOnly = true;
            this.datetime.Width = 120;
            // 
            // status
            // 
            this.status.HeaderText = "Status";
            this.status.Name = "status";
            this.status.ReadOnly = true;
            this.status.Width = 50;
            // 
            // frmCheckFilterOverDraftsAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1050, 693);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Name = "frmCheckFilterOverDraftsAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Check & Filter Overdrafts Account";
            ((System.ComponentModel.ISupportInitialize)(this.grdRequestValidAccount)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdRequestInvalidAccount)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdResponseFile)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openFileDialogRequestFile;
        private System.Windows.Forms.Button btnFileRequestFromCW;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtRequestFile;
        private System.Windows.Forms.DataGridView grdRequestValidAccount;
        private System.Windows.Forms.TextBox txtResponseFileFailAccount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnFileResponseFailAccount;
        private System.Windows.Forms.TextBox txtResponseFileFromLP;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnFileResponseFromLP;
        private System.Windows.Forms.Button btnProcessRequestFile;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnProcessResponseFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.OpenFileDialog openFileDialogResponseFailAccount;
        private System.Windows.Forms.OpenFileDialog openFileDialogResponseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn Number;
        private System.Windows.Forms.DataGridViewTextBoxColumn Account;
        private System.Windows.Forms.DataGridViewTextBoxColumn HolderName;
        private System.Windows.Forms.DataGridViewTextBoxColumn Amount;
        private System.Windows.Forms.DataGridView grdRequestInvalidAccount;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.DataGridView grdResponseFile;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn datetime;
        private System.Windows.Forms.DataGridViewTextBoxColumn status;
    }
}