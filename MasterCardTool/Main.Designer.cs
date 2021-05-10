namespace MasterCardTool
{
    partial class Main
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
            this.menuStripParseFile = new System.Windows.Forms.MenuStrip();
            this.menuMasterCardFile = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuT057CurrencyRateFile = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuT140 = new System.Windows.Forms.ToolStripMenuItem();
            this.submenuT112IncomingFile = new System.Windows.Forms.ToolStripMenuItem();
            this.menuReports = new System.Windows.Forms.ToolStripMenuItem();
            this.U70013ReportToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.instructionFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.checkFilterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.welcomeLetterToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripParseFile.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripParseFile
            // 
            this.menuStripParseFile.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.menuMasterCardFile,
            this.menuReports,
            this.instructionFileToolStripMenuItem});
            this.menuStripParseFile.Location = new System.Drawing.Point(0, 0);
            this.menuStripParseFile.Name = "menuStripParseFile";
            this.menuStripParseFile.Size = new System.Drawing.Size(725, 24);
            this.menuStripParseFile.TabIndex = 0;
            this.menuStripParseFile.Text = "menuStrip1";
            // 
            // menuMasterCardFile
            // 
            this.menuMasterCardFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.submenuT057CurrencyRateFile,
            this.submenuT140,
            this.submenuT112IncomingFile});
            this.menuMasterCardFile.Name = "menuMasterCardFile";
            this.menuMasterCardFile.Size = new System.Drawing.Size(94, 20);
            this.menuMasterCardFile.Text = "MasterCard File";
            // 
            // submenuT057CurrencyRateFile
            // 
            this.submenuT057CurrencyRateFile.Name = "submenuT057CurrencyRateFile";
            this.submenuT057CurrencyRateFile.Size = new System.Drawing.Size(221, 22);
            this.submenuT057CurrencyRateFile.Text = "T057 Currency Rate File";
            this.submenuT057CurrencyRateFile.Click += new System.EventHandler(this.submenuT057CurrencyRateFile_Click);
            // 
            // submenuT140
            // 
            this.submenuT140.Name = "submenuT140";
            this.submenuT140.Size = new System.Drawing.Size(221, 22);
            this.submenuT140.Text = "T140 Reconciliation Report File";
            this.submenuT140.Click += new System.EventHandler(this.submenuT140_Click);
            // 
            // submenuT112IncomingFile
            // 
            this.submenuT112IncomingFile.Name = "submenuT112IncomingFile";
            this.submenuT112IncomingFile.Size = new System.Drawing.Size(221, 22);
            this.submenuT112IncomingFile.Text = "T112 Incoming File";
            this.submenuT112IncomingFile.Click += new System.EventHandler(this.submenuT112IncomingFile_Click);
            // 
            // menuReports
            // 
            this.menuReports.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.U70013ReportToolStripMenuItem,
            this.welcomeLetterToolStripMenuItem});
            this.menuReports.Name = "menuReports";
            this.menuReports.Size = new System.Drawing.Size(57, 20);
            this.menuReports.Text = "Reports";
            // 
            // U70013ReportToolStripMenuItem
            // 
            this.U70013ReportToolStripMenuItem.Name = "U70013ReportToolStripMenuItem";
            this.U70013ReportToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.U70013ReportToolStripMenuItem.Text = "U70013 Report";
            this.U70013ReportToolStripMenuItem.Click += new System.EventHandler(this.u70013ReportToolStripMenuItem_Click);
            // 
            // instructionFileToolStripMenuItem
            // 
            this.instructionFileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.checkFilterToolStripMenuItem});
            this.instructionFileToolStripMenuItem.Name = "instructionFileToolStripMenuItem";
            this.instructionFileToolStripMenuItem.Size = new System.Drawing.Size(90, 20);
            this.instructionFileToolStripMenuItem.Text = "Instruction File";
            // 
            // checkFilterToolStripMenuItem
            // 
            this.checkFilterToolStripMenuItem.Name = "checkFilterToolStripMenuItem";
            this.checkFilterToolStripMenuItem.Size = new System.Drawing.Size(238, 22);
            this.checkFilterToolStripMenuItem.Text = "Check && Filter Overdrafts Account";
            this.checkFilterToolStripMenuItem.Click += new System.EventHandler(this.checkFilterToolStripMenuItem_Click);
            // 
            // welcomeLetterToolStripMenuItem
            // 
            this.welcomeLetterToolStripMenuItem.Name = "welcomeLetterToolStripMenuItem";
            this.welcomeLetterToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.welcomeLetterToolStripMenuItem.Text = "Welcome Letter";
            this.welcomeLetterToolStripMenuItem.Click += new System.EventHandler(this.welcomeLetterToolStripMenuItem_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(725, 424);
            this.Controls.Add(this.menuStripParseFile);
            this.MainMenuStrip = this.menuStripParseFile;
            this.Name = "Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Master Card Tool";
            this.menuStripParseFile.ResumeLayout(false);
            this.menuStripParseFile.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripParseFile;
        private System.Windows.Forms.ToolStripMenuItem menuMasterCardFile;
        private System.Windows.Forms.ToolStripMenuItem submenuT112IncomingFile;
        private System.Windows.Forms.ToolStripMenuItem submenuT140;
        private System.Windows.Forms.ToolStripMenuItem submenuT057CurrencyRateFile;
        private System.Windows.Forms.ToolStripMenuItem menuReports;
        private System.Windows.Forms.ToolStripMenuItem U70013ReportToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem instructionFileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem checkFilterToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem welcomeLetterToolStripMenuItem;
    }
}

