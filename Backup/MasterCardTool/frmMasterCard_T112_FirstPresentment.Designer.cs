namespace MasterCardTool
{
    partial class frmMasterCard_T112_FirstPresentment
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.label1 = new System.Windows.Forms.Label();
            this.txtFilePathT112 = new System.Windows.Forms.TextBox();
            this.openFileDialogT112 = new System.Windows.Forms.OpenFileDialog();
            this.btnBrowserT112 = new System.Windows.Forms.Button();
            this.grdT112 = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdoReadOnly = new System.Windows.Forms.RadioButton();
            this.rdoReplaceAndRead = new System.Windows.Forms.RadioButton();
            this.grpFilter = new System.Windows.Forms.GroupBox();
            this.rdoAllMessages = new System.Windows.Forms.RadioButton();
            this.rdoTransactionOnly = new System.Windows.Forms.RadioButton();
            this.grdTransactionsOfCard = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.btnGetTransaction = new System.Windows.Forms.Button();
            this.txtPAN = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.grdUnknownTrans = new System.Windows.Forms.DataGridView();
            this.btnFindUnknownCard = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdT112)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionsOfCard)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdUnknownTrans)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(567, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "File Path";
            // 
            // txtFilePathT112
            // 
            this.txtFilePathT112.Location = new System.Drawing.Point(621, 17);
            this.txtFilePathT112.Name = "txtFilePathT112";
            this.txtFilePathT112.Size = new System.Drawing.Size(514, 20);
            this.txtFilePathT112.TabIndex = 1;
            this.txtFilePathT112.TextChanged += new System.EventHandler(this.txtFilePathT112_TextChanged);
            // 
            // openFileDialogT112
            // 
            this.openFileDialogT112.FileName = "openFileDialogT112";
            this.openFileDialogT112.Multiselect = true;
            // 
            // btnBrowserT112
            // 
            this.btnBrowserT112.Location = new System.Drawing.Point(1141, 15);
            this.btnBrowserT112.Name = "btnBrowserT112";
            this.btnBrowserT112.Size = new System.Drawing.Size(75, 23);
            this.btnBrowserT112.TabIndex = 2;
            this.btnBrowserT112.Text = "Browser...";
            this.btnBrowserT112.UseVisualStyleBackColor = true;
            this.btnBrowserT112.Click += new System.EventHandler(this.btnBrowserT112_Click);
            // 
            // grdT112
            // 
            this.grdT112.AllowUserToAddRows = false;
            this.grdT112.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT112.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdT112.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdT112.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdT112.Location = new System.Drawing.Point(6, 16);
            this.grdT112.Name = "grdT112";
            this.grdT112.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT112.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdT112.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdT112.Size = new System.Drawing.Size(1250, 385);
            this.grdT112.TabIndex = 3;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdoReadOnly);
            this.groupBox1.Controls.Add(this.rdoReplaceAndRead);
            this.groupBox1.Location = new System.Drawing.Point(11, 2);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(297, 40);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Reading Optional";
            // 
            // rdoReadOnly
            // 
            this.rdoReadOnly.AutoSize = true;
            this.rdoReadOnly.Location = new System.Drawing.Point(161, 15);
            this.rdoReadOnly.Name = "rdoReadOnly";
            this.rdoReadOnly.Size = new System.Drawing.Size(124, 17);
            this.rdoReadOnly.TabIndex = 1;
            this.rdoReadOnly.Text = "Read Only(.Replace)";
            this.rdoReadOnly.UseVisualStyleBackColor = true;
            // 
            // rdoReplaceAndRead
            // 
            this.rdoReplaceAndRead.AutoSize = true;
            this.rdoReplaceAndRead.Checked = true;
            this.rdoReplaceAndRead.Location = new System.Drawing.Point(15, 15);
            this.rdoReplaceAndRead.Name = "rdoReplaceAndRead";
            this.rdoReplaceAndRead.Size = new System.Drawing.Size(130, 17);
            this.rdoReplaceAndRead.TabIndex = 0;
            this.rdoReplaceAndRead.TabStop = true;
            this.rdoReplaceAndRead.Text = "Replace && Read(.001)";
            this.rdoReplaceAndRead.UseVisualStyleBackColor = true;
            // 
            // grpFilter
            // 
            this.grpFilter.Controls.Add(this.rdoAllMessages);
            this.grpFilter.Controls.Add(this.rdoTransactionOnly);
            this.grpFilter.Location = new System.Drawing.Point(321, 2);
            this.grpFilter.Name = "grpFilter";
            this.grpFilter.Size = new System.Drawing.Size(233, 40);
            this.grpFilter.TabIndex = 5;
            this.grpFilter.TabStop = false;
            this.grpFilter.Text = "Messages Optional";
            // 
            // rdoAllMessages
            // 
            this.rdoAllMessages.AutoSize = true;
            this.rdoAllMessages.Location = new System.Drawing.Point(137, 15);
            this.rdoAllMessages.Name = "rdoAllMessages";
            this.rdoAllMessages.Size = new System.Drawing.Size(87, 17);
            this.rdoAllMessages.TabIndex = 3;
            this.rdoAllMessages.Text = "All Messages";
            this.rdoAllMessages.UseVisualStyleBackColor = true;
            // 
            // rdoTransactionOnly
            // 
            this.rdoTransactionOnly.AutoSize = true;
            this.rdoTransactionOnly.Checked = true;
            this.rdoTransactionOnly.Location = new System.Drawing.Point(16, 15);
            this.rdoTransactionOnly.Name = "rdoTransactionOnly";
            this.rdoTransactionOnly.Size = new System.Drawing.Size(110, 17);
            this.rdoTransactionOnly.TabIndex = 2;
            this.rdoTransactionOnly.TabStop = true;
            this.rdoTransactionOnly.Text = "Transactions Only";
            this.rdoTransactionOnly.UseVisualStyleBackColor = true;
            // 
            // grdTransactionsOfCard
            // 
            this.grdTransactionsOfCard.AllowUserToAddRows = false;
            this.grdTransactionsOfCard.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionsOfCard.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdTransactionsOfCard.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdTransactionsOfCard.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdTransactionsOfCard.Location = new System.Drawing.Point(6, 16);
            this.grdTransactionsOfCard.Name = "grdTransactionsOfCard";
            this.grdTransactionsOfCard.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdTransactionsOfCard.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdTransactionsOfCard.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToFirstHeader;
            this.grdTransactionsOfCard.Size = new System.Drawing.Size(1251, 187);
            this.grdTransactionsOfCard.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(8, 459);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(29, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "PAN";
            // 
            // btnGetTransaction
            // 
            this.btnGetTransaction.Location = new System.Drawing.Point(182, 455);
            this.btnGetTransaction.Name = "btnGetTransaction";
            this.btnGetTransaction.Size = new System.Drawing.Size(114, 23);
            this.btnGetTransaction.TabIndex = 8;
            this.btnGetTransaction.Text = "Get Transactions";
            this.btnGetTransaction.UseVisualStyleBackColor = true;
            this.btnGetTransaction.Click += new System.EventHandler(this.btnGetTransaction_Click);
            // 
            // txtPAN
            // 
            this.txtPAN.Location = new System.Drawing.Point(43, 456);
            this.txtPAN.Name = "txtPAN";
            this.txtPAN.Size = new System.Drawing.Size(133, 20);
            this.txtPAN.TabIndex = 9;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.grdT112);
            this.groupBox2.Location = new System.Drawing.Point(4, 44);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1263, 407);
            this.groupBox2.TabIndex = 10;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Incoming Transsactions";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.grdTransactionsOfCard);
            this.groupBox3.Location = new System.Drawing.Point(4, 478);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(1263, 209);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Transactions Of One Card";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.grdUnknownTrans);
            this.groupBox4.Location = new System.Drawing.Point(4, 715);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(1263, 187);
            this.groupBox4.TabIndex = 67;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Unknown Transactions";
            // 
            // grdUnknownTrans
            // 
            this.grdUnknownTrans.AllowUserToAddRows = false;
            this.grdUnknownTrans.AllowUserToDeleteRows = false;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnknownTrans.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.grdUnknownTrans.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdUnknownTrans.DefaultCellStyle = dataGridViewCellStyle8;
            this.grdUnknownTrans.Location = new System.Drawing.Point(7, 15);
            this.grdUnknownTrans.Name = "grdUnknownTrans";
            this.grdUnknownTrans.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdUnknownTrans.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            this.grdUnknownTrans.Size = new System.Drawing.Size(1250, 166);
            this.grdUnknownTrans.TabIndex = 57;
            // 
            // btnFindUnknownCard
            // 
            this.btnFindUnknownCard.Location = new System.Drawing.Point(10, 691);
            this.btnFindUnknownCard.Name = "btnFindUnknownCard";
            this.btnFindUnknownCard.Size = new System.Drawing.Size(166, 23);
            this.btnFindUnknownCard.TabIndex = 66;
            this.btnFindUnknownCard.Text = "Find UnknownTransactions";
            this.btnFindUnknownCard.UseVisualStyleBackColor = true;
            this.btnFindUnknownCard.Click += new System.EventHandler(this.btnFindUnknownCard_Click);
            // 
            // frmMasterCard_T112_FirstPresentment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1272, 907);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnFindUnknownCard);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.txtPAN);
            this.Controls.Add(this.btnGetTransaction);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.grpFilter);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnBrowserT112);
            this.Controls.Add(this.txtFilePathT112);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMasterCard_T112_FirstPresentment";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T112 Incoming File";
            ((System.ComponentModel.ISupportInitialize)(this.grdT112)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFilter.ResumeLayout(false);
            this.grpFilter.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdTransactionsOfCard)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.grdUnknownTrans)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtFilePathT112;
        private System.Windows.Forms.OpenFileDialog openFileDialogT112;
        private System.Windows.Forms.Button btnBrowserT112;
        private System.Windows.Forms.DataGridView grdT112;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdoReadOnly;
        private System.Windows.Forms.RadioButton rdoReplaceAndRead;
        private System.Windows.Forms.GroupBox grpFilter;
        private System.Windows.Forms.RadioButton rdoAllMessages;
        private System.Windows.Forms.RadioButton rdoTransactionOnly;
        private System.Windows.Forms.DataGridView grdTransactionsOfCard;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnGetTransaction;
        private System.Windows.Forms.TextBox txtPAN;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView grdUnknownTrans;
        private System.Windows.Forms.Button btnFindUnknownCard;
    }
}