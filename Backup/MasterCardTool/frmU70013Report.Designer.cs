namespace MasterCardTool
{
    partial class frmU70013Report
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
            this.dateTimePickerNgayBaoCao = new System.Windows.Forms.DateTimePicker();
            this.btnThucHien = new System.Windows.Forms.Button();
            this.lblNgayLayBaoCao = new System.Windows.Forms.Label();
            this.grdU70013Report = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.grdU70013Report)).BeginInit();
            this.SuspendLayout();
            // 
            // dateTimePickerNgayBaoCao
            // 
            this.dateTimePickerNgayBaoCao.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerNgayBaoCao.Location = new System.Drawing.Point(120, 11);
            this.dateTimePickerNgayBaoCao.Name = "dateTimePickerNgayBaoCao";
            this.dateTimePickerNgayBaoCao.Size = new System.Drawing.Size(99, 20);
            this.dateTimePickerNgayBaoCao.TabIndex = 1;
            // 
            // btnThucHien
            // 
            this.btnThucHien.Location = new System.Drawing.Point(228, 10);
            this.btnThucHien.Name = "btnThucHien";
            this.btnThucHien.Size = new System.Drawing.Size(75, 23);
            this.btnThucHien.TabIndex = 2;
            this.btnThucHien.Text = "Execute";
            this.btnThucHien.UseVisualStyleBackColor = true;
            this.btnThucHien.Click += new System.EventHandler(this.btnThucHien_Click);
            // 
            // lblNgayLayBaoCao
            // 
            this.lblNgayLayBaoCao.AutoSize = true;
            this.lblNgayLayBaoCao.Location = new System.Drawing.Point(16, 15);
            this.lblNgayLayBaoCao.Name = "lblNgayLayBaoCao";
            this.lblNgayLayBaoCao.Size = new System.Drawing.Size(92, 13);
            this.lblNgayLayBaoCao.TabIndex = 3;
            this.lblNgayLayBaoCao.Text = "Input Report Date";
            // 
            // grdU70013Report
            // 
            this.grdU70013Report.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.grdU70013Report.Location = new System.Drawing.Point(12, 39);
            this.grdU70013Report.Name = "grdU70013Report";
            this.grdU70013Report.Size = new System.Drawing.Size(1100, 615);
            this.grdU70013Report.TabIndex = 4;
            // 
            // frmU70013Report
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1124, 666);
            this.Controls.Add(this.grdU70013Report);
            this.Controls.Add(this.lblNgayLayBaoCao);
            this.Controls.Add(this.btnThucHien);
            this.Controls.Add(this.dateTimePickerNgayBaoCao);
            this.MaximizeBox = false;
            this.Name = "frmU70013Report";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Report U70013 ";
            ((System.ComponentModel.ISupportInitialize)(this.grdU70013Report)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dateTimePickerNgayBaoCao;
        private System.Windows.Forms.Button btnThucHien;
        private System.Windows.Forms.Label lblNgayLayBaoCao;
        private System.Windows.Forms.DataGridView grdU70013Report;
    }
}