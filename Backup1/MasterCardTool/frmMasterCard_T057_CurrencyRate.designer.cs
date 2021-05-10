namespace MasterCardTool
{
    partial class frmMasterCard_T057_CurrencyRate
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
            this.btnGhiThongTinXuongDB = new System.Windows.Forms.Button();
            this.grdT057CurrencyRateFile = new System.Windows.Forms.DataGridView();
            this.colNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceCurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colReferenceCurrencyCode = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSourceCurrencyExponent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateClass = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colRateFormatIndicator = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colBuyCurrencyConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMidCurrencyConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colSellCurrencyConversionRate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnChonFile = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openDlgChonFileT057 = new System.Windows.Forms.OpenFileDialog();
            this.checkOverrideCurrNewFileName = new System.Windows.Forms.CheckBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtSellRate = new System.Windows.Forms.TextBox();
            this.txtMidRate = new System.Windows.Forms.TextBox();
            this.txtBuyRate = new System.Windows.Forms.TextBox();
            this.btnGetRate = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cbxReferenceCode = new System.Windows.Forms.ComboBox();
            this.cbxSourceCode = new System.Windows.Forms.ComboBox();
            this.grpFile = new System.Windows.Forms.GroupBox();
            this.txtNewFileName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtFileName = new System.Windows.Forms.TextBox();
            this.grpDB = new System.Windows.Forms.GroupBox();
            this.btnLoadDB = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.datepickCurrencyDay = new System.Windows.Forms.DateTimePicker();
            this.rdoLoadDB = new System.Windows.Forms.RadioButton();
            this.rdoLoadFile = new System.Windows.Forms.RadioButton();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblCurrencyDateFile = new System.Windows.Forms.Label();
            this.grdT057CurrencyRateDB = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colNewFileName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn9 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.lblCurrencyDateDB = new System.Windows.Forms.Label();
            this.btnReferenceCurrencyCode = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.grdT057CurrencyRateFile)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.grpFile.SuspendLayout();
            this.grpDB.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdT057CurrencyRateDB)).BeginInit();
            this.SuspendLayout();
            // 
            // btnGhiThongTinXuongDB
            // 
            this.btnGhiThongTinXuongDB.Location = new System.Drawing.Point(9, 86);
            this.btnGhiThongTinXuongDB.Name = "btnGhiThongTinXuongDB";
            this.btnGhiThongTinXuongDB.Size = new System.Drawing.Size(103, 23);
            this.btnGhiThongTinXuongDB.TabIndex = 81;
            this.btnGhiThongTinXuongDB.Text = "Write to DataBase";
            this.btnGhiThongTinXuongDB.UseVisualStyleBackColor = true;
            this.btnGhiThongTinXuongDB.Click += new System.EventHandler(this.btnGhiThongTinXuongDB_Click);
            // 
            // grdT057CurrencyRateFile
            // 
            this.grdT057CurrencyRateFile.AllowUserToAddRows = false;
            this.grdT057CurrencyRateFile.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT057CurrencyRateFile.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.grdT057CurrencyRateFile.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdT057CurrencyRateFile.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colNo,
            this.colSourceCurrencyCode,
            this.colReferenceCurrencyCode,
            this.colSourceCurrencyExponent,
            this.colRateClass,
            this.colRateFormatIndicator,
            this.colBuyCurrencyConversionRate,
            this.colMidCurrencyConversionRate,
            this.colSellCurrencyConversionRate});
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdT057CurrencyRateFile.DefaultCellStyle = dataGridViewCellStyle2;
            this.grdT057CurrencyRateFile.Location = new System.Drawing.Point(5, 170);
            this.grdT057CurrencyRateFile.Name = "grdT057CurrencyRateFile";
            this.grdT057CurrencyRateFile.ReadOnly = true;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT057CurrencyRateFile.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.grdT057CurrencyRateFile.Size = new System.Drawing.Size(632, 492);
            this.grdT057CurrencyRateFile.TabIndex = 74;
            // 
            // colNo
            // 
            this.colNo.HeaderText = "No";
            this.colNo.Name = "colNo";
            this.colNo.ReadOnly = true;
            this.colNo.Width = 40;
            // 
            // colSourceCurrencyCode
            // 
            this.colSourceCurrencyCode.HeaderText = "SourceCode";
            this.colSourceCurrencyCode.Name = "colSourceCurrencyCode";
            this.colSourceCurrencyCode.ReadOnly = true;
            this.colSourceCurrencyCode.Width = 70;
            // 
            // colReferenceCurrencyCode
            // 
            this.colReferenceCurrencyCode.HeaderText = "ReferCode";
            this.colReferenceCurrencyCode.Name = "colReferenceCurrencyCode";
            this.colReferenceCurrencyCode.ReadOnly = true;
            this.colReferenceCurrencyCode.Width = 80;
            // 
            // colSourceCurrencyExponent
            // 
            this.colSourceCurrencyExponent.HeaderText = "Exponent";
            this.colSourceCurrencyExponent.Name = "colSourceCurrencyExponent";
            this.colSourceCurrencyExponent.ReadOnly = true;
            this.colSourceCurrencyExponent.Width = 40;
            // 
            // colRateClass
            // 
            this.colRateClass.HeaderText = "RateClass";
            this.colRateClass.Name = "colRateClass";
            this.colRateClass.ReadOnly = true;
            this.colRateClass.Width = 80;
            // 
            // colRateFormatIndicator
            // 
            this.colRateFormatIndicator.HeaderText = "RateFormatIndicator";
            this.colRateFormatIndicator.Name = "colRateFormatIndicator";
            this.colRateFormatIndicator.ReadOnly = true;
            this.colRateFormatIndicator.Visible = false;
            // 
            // colBuyCurrencyConversionRate
            // 
            this.colBuyCurrencyConversionRate.FillWeight = 70F;
            this.colBuyCurrencyConversionRate.HeaderText = "BuyRate";
            this.colBuyCurrencyConversionRate.Name = "colBuyCurrencyConversionRate";
            this.colBuyCurrencyConversionRate.ReadOnly = true;
            // 
            // colMidCurrencyConversionRate
            // 
            this.colMidCurrencyConversionRate.FillWeight = 70F;
            this.colMidCurrencyConversionRate.HeaderText = "MidRate";
            this.colMidCurrencyConversionRate.Name = "colMidCurrencyConversionRate";
            this.colMidCurrencyConversionRate.ReadOnly = true;
            // 
            // colSellCurrencyConversionRate
            // 
            this.colSellCurrencyConversionRate.FillWeight = 70F;
            this.colSellCurrencyConversionRate.HeaderText = "SellRate";
            this.colSellCurrencyConversionRate.Name = "colSellCurrencyConversionRate";
            this.colSellCurrencyConversionRate.ReadOnly = true;
            // 
            // btnChonFile
            // 
            this.btnChonFile.Location = new System.Drawing.Point(414, 34);
            this.btnChonFile.Name = "btnChonFile";
            this.btnChonFile.Size = new System.Drawing.Size(61, 23);
            this.btnChonFile.TabIndex = 73;
            this.btnChonFile.Text = "Browse...";
            this.btnChonFile.UseVisualStyleBackColor = true;
            this.btnChonFile.Click += new System.EventHandler(this.btnChonFile_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(6, 39);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(50, 13);
            this.label2.TabIndex = 72;
            this.label2.Text = "Input File";
            // 
            // openDlgChonFileT057
            // 
            this.openDlgChonFileT057.FileName = "openDlgChonFileT057";
            // 
            // checkOverrideCurrNewFileName
            // 
            this.checkOverrideCurrNewFileName.AutoSize = true;
            this.checkOverrideCurrNewFileName.Location = new System.Drawing.Point(9, 17);
            this.checkOverrideCurrNewFileName.Name = "checkOverrideCurrNewFileName";
            this.checkOverrideCurrNewFileName.Size = new System.Drawing.Size(143, 17);
            this.checkOverrideCurrNewFileName.TabIndex = 80;
            this.checkOverrideCurrNewFileName.Text = "Overwrite New FileName";
            this.checkOverrideCurrNewFileName.UseVisualStyleBackColor = true;
            this.checkOverrideCurrNewFileName.MouseClick += new System.Windows.Forms.MouseEventHandler(this.checkOverrideNewFileName_MouseClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label8);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.txtSellRate);
            this.groupBox1.Controls.Add(this.txtMidRate);
            this.groupBox1.Controls.Add(this.txtBuyRate);
            this.groupBox1.Controls.Add(this.btnGetRate);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.cbxReferenceCode);
            this.groupBox1.Controls.Add(this.cbxSourceCode);
            this.groupBox1.Location = new System.Drawing.Point(643, 7);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(361, 139);
            this.groupBox1.TabIndex = 82;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Currency Conversion Rate";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(12, 77);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(51, 13);
            this.label8.TabIndex = 80;
            this.label8.Text = "Buy Rate";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 77);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(50, 13);
            this.label7.TabIndex = 79;
            this.label7.Text = "Mid Rate";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(221, 77);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(50, 13);
            this.label6.TabIndex = 78;
            this.label6.Text = "Sell Rate";
            // 
            // txtSellRate
            // 
            this.txtSellRate.Location = new System.Drawing.Point(224, 92);
            this.txtSellRate.Name = "txtSellRate";
            this.txtSellRate.ReadOnly = true;
            this.txtSellRate.Size = new System.Drawing.Size(70, 20);
            this.txtSellRate.TabIndex = 77;
            // 
            // txtMidRate
            // 
            this.txtMidRate.Location = new System.Drawing.Point(119, 92);
            this.txtMidRate.Name = "txtMidRate";
            this.txtMidRate.ReadOnly = true;
            this.txtMidRate.Size = new System.Drawing.Size(70, 20);
            this.txtMidRate.TabIndex = 76;
            // 
            // txtBuyRate
            // 
            this.txtBuyRate.Location = new System.Drawing.Point(14, 92);
            this.txtBuyRate.Name = "txtBuyRate";
            this.txtBuyRate.ReadOnly = true;
            this.txtBuyRate.Size = new System.Drawing.Size(70, 20);
            this.txtBuyRate.TabIndex = 75;
            // 
            // btnGetRate
            // 
            this.btnGetRate.Location = new System.Drawing.Point(224, 35);
            this.btnGetRate.Name = "btnGetRate";
            this.btnGetRate.Size = new System.Drawing.Size(70, 23);
            this.btnGetRate.TabIndex = 74;
            this.btnGetRate.Text = "Get Rate";
            this.btnGetRate.UseVisualStyleBackColor = true;
            this.btnGetRate.Click += new System.EventHandler(this.btnGetRate_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(85, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(31, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "===>";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(116, 22);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(82, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "ReferenceCode";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 22);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(66, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "SourceCode";
            // 
            // cbxReferenceCode
            // 
            this.cbxReferenceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxReferenceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxReferenceCode.FormattingEnabled = true;
            this.cbxReferenceCode.Items.AddRange(new object[] {
            "...",
            "008",
            "012",
            "032",
            "036",
            "044",
            "048",
            "050",
            "051",
            "052",
            "060",
            "064",
            "068",
            "072",
            "084",
            "090",
            "096",
            "104",
            "108",
            "116",
            "124",
            "132",
            "136",
            "144",
            "152",
            "156",
            "157",
            "158",
            "170",
            "174",
            "188",
            "191",
            "192",
            "203",
            "208",
            "214",
            "222",
            "230",
            "233",
            "238",
            "242",
            "262",
            "270",
            "292",
            "320",
            "328",
            "332",
            "340",
            "344",
            "348",
            "352",
            "356",
            "360",
            "368",
            "376",
            "388",
            "392",
            "398",
            "400",
            "404",
            "410",
            "414",
            "417",
            "418",
            "422",
            "426",
            "428",
            "430",
            "434",
            "440",
            "446",
            "454",
            "458",
            "462",
            "478",
            "480",
            "484",
            "496",
            "498",
            "504",
            "512",
            "516",
            "524",
            "532",
            "533",
            "548",
            "554",
            "558",
            "566",
            "578",
            "586",
            "590",
            "598",
            "600",
            "604",
            "608",
            "634",
            "643",
            "646",
            "654",
            "678",
            "682",
            "690",
            "694",
            "702",
            "704",
            "706",
            "710",
            "748",
            "752",
            "756",
            "760",
            "764",
            "776",
            "780",
            "784",
            "788",
            "800",
            "807",
            "818",
            "826",
            "834",
            "840",
            "858",
            "860",
            "882",
            "886",
            "894",
            "901",
            "936",
            "937",
            "941",
            "943",
            "944",
            "946",
            "949",
            "950",
            "951",
            "952",
            "953",
            "968",
            "969",
            "971",
            "972",
            "973",
            "974",
            "975",
            "976",
            "977",
            "978",
            "980",
            "981",
            "985",
            "986"});
            this.cbxReferenceCode.Location = new System.Drawing.Point(119, 37);
            this.cbxReferenceCode.Name = "cbxReferenceCode";
            this.cbxReferenceCode.Size = new System.Drawing.Size(70, 21);
            this.cbxReferenceCode.Sorted = true;
            this.cbxReferenceCode.TabIndex = 1;
            this.cbxReferenceCode.Text = "...";
            // 
            // cbxSourceCode
            // 
            this.cbxSourceCode.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.cbxSourceCode.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.cbxSourceCode.FormattingEnabled = true;
            this.cbxSourceCode.ItemHeight = 13;
            this.cbxSourceCode.Items.AddRange(new object[] {
            "...",
            "008",
            "012",
            "032",
            "036",
            "044",
            "048",
            "050",
            "051",
            "052",
            "060",
            "064",
            "068",
            "072",
            "084",
            "090",
            "096",
            "104",
            "108",
            "116",
            "124",
            "132",
            "136",
            "144",
            "152",
            "156",
            "157",
            "158",
            "170",
            "174",
            "188",
            "191",
            "192",
            "203",
            "208",
            "214",
            "222",
            "230",
            "233",
            "238",
            "242",
            "262",
            "270",
            "292",
            "320",
            "328",
            "332",
            "340",
            "344",
            "348",
            "352",
            "356",
            "360",
            "368",
            "376",
            "388",
            "392",
            "398",
            "400",
            "404",
            "410",
            "414",
            "417",
            "418",
            "422",
            "426",
            "428",
            "430",
            "434",
            "440",
            "446",
            "454",
            "458",
            "462",
            "478",
            "480",
            "484",
            "496",
            "498",
            "504",
            "512",
            "516",
            "524",
            "532",
            "533",
            "548",
            "554",
            "558",
            "566",
            "578",
            "586",
            "590",
            "598",
            "600",
            "604",
            "608",
            "634",
            "643",
            "646",
            "654",
            "678",
            "682",
            "690",
            "694",
            "702",
            "704",
            "706",
            "710",
            "748",
            "752",
            "756",
            "760",
            "764",
            "776",
            "780",
            "784",
            "788",
            "800",
            "807",
            "818",
            "826",
            "834",
            "840",
            "858",
            "860",
            "882",
            "886",
            "894",
            "901",
            "936",
            "937",
            "941",
            "943",
            "944",
            "946",
            "949",
            "950",
            "951",
            "952",
            "953",
            "968",
            "969",
            "971",
            "972",
            "973",
            "974",
            "975",
            "976",
            "977",
            "978",
            "980",
            "981",
            "985",
            "986"});
            this.cbxSourceCode.Location = new System.Drawing.Point(14, 37);
            this.cbxSourceCode.Name = "cbxSourceCode";
            this.cbxSourceCode.Size = new System.Drawing.Size(70, 21);
            this.cbxSourceCode.Sorted = true;
            this.cbxSourceCode.TabIndex = 0;
            this.cbxSourceCode.Text = "...";
            // 
            // grpFile
            // 
            this.grpFile.Controls.Add(this.txtNewFileName);
            this.grpFile.Controls.Add(this.label9);
            this.grpFile.Controls.Add(this.txtFileName);
            this.grpFile.Controls.Add(this.checkOverrideCurrNewFileName);
            this.grpFile.Controls.Add(this.label2);
            this.grpFile.Controls.Add(this.btnGhiThongTinXuongDB);
            this.grpFile.Controls.Add(this.btnChonFile);
            this.grpFile.Location = new System.Drawing.Point(0, 32);
            this.grpFile.Name = "grpFile";
            this.grpFile.Size = new System.Drawing.Size(483, 116);
            this.grpFile.TabIndex = 83;
            this.grpFile.TabStop = false;
            this.grpFile.Text = "Read File && Write DB";
            // 
            // txtNewFileName
            // 
            this.txtNewFileName.Location = new System.Drawing.Point(62, 61);
            this.txtNewFileName.Name = "txtNewFileName";
            this.txtNewFileName.ReadOnly = true;
            this.txtNewFileName.Size = new System.Drawing.Size(413, 20);
            this.txtNewFileName.TabIndex = 84;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(8, 65);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(48, 13);
            this.label9.TabIndex = 83;
            this.label9.Text = "New File";
            // 
            // txtFileName
            // 
            this.txtFileName.Location = new System.Drawing.Point(62, 36);
            this.txtFileName.Name = "txtFileName";
            this.txtFileName.Size = new System.Drawing.Size(346, 20);
            this.txtFileName.TabIndex = 82;
            // 
            // grpDB
            // 
            this.grpDB.Controls.Add(this.btnLoadDB);
            this.grpDB.Controls.Add(this.label1);
            this.grpDB.Controls.Add(this.datepickCurrencyDay);
            this.grpDB.Enabled = false;
            this.grpDB.Location = new System.Drawing.Point(489, 32);
            this.grpDB.Name = "grpDB";
            this.grpDB.Size = new System.Drawing.Size(142, 116);
            this.grpDB.TabIndex = 84;
            this.grpDB.TabStop = false;
            this.grpDB.Text = "Load from DB";
            // 
            // btnLoadDB
            // 
            this.btnLoadDB.Location = new System.Drawing.Point(13, 86);
            this.btnLoadDB.Name = "btnLoadDB";
            this.btnLoadDB.Size = new System.Drawing.Size(90, 23);
            this.btnLoadDB.TabIndex = 82;
            this.btnLoadDB.Text = "Get Result";
            this.btnLoadDB.UseVisualStyleBackColor = true;
            this.btnLoadDB.Click += new System.EventHandler(this.btnLoadDB_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(10, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Rate of Day:";
            // 
            // datepickCurrencyDay
            // 
            this.datepickCurrencyDay.CustomFormat = "dd/MM/yyyy";
            this.datepickCurrencyDay.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.datepickCurrencyDay.Location = new System.Drawing.Point(13, 38);
            this.datepickCurrencyDay.Name = "datepickCurrencyDay";
            this.datepickCurrencyDay.Size = new System.Drawing.Size(90, 20);
            this.datepickCurrencyDay.TabIndex = 0;
            // 
            // rdoLoadDB
            // 
            this.rdoLoadDB.AutoSize = true;
            this.rdoLoadDB.Location = new System.Drawing.Point(489, 9);
            this.rdoLoadDB.Name = "rdoLoadDB";
            this.rdoLoadDB.Size = new System.Drawing.Size(90, 17);
            this.rdoLoadDB.TabIndex = 85;
            this.rdoLoadDB.Text = "Load from DB";
            this.rdoLoadDB.UseVisualStyleBackColor = true;
            this.rdoLoadDB.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoLoadDB_MouseClick);
            // 
            // rdoLoadFile
            // 
            this.rdoLoadFile.AutoSize = true;
            this.rdoLoadFile.Checked = true;
            this.rdoLoadFile.Location = new System.Drawing.Point(9, 9);
            this.rdoLoadFile.Name = "rdoLoadFile";
            this.rdoLoadFile.Size = new System.Drawing.Size(125, 17);
            this.rdoLoadFile.TabIndex = 86;
            this.rdoLoadFile.TabStop = true;
            this.rdoLoadFile.Text = "Read File && Write DB";
            this.rdoLoadFile.UseVisualStyleBackColor = true;
            this.rdoLoadFile.MouseClick += new System.Windows.Forms.MouseEventHandler(this.rdoFile_MouseClick);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.rdoLoadFile);
            this.groupBox2.Controls.Add(this.grpDB);
            this.groupBox2.Controls.Add(this.rdoLoadDB);
            this.groupBox2.Controls.Add(this.grpFile);
            this.groupBox2.Location = new System.Drawing.Point(5, -2);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(631, 148);
            this.groupBox2.TabIndex = 87;
            this.groupBox2.TabStop = false;
            // 
            // lblCurrencyDateFile
            // 
            this.lblCurrencyDateFile.AutoSize = true;
            this.lblCurrencyDateFile.ForeColor = System.Drawing.Color.Red;
            this.lblCurrencyDateFile.Location = new System.Drawing.Point(8, 152);
            this.lblCurrencyDateFile.Name = "lblCurrencyDateFile";
            this.lblCurrencyDateFile.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencyDateFile.TabIndex = 88;
            // 
            // grdT057CurrencyRateDB
            // 
            this.grdT057CurrencyRateDB.AllowUserToAddRows = false;
            this.grdT057CurrencyRateDB.AllowUserToDeleteRows = false;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT057CurrencyRateDB.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.grdT057CurrencyRateDB.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdT057CurrencyRateDB.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.colFileName,
            this.colNewFileName,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewTextBoxColumn9});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.grdT057CurrencyRateDB.DefaultCellStyle = dataGridViewCellStyle5;
            this.grdT057CurrencyRateDB.Location = new System.Drawing.Point(5, 170);
            this.grdT057CurrencyRateDB.Name = "grdT057CurrencyRateDB";
            this.grdT057CurrencyRateDB.ReadOnly = true;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.grdT057CurrencyRateDB.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.grdT057CurrencyRateDB.Size = new System.Drawing.Size(816, 492);
            this.grdT057CurrencyRateDB.TabIndex = 90;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.HeaderText = "No";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            this.dataGridViewTextBoxColumn1.Width = 40;
            // 
            // colFileName
            // 
            this.colFileName.HeaderText = "FileName";
            this.colFileName.Name = "colFileName";
            this.colFileName.ReadOnly = true;
            // 
            // colNewFileName
            // 
            this.colNewFileName.HeaderText = "NewFileName";
            this.colNewFileName.Name = "colNewFileName";
            this.colNewFileName.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.HeaderText = "SourceCode";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            this.dataGridViewTextBoxColumn2.Width = 70;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.HeaderText = "ReferCode";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            this.dataGridViewTextBoxColumn3.Width = 80;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.HeaderText = "Exponent";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            this.dataGridViewTextBoxColumn4.Width = 40;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.HeaderText = "RateClass";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            this.dataGridViewTextBoxColumn5.Width = 80;
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.FillWeight = 70F;
            this.dataGridViewTextBoxColumn7.HeaderText = "BuyRate";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.FillWeight = 70F;
            this.dataGridViewTextBoxColumn8.HeaderText = "MidRate";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn9
            // 
            this.dataGridViewTextBoxColumn9.FillWeight = 70F;
            this.dataGridViewTextBoxColumn9.HeaderText = "SellRate";
            this.dataGridViewTextBoxColumn9.Name = "dataGridViewTextBoxColumn9";
            this.dataGridViewTextBoxColumn9.ReadOnly = true;
            // 
            // lblCurrencyDateDB
            // 
            this.lblCurrencyDateDB.AutoSize = true;
            this.lblCurrencyDateDB.ForeColor = System.Drawing.Color.Red;
            this.lblCurrencyDateDB.Location = new System.Drawing.Point(491, 152);
            this.lblCurrencyDateDB.Name = "lblCurrencyDateDB";
            this.lblCurrencyDateDB.Size = new System.Drawing.Size(0, 13);
            this.lblCurrencyDateDB.TabIndex = 91;
            // 
            // btnReferenceCurrencyCode
            // 
            this.btnReferenceCurrencyCode.Location = new System.Drawing.Point(827, 170);
            this.btnReferenceCurrencyCode.Name = "btnReferenceCurrencyCode";
            this.btnReferenceCurrencyCode.Size = new System.Drawing.Size(147, 23);
            this.btnReferenceCurrencyCode.TabIndex = 92;
            this.btnReferenceCurrencyCode.Text = "Reference Currency Code";
            this.btnReferenceCurrencyCode.UseVisualStyleBackColor = true;
            this.btnReferenceCurrencyCode.Click += new System.EventHandler(this.btnReferenceCurrencyCode_Click);
            // 
            // frmMasterCard_T057_CurrencyRate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1016, 666);
            this.Controls.Add(this.btnReferenceCurrencyCode);
            this.Controls.Add(this.lblCurrencyDateDB);
            this.Controls.Add(this.grdT057CurrencyRateDB);
            this.Controls.Add(this.lblCurrencyDateFile);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.grdT057CurrencyRateFile);
            this.MaximizeBox = false;
            this.Name = "frmMasterCard_T057_CurrencyRate";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T057 Currency Conversion Rate";
            ((System.ComponentModel.ISupportInitialize)(this.grdT057CurrencyRateFile)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpFile.ResumeLayout(false);
            this.grpFile.PerformLayout();
            this.grpDB.ResumeLayout(false);
            this.grpDB.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.grdT057CurrencyRateDB)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnGhiThongTinXuongDB;
        private System.Windows.Forms.DataGridView grdT057CurrencyRateFile;
        private System.Windows.Forms.Button btnChonFile;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.OpenFileDialog openDlgChonFileT057;
        private System.Windows.Forms.CheckBox checkOverrideCurrNewFileName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cbxReferenceCode;
        private System.Windows.Forms.ComboBox cbxSourceCode;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtSellRate;
        private System.Windows.Forms.TextBox txtMidRate;
        private System.Windows.Forms.TextBox txtBuyRate;
        private System.Windows.Forms.Button btnGetRate;
        private System.Windows.Forms.GroupBox grpFile;
        private System.Windows.Forms.TextBox txtFileName;
        private System.Windows.Forms.GroupBox grpDB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker datepickCurrencyDay;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtNewFileName;
        private System.Windows.Forms.Button btnLoadDB;
        private System.Windows.Forms.RadioButton rdoLoadDB;
        private System.Windows.Forms.RadioButton rdoLoadFile;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label lblCurrencyDateFile;
        private System.Windows.Forms.DataGridView grdT057CurrencyRateDB;
        private System.Windows.Forms.Label lblCurrencyDateDB;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNewFileName;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn9;
        private System.Windows.Forms.DataGridViewTextBoxColumn colNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceCurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colReferenceCurrencyCode;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSourceCurrencyExponent;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateClass;
        private System.Windows.Forms.DataGridViewTextBoxColumn colRateFormatIndicator;
        private System.Windows.Forms.DataGridViewTextBoxColumn colBuyCurrencyConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMidCurrencyConversionRate;
        private System.Windows.Forms.DataGridViewTextBoxColumn colSellCurrencyConversionRate;
        private System.Windows.Forms.Button btnReferenceCurrencyCode;
    }
}