namespace MasterCardTool
{
    partial class frmMasterCard_T057_ReferenceCurrencyCode
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
            this.grdCurrencyCodeList = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrencyCodeList)).BeginInit();
            this.SuspendLayout();
            // 
            // grdCurrencyCodeList
            // 
            this.grdCurrencyCodeList.AllowUserToAddRows = false;
            this.grdCurrencyCodeList.AllowUserToDeleteRows = false;
            this.grdCurrencyCodeList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdCurrencyCodeList.Location = new System.Drawing.Point(12, 25);
            this.grdCurrencyCodeList.Name = "grdCurrencyCodeList";
            this.grdCurrencyCodeList.ReadOnly = true;
            this.grdCurrencyCodeList.Size = new System.Drawing.Size(656, 697);
            this.grdCurrencyCodeList.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Currency Code List";
            // 
            // frmMasterCard_T057_ReferenceCurrencyCode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(678, 731);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.grdCurrencyCodeList);
            this.MaximizeBox = false;
            this.Name = "frmMasterCard_T057_ReferenceCurrencyCode";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "T057 Reference Currency Code";
            ((System.ComponentModel.ISupportInitialize)(this.grdCurrencyCodeList)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView grdCurrencyCodeList;
        private System.Windows.Forms.Label label1;
    }
}