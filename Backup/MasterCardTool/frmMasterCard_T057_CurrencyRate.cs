using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MasterCardTool
{
    public partial class frmMasterCard_T057_CurrencyRate : Form
    {
        XulyNghiepVu xl = new XulyNghiepVu();
        public frmMasterCard_T057_CurrencyRate()
        {
            InitializeComponent();
            xl = new XulyNghiepVu();
            grdT057CurrencyRateFile.Visible = true;
            grdT057CurrencyRateDB.Visible = false;
        }
        string existed_str = "File existed";

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            
            openDlgChonFileT057.Filter = "Currency Rate Files(TT057*.001)|TT057*.001|All Files(*.*)|*.*";
            string filename = "";
            string filenameresult = "";
            if (openDlgChonFileT057.ShowDialog() == DialogResult.OK)
            {
                if (openDlgChonFileT057.FileName.IndexOf("TT057") != -1)
                {
                    grdT057CurrencyRateFile.Rows.Clear();
                    MC_T057 t057_data = new MC_T057();
                    filename = openDlgChonFileT057.FileName;
                    txtFileName.Text = filename;
                    t057_data = XuLyFileT057(filename);
                    filenameresult = LuuFileVoiTenMoi(t057_data);
                    txtNewFileName.Text = filenameresult;
                    HienThiLenManHinh_File(filenameresult, t057_data);
                    lblCurrencyDateFile.Text = t057_data.date.Substring(0, 2) + "/" + t057_data.date.Substring(2, 2) + "/" + t057_data.date.Substring(4, 4);
                }
                else
                {
                    MessageBox.Show("File format not correct!");
                }
            }
        }
        private string LuuFileVoiTenMoi(MC_T057 t057_data)
        {
            try
            {
                File.Copy(t057_data.filename, t057_data.newfilename, checkOverrideCurrNewFileName.Checked);
            }
            catch
            {
                t057_data.newfilename = existed_str;
            }
            return t057_data.newfilename;
        }
        private MC_T057 XuLyFileT057(string filename)
        {
            MC_T057 t057_data = new MC_T057();
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader r = new StreamReader(fs, Encoding.UTF8);
            //String[] temp = new String[1];
            int i = 0;

            String str = r.ReadLine().Trim();
            if (str.Substring(0, 1) == "H")
            {
                t057_data.headerDescription = str.Substring(0, 1);
                t057_data.date = str.Substring(7, 2) + str.Substring(5, 2) + str.Substring(1, 4);
                t057_data.time = str.Substring(9, 6);
                t057_data.version = str.Substring(15, 1);

                do
                {
                    str = r.ReadLine();
                    if (str.Substring(0, 1) == "D")
                    {
                        t057_data.detail[i].detailDescription = str.Substring(0, 1);
                        t057_data.detail[i].sourceCurrencyCode = str.Substring(1, 3);
                        t057_data.detail[i].referenceCurrencyCode = str.Substring(4, 3);
                        t057_data.detail[i].sourceCurrencyExponent = str.Substring(7, 1);
                        t057_data.detail[i].rateClass = str.Substring(8, 1);
                        t057_data.detail[i].rateFormatIndicator = str.Substring(9, 1);
                        t057_data.detail[i].buyCurrencyConversionRate = double.Parse(str.Substring(10, 8) + "." + str.Substring(18,7));
                        t057_data.detail[i].midCurrencyConversionRate = double.Parse(str.Substring(25, 8) + "." + str.Substring(33,7));
                        t057_data.detail[i].sellCurrencyConversionRate = double.Parse(str.Substring(40, 8) + "." + str.Substring(48,7));
                        t057_data.detail[i].reservedField = str.Substring(55, 15);
                        i++;
                    }
                    else
                        if (str.Substring(0, 1) == "T")
                            break;
                } while (str != null);
                t057_data.trailerDescription = str.Substring(0, 1);
                t057_data.totalDetailRecordCount = int.Parse(str.Substring(1, 6));
                t057_data.hasTotal = double.Parse(str.Substring(7,10) + "." + str.Substring(17,7));
            }
            int index = filename.LastIndexOf('\\');
            string temp = "T057_" + t057_data.date;
            string newname = filename.Substring(0, index) + "\\" + temp + ".currency";
            t057_data.filename = filename;
            
            t057_data.newfilename = newname;

            r.Close();
            fs.Close();
            return t057_data;
        }
        private void HienThiLenManHinh_File(string filenameresult, MC_T057 data)
        {
            //grdT057CurrencyRateFile.Visible = true;
            string stt = "";
            string buy = "";
            string mid = "";
            string sell = "";
            if (filenameresult != existed_str)
            {
                int index = filenameresult.LastIndexOf('\\');
                filenameresult = filenameresult.Substring(index + 1, filenameresult.Length - (index + 1));
            }
            int n = data.totalDetailRecordCount;
            string[] row = new string[1];
            for (int i = 0; i < n; i++)
            {
                stt = "" + (i+1);
                buy = String.Format("{0:#,##0.##}", data.detail[i].buyCurrencyConversionRate);
                mid = String.Format("{0:#,##0.##}", data.detail[i].midCurrencyConversionRate);
                sell = String.Format("{0:#,##0.##}", data.detail[i].sellCurrencyConversionRate);
                row = new string[] { stt, 
                        data.detail[i].sourceCurrencyCode, data.detail[i].referenceCurrencyCode, 
                        data.detail[i].sourceCurrencyExponent, data.detail[i].rateClass,
                        data.detail[i].rateFormatIndicator, buy,mid,sell
                        //,data.detail[i].reservedField
                        };
                grdT057CurrencyRateFile.Rows.Add(row);
            }
        }


        private void btnGetRate_Click(object sender, EventArgs e)
        {
            txtBuyRate.Text = "";
            txtMidRate.Text = "";
            txtSellRate.Text = "";
            string sourcecode = cbxSourceCode.Text;
            string refcode = cbxReferenceCode.Text;
            int n = 0;
            if (rdoLoadFile.Checked == true)
            {

                n = grdT057CurrencyRateFile.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    if ((grdT057CurrencyRateFile.Rows[i].Cells[1].Value.ToString() == sourcecode)
                        && (grdT057CurrencyRateFile.Rows[i].Cells[2].Value.ToString() == refcode))
                    {
                        txtBuyRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[6].Value.ToString()));
                        txtMidRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[7].Value.ToString()));
                        txtSellRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[8].Value.ToString()));
                    }
                }
            }
            else
            {
                n = grdT057CurrencyRateDB.Rows.Count;
                for (int i = 0; i < n; i++)
                {
                    if ((grdT057CurrencyRateDB.Rows[i].Cells[3].Value.ToString() == sourcecode)
                        && (grdT057CurrencyRateDB.Rows[i].Cells[4].Value.ToString() == refcode))
                    {
                        txtBuyRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateDB.Rows[i].Cells[7].Value.ToString()));
                        txtMidRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateDB.Rows[i].Cells[8].Value.ToString()));
                        txtSellRate.Text = String.Format("{0:#,##0.##}", Double.Parse(grdT057CurrencyRateDB.Rows[i].Cells[9].Value.ToString()));
                    }
                }
            }
        }

        private void checkOverrideNewFileName_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkOverrideCurrNewFileName.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure overwrite the newfilename if that existed?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    checkOverrideCurrNewFileName.Checked = false;
                else
                    checkOverrideCurrNewFileName.Checked = true;
            }
        }

        private void rdoLoadDB_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdoLoadDB.Checked == true)
            {
                grpFile.Enabled = false;
                grpDB.Enabled = true;
                grdT057CurrencyRateFile.Visible = false;
                grdT057CurrencyRateDB.Visible = true;
                lblCurrencyDateDB.Visible = true;
                lblCurrencyDateFile.Visible = false;
            }
        }

        private void rdoFile_MouseClick(object sender, MouseEventArgs e)
        {
            if (rdoLoadFile.Checked == true)
            {
                grpDB.Enabled = false;
                grpFile.Enabled = true;
                grdT057CurrencyRateFile.Visible = true;
                grdT057CurrencyRateDB.Visible = false;
                lblCurrencyDateDB.Visible = false;
                lblCurrencyDateFile.Visible = true;
            }
        }
        private void HienThiLenManHinh_DB(DataTable data)
        {
            string[] row = new string[1];
            int n = data.Rows.Count;
            string stt = "";
            for (int i = 0; i < n; i++)
            {
                stt = "" + (i + 1);
                row = new string[] { stt, 
                        data.Rows[i].ItemArray[1].ToString(),
                        data.Rows[i].ItemArray[2].ToString(),
                        data.Rows[i].ItemArray[4].ToString(),
                        data.Rows[i].ItemArray[5].ToString(),
                        data.Rows[i].ItemArray[6].ToString(),
                        data.Rows[i].ItemArray[7].ToString(),
                        String.Format("{0:#,##0.##}", Double.Parse(data.Rows[i].ItemArray[8].ToString())),
                        String.Format("{0:#,##0.##}", Double.Parse(data.Rows[i].ItemArray[9].ToString())),
                        String.Format("{0:#,##0.##}", Double.Parse(data.Rows[i].ItemArray[10].ToString())),
                        };
                grdT057CurrencyRateDB.Rows.Add(row);
            }
        }
        private void btnLoadDB_Click(object sender, EventArgs e)
        {
            //grdT057CurrencyRateDB.Visible = true;
            //grdT057CurrencyRateFile.Visible = false;
            //if(grdT057CurrencyRateDB.Rows.Count > 0)
            grdT057CurrencyRateDB.Rows.Clear();
            DataTable table = xl.LoadCurrencyRateFromDB(datepickCurrencyDay.Text);
            HienThiLenManHinh_DB(table);
            //grdT057CurrencysdfgRateDB.DataSource = table;
            //lblCurrencyDate.Text = "Currency Conversion Rate of Day: " + datepickCurrencyDay.Text + " from DataBase";
            lblCurrencyDateDB.Text = datepickCurrencyDay.Text;
        }

        private void btnGhiThongTinXuongDB_Click(object sender, EventArgs e)
        {
            int n = grdT057CurrencyRateFile.Rows.Count;
            MC_T057 data = new MC_T057();
            String[] temp = new String[1];
            int index = 0;
            int count = 0;

            string filename = txtFileName.Text;
            index = filename.LastIndexOf('\\');
            filename = filename.Substring(index + 1, filename.Length - (index + 1));
            string newname = txtNewFileName.Text;
            index = newname.LastIndexOf('\\');
            newname = newname.Substring(index + 1, newname.Length - (index + 1));

            data.filename = filename;
            data.newfilename = newname;
            data.date = lblCurrencyDateFile.Text;
            if (data.newfilename != existed_str)
            {
                for (int i = 0; i < n; i++)
                {
                    data.detail[i].sourceCurrencyCode = grdT057CurrencyRateFile.Rows[i].Cells[1].Value.ToString();
                    data.detail[i].referenceCurrencyCode = grdT057CurrencyRateFile.Rows[i].Cells[2].Value.ToString();
                    data.detail[i].sourceCurrencyExponent = grdT057CurrencyRateFile.Rows[i].Cells[3].Value.ToString();
                    data.detail[i].rateClass = grdT057CurrencyRateFile.Rows[i].Cells[4].Value.ToString();
                    data.detail[i].buyCurrencyConversionRate = Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[6].Value.ToString(), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    data.detail[i].midCurrencyConversionRate = Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    data.detail[i].sellCurrencyConversionRate = Double.Parse(grdT057CurrencyRateFile.Rows[i].Cells[8].Value.ToString(), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    if (xl.GhiT057XuongDB(data,i) == 1)
                        count++;
                }
                if (count == n && n > 0)
                {
                    MessageBox.Show("Write to DB successful!");
                }
                else
                    MessageBox.Show("Write to DB fail because this currency table existed!");
            }
            else
                MessageBox.Show("Write to DB fail because New FileName is: '" + existed_str + "'!");
        }

        private void btnReferenceCurrencyCode_Click(object sender, EventArgs e)
        {
            Form frmT057Reference = new frmMasterCard_T057_ReferenceCurrencyCode();
            frmT057Reference.ShowDialog();
        }
    }
}
