namespace MasterCardTool
{
    partial class frmMasterCard_T140_ReconReport
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            this.openDlgChonFileT140 = new System.Windows.Forms.OpenFileDialog();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.grdT140ReconReport = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colWriteDB = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRunDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colClearingDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCycle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colUSDAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colVNDAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblNumOfFile = new System.Windows.Forms.Label();
            this.txtNumOfFile = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtUSDTotal1 = new System.Windows.Forms.TextBox();
            this.checkOverrideNewFileName = new System.Windows.Forms.CheckBox();
            this.btnGhiThongTinXuongDB = new System.Windows.Forms.Button();
            this.datepickFromDate = new System.Windows.Forms.DateTimePicker();
            this.FromDate = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.datepickToDate = new System.Windows.Forms.DateTimePicker();
            this.grdT140KetQuaTimKiem = new System.Windows.Forms.DataGridView();
            this.btnSearchData = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSoLuongRow = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFilePath = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.ckbEditFilePath = new System.Windows.Forms.CheckBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtVNDTotal1 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtUSDTotal2 = new System.Windows.Forms.TextBox();
            this.txtVNDTotal2 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.grdT140ReconReport)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdT140KetQuaTimKiem)).BeginInit();
            this.SuspendLayout();
            // 
            // openDlgChonFileT140
            // 
            this.openDlgChonFileT140.FileName = "openDlgChonFileT140";
            this.openDlgChonFileT140.Multiselect = true;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(381, 3);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(61, 23);
            this.btnChonFile.TabIndex = 50;
            this.btnChonFile.Text = "Browse...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(259, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 13);
            this.label2.TabIndex = 48;
            this.label2.Text = "Input Files (one or more)";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Blue;
            this.label1.Location = new System.Drawing.Point(12, 7);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(105, 14);
            this.label1.TabIndex = 47;
            this.label1.Text = "Read && Write T140";
            // 
            // grdT140ReconReport
            // 
            this.grdT140ReconReport.AllowUserToAddRows = false;
            this.grdT140ReconReport.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT140ReconReport.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdT140ReconReport.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdT140ReconReport.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colFileName,
            this.colWriteDB,
            this.colNewFileName,
            this.colRunDate,
            this.colClearingDate,
            this.colCycle,
            this.colUSDAmount,
            this.colVNDAmount});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdT140ReconReport.DefaultCellStyle = dataGridViewCellStyle3;
            this.grdT140ReconReport.Location = new System.Drawing.Point(10, 29);
            this.grdT140ReconReport.Name = "grdT140ReconReport";
            this.grdT140ReconReport.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT140ReconReport.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdT140ReconReport.Size = new System.Drawing.Size(994, 299);
            this.grdT140ReconReport.TabIndex = 51;
            this.grdT140ReconReport.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdT140ReconReport_CellMouseDoubleClick);
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 40;
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            this.colFileName.Width = 340;
            // 
            // colWriteDB
            // 
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Blue;
            this.colWriteDB.DefaultCellStyle = dataGridViewCellStyle2;
            this.colWriteDB.HeaderText = "WriteDB";
            this.colWriteDB.Name = "colWriteDB";
            this.colWriteDB.ReadOnly = true;
            this.colWriteDB.Width = 50;
            // 
            // colNewFileName
            // 
            this.colNewFileName.HeaderText = "NewFileName";
            this.colNewFileName.Name = "colNewFileName";
            this.colNewFileName.ReadOnly = true;
            this.colNewFileName.Width = 140;
            // 
            // colRunDate
            // 
            this.colRunDate.HeaderText = "RunDate";
            this.colRunDate.Name = "colRunDate";
            this.colRunDate.ReadOnly = true;
            this.colRunDate.Width = 70;
            // 
            // colClearingDate
            // 
            this.colClearingDate.HeaderText = "ClearingDate";
            this.colClearingDate.Name = "colClearingDate";
            this.colClearingDate.ReadOnly = true;
            this.colClearingDate.Width = 80;
            // 
            // colCycle
            // 
            this.colCycle.HeaderText = "Cycle";
            this.colCycle.Name = "colCycle";
            this.colCycle.ReadOnly = true;
            this.colCycle.Width = 40;
            // 
            // colUSDAmount
            // 
            this.colUSDAmount.HeaderText = "USDAmount";
            this.colUSDAmount.Name = "colUSDAmount";
            this.colUSDAmount.ReadOnly = true;
            this.colUSDAmount.Width = 80;
            // 
            // colVNDAmount
            // 
            this.colVNDAmount.HeaderText = "VNDAmount";
            this.colVNDAmount.Name = "colVNDAmount";
            this.colVNDAmount.ReadOnly = true;
            // 
            // lblNumOfFile
            // 
            this.lblNumOfFile.AutoSize = true;
            this.lblNumOfFile.Location = new System.Drawing.Point(625, 8);
            this.lblNumOfFile.Name = "lblNumOfFile";
            this.lblNumOfFile.Size = new System.Drawing.Size(58, 13);
            this.lblNumOfFile.TabIndex = 52;
            this.lblNumOfFile.Text = "Total items";
            // 
            // txtNumOfFile
            // 
            this.txtNumOfFile.Enabled = false;
            this.txtNumOfFile.Location = new System.Drawing.Point(687, 5);
            this.txtNumOfFile.Name = "txtNumOfFile";
            this.txtNumOfFile.Size = new System.Drawing.Size(45, 20);
            this.txtNumOfFile.TabIndex = 53;
            this.txtNumOfFile.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(737, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 13);
            this.label3.TabIndex = 54;
            this.label3.Text = "Total(USD)";
            // 
            // txtUSDTotal1
            // 
            this.txtUSDTotal1.ForeColor = System.Drawing.Color.Black;
            this.txtUSDTotal1.Location = new System.Drawing.Point(800, 5);
            this.txtUSDTotal1.Name = "txtUSDTotal1";
            this.txtUSDTotal1.ReadOnly = true;
            this.txtUSDTotal1.Size = new System.Drawing.Size(70, 20);
            this.txtUSDTotal1.TabIndex = 55;
            this.txtUSDTotal1.Text = "0";
            // 
            // checkOverrideNewFileName
            // 
            this.checkOverrideNewFileName.AutoSize = true;
            this.checkOverrideNewFileName.Location = new System.Drawing.Point(119, 7);
            this.checkOverrideNewFileName.Name = "checkOverrideNewFileName";
            this.checkOverrideNewFileName.Size = new System.Drawing.Size(140, 17);
            this.checkOverrideNewFileName.TabIndex = 57;
            this.checkOverrideNewFileName.Text = "Overwrite NewFileName";
            this.checkOverrideNewFileName.UseVisualStyleBackColor = true;
            this.checkOverrideNewFileName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkOverrideNewFileName_MouseClick);
            // 
            // btnGhiThongTinXuongDB
            // 
            this.btnGhiThongTinXuongDB.Location = new System.Drawing.Point(448, 3);
            this.btnGhiThongTinXuongDB.Name = "btnGhiThongTinXuongDB";
            this.btnGhiThongTinXuongDB.Size = new System.Drawing.Size(103, 23);
            this.btnGhiThongTinXuongDB.TabIndex = 58;
            this.btnGhiThongTinXuongDB.Text = "Write to DataBase";
            this.btnGhiThongTinXuongDB.UseVisualStyleBackColor = true;
            this.btnGhiThongTinXuongDB.Click += new System.EventHandler(this.btnGhiThongTinXuongDB_Click);
            // 
            // datepickFromDate
            // 
            this.datepickFromDate.CustomFormat = "dd/MM/yyyy";
            this.datepickFromDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickFromDate.Location = new System.Drawing.Point(207, 331);
            this.datepickFromDate.Name = "datepickFromDate";
            this.datepickFromDate.Size = new System.Drawing.Size(90, 20);
            this.datepickFromDate.TabIndex = 59;
            // 
            // FromDate
            // 
            this.FromDate.AutoSize = true;
            this.FromDate.Location = new System.Drawing.Point(107, 335);
            this.FromDate.Name = "FromDate";
            this.FromDate.Size = new System.Drawing.Size(97, 13);
            this.FromDate.TabIndex = 60;
            this.FromDate.Text = "From Clearing Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(297, 336);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 13);
            this.label6.TabIndex = 62;
            this.label6.Text = "To Clearing Date";
            // 
            // datepickToDate
            // 
            this.datepickToDate.CustomFormat = "dd/MM/yyyy";
            this.datepickToDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickToDate.Location = new System.Drawing.Point(387, 332);
            this.datepickToDate.Name = "datepickToDate";
            this.datepickToDate.Size = new System.Drawing.Size(90, 20);
            this.datepickToDate.TabIndex = 61;
            // 
            // grdT140KetQuaTimKiem
            // 
            this.grdT140KetQuaTimKiem.AllowUserToAddRows = false;
            this.grdT140KetQuaTimKiem.AllowUserToDeleteRows = false;
            this.grdT140KetQuaTimKiem.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdT140KetQuaTimKiem.Location = new System.Drawing.Point(10, 377);
            this.grdT140KetQuaTimKiem.Name = "grdT140KetQuaTimKiem";
            this.grdT140KetQuaTimKiem.ReadOnly = true;
            this.grdT140KetQuaTimKiem.Size = new System.Drawing.Size(994, 285);
            this.grdT140KetQuaTimKiem.TabIndex = 63;
            this.grdT140KetQuaTimKiem.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.grdT140KetQuaTimKiem_CellMouseDoubleClick);
            // 
            // btnSearchData
            // 
            this.btnSearchData.Location = new System.Drawing.Point(483, 330);
            this.btnSearchData.Name = "btnSearchData";
            this.btnSearchData.Size = new System.Drawing.Size(68, 23);
            this.btnSearchData.TabIndex = 64;
            this.btnSearchData.Text = "Search";
            this.btnSearchData.UseVisualStyleBackColor = true;
            this.btnSearchData.Click += new System.EventHandler(this.btnSearchData_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(738, 334);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 65;
            this.label7.Text = "Total(USD)";
            // 
            // txtSoLuongRow
            // 
            this.txtSoLuongRow.Enabled = false;
            this.txtSoLuongRow.Location = new System.Drawing.Point(687, 331);
            this.txtSoLuongRow.Name = "txtSoLuongRow";
            this.txtSoLuongRow.Size = new System.Drawing.Size(45, 20);
            this.txtSoLuongRow.TabIndex = 69;
            this.txtSoLuongRow.Text = "0";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(625, 334);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 68;
            this.label8.Text = "Total items";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Arial", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Blue;
            this.label9.Location = new System.Drawing.Point(12, 334);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 14);
            this.label9.TabIndex = 70;
            this.label9.Text = "Search from DB";
            // 
            // txtFilePath
            // 
            this.txtFilePath.Location = new System.Drawing.Point(207, 354);
            this.txtFilePath.Name = "txtFilePath";
            this.txtFilePath.ReadOnly = true;
            this.txtFilePath.Size = new System.Drawing.Size(530, 20);
            this.txtFilePath.TabIndex = 71;
            this.txtFilePath.Text = "C:\\MCONLINE\\MFE\\DOWNLOAD\\T140";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(52, 357);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(152, 13);
            this.label10.TabIndex = 72;
            this.label10.Text = "File Path (not contain filename)";
            // 
            // ckbEditFilePath
            // 
            this.ckbEditFilePath.AutoSize = true;
            this.ckbEditFilePath.Location = new System.Drawing.Point(746, 357);
            this.ckbEditFilePath.Name = "ckbEditFilePath";
            this.ckbEditFilePath.Size = new System.Drawing.Size(88, 17);
            this.ckbEditFilePath.TabIndex = 73;
            this.ckbEditFilePath.Text = "Edit File Path";
            this.ckbEditFilePath.UseVisualStyleBackColor = true;
            this.ckbEditFilePath.Click += new System.EventHandler(this.ckbEditFilePath_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(871, 335);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 74;
            this.label5.Text = "Total(VND)";
            // 
            // txtVNDTotal1
            // 
            this.txtVNDTotal1.ForeColor = System.Drawing.Color.Black;
            this.txtVNDTotal1.Location = new System.Drawing.Point(934, 5);
            this.txtVNDTotal1.Name = "txtVNDTotal1";
            this.txtVNDTotal1.ReadOnly = true;
            this.txtVNDTotal1.Size = new System.Drawing.Size(70, 20);
            this.txtVNDTotal1.TabIndex = 77;
            this.txtVNDTotal1.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(871, 9);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "Total(VND)";
            // 
            // txtUSDTotal2
            // 
            this.txtUSDTotal2.ForeColor = System.Drawing.Color.Black;
            this.txtUSDTotal2.Location = new System.Drawing.Point(800, 331);
            this.txtUSDTotal2.Name = "txtUSDTotal2";
            this.txtUSDTotal2.ReadOnly = true;
            this.txtUSDTotal2.Size = new System.Drawing.Size(70, 20);
            this.txtUSDTotal2.TabIndex = 78;
            this.txtUSDTotal2.Text = "0";
            // 
            // txtVNDTotal2
            // 
            this.txtVNDTotal2.ForeColor = System.Drawing.Color.Black;
            this.txtVNDTotal2.Location = new System.Drawing.Point(934, 331);
            this.txtVNDTotal2.Name = "txtVNDTotal2";
            this.txtVNDTotal2.ReadOnly = true;
            this.txtVNDTotal2.Size = new System.Drawing.Size(70, 20);
            this.txtVNDTotal2.TabIndex = 79;
            this.txtVNDTotal2.Text = "0";
            // 
            // frmMasterCard_T140_ReconReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.txtVNDTotal2);
            this.Controls.Add(this.txtUSDTotal2);
            this.Controls.Add(this.txtVNDTotal1);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.ckbEditFilePath);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtFilePath);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtSoLuongRow);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.btnSearchData);
            this.Controls.Add(this.grdT140KetQuaTimKiem);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.datepickToDate);
            this.Controls.Add(this.FromDate);
            this.Controls.Add(this.datepickFromDate);
            this.Controls.Add(this.btnGhiThongTinXuongDB);
            this.Controls.Add(this.checkOverrideNewFileName);
            this.Controls.Add(this.txtUSDTotal1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtNumOfFile);
            this.Controls.Add(this.lblNumOfFile);
            this.Controls.Add(this.grdT140ReconReport);
            this.Controls.Add(this.btnChonFile);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.MaximizeBox = false;
            this.Name = "frmMasterCard_T140_ReconReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T140 GCMS REGON REPORT";
            ((System.ComponentModel.ISupportInitialize)(this.grdT140ReconReport)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdT140KetQuaTimKiem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.OpenFileDialog openDlgChonFileT140;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView grdT140ReconReport;
        private System.Windows.Forms.Label lblNumOfFile;
        private System.Windows.Forms.TextBox txtNumOfFile;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtUSDTotal1;
        private System.Windows.Forms.CheckBox checkOverrideNewFileName;
        private System.Windows.Forms.Button btnGhiThongTinXuongDB;
        private System.Windows.Forms.DateTimePicker datepickFromDate;
        private System.Windows.Forms.Label FromDate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.DateTimePicker datepickToDate;
        private System.Windows.Forms.DataGridView grdT140KetQuaTimKiem;
        private System.Windows.Forms.Button btnSearchData;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtSoLuongRow;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtFilePath;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.CheckBox ckbEditFilePath;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtVNDTotal1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colWriteDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRunDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colClearingDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCycle;
        private System.Windows.Forms.DataGridViewTextBoxColumn colUSDAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn colVNDAmount;
        private System.Windows.Forms.TextBox txtUSDTotal2;
        private System.Windows.Forms.TextBox txtVNDTotal2;
    }
}