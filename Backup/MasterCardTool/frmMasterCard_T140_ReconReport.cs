using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace MasterCardTool
{
    public partial class frmMasterCard_T140_ReconReport : Form
    {
        XulyNghiepVu xl = new XulyNghiepVu();

        public frmMasterCard_T140_ReconReport()
        {
            InitializeComponent();
            xl = new XulyNghiepVu();
        }
        char[] charSeparators_flash = new char[] { '/' };
        char[] charSeparators_space = new char[] { ' ' };
        string existed_str = "File existed";

        private void btnChonFile_Click(object sender, EventArgs e)
        {
            grdT140ReconReport.Rows.Clear();
            openDlgChonFileT140.Filter = "Report Files(TT140*.001)|TT140*.001|All Files(*.*)|*.*";
            int n = 0;

            string filename = "";
            string filenameresult = "";
            if (openDlgChonFileT140.ShowDialog() == DialogResult.OK)
            {
                MC_T140 t140_data = new MC_T140();
                n = openDlgChonFileT140.FileNames.Length;
                txtNumOfFile.Text = n.ToString();
                for (int i = 0; i < n; i++)
                {
                    if(openDlgChonFileT140.FileNames[i].IndexOf("TT140") != -1)
                    {
                        filename = openDlgChonFileT140.FileNames[i];
                        t140_data = XuLyFileT140(filename);
                        filenameresult = LuuFileVoiTenMoi(t140_data);
                        HienThiLenManHinh(filenameresult, t140_data);
                    }
                }
            }
            txtUSDTotal1.Text = String.Format("{0:#,##0.##}", TinhTongSoTien(grdT140ReconReport, 6, 7));
            txtVNDTotal1.Text = String.Format("{0:#,##0.##}", TinhTongSoTien(grdT140ReconReport, 6, 8));
        }
        private string LuuFileVoiTenMoi(MC_T140 t140_data)
        {
            try
            {
                File.Copy(t140_data.filename, t140_data.newfilename, checkOverrideNewFileName.Checked);
            }
            catch
            {
                t140_data.newfilename = existed_str;
            }
            return t140_data.newfilename;
        }
        private Double TinhTongSoTien(DataGridView grdT140, int cycleindex, int amountindex)
        {
            int n = grdT140.Rows.Count;
            Double Total = 0;
            for (int i = 0; i < n; i++)
            {
                if (grdT140.Rows[i].Cells[cycleindex].Value.ToString() == "006")
                    Total += Double.Parse(grdT140.Rows[i].Cells[amountindex].Value.ToString());
            }
            return Total;
        }
        private void HienThiLenManHinh(string filenameresult, MC_T140 data)
        {
            string stt = "" + (grdT140ReconReport.Rows.Count + 1);
            string usd_amount = String.Format("{0:#,##0.##}", data.USDAmount);
            string vnd_amount = String.Format("{0:#,##0.##}", data.VNDAmount);
            if (filenameresult != existed_str)
            {
                int index = filenameresult.LastIndexOf('\\');
                filenameresult = filenameresult.Substring(index + 1, filenameresult.Length - (index + 1));
            }
            string[] row = new string[] { stt, data.filename, "", filenameresult, data.runDate, data.clearingDate, data.clearingCycle, usd_amount, vnd_amount };
            grdT140ReconReport.Rows.Add(row);
            grdT140ReconReport.Rows[grdT140ReconReport.Rows.Count-1].Cells[1].Style.ForeColor = Color.Blue;//set color for field 'filepath' to mark this field is the link
        }
        private MC_T140 XuLyFileT140(string filename)
        {
            MC_T140 t140_data = new MC_T140();
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader r = new StreamReader(fs, Encoding.UTF8);
            String[] temp = new String[1];

            String str = r.ReadLine().Trim();
            if (str.Contains("RUN DATE:"))
            {
                temp = str.Split(charSeparators_space, StringSplitOptions.RemoveEmptyEntries);
                string rundate = temp[temp.Length - 1];
                t140_data.runDate = rundate.Substring(3, 2) + "/" + rundate.Substring(0, 2) + "/" + rundate.Substring(6, 2);
            }
            str = r.ReadLine().Trim();
            if (str.Contains("CLEARING CYCLE"))
            {
                temp = str.Split(charSeparators_space, StringSplitOptions.RemoveEmptyEntries);
                t140_data.clearingCycle = temp[2];
            }
            str = r.ReadLine().Trim();
            if (str.Length == 10)
            {
                string clearingtime = str.Substring(8, 2) + "/" + str.Substring(5, 2) + "/" + str.Substring(0, 4);
                t140_data.clearingDate = clearingtime;
            }
            while (str != null)
            {
                if (str.Contains("CLEARING DAY TOTAL"))
                {
                    for (int j = 0; j < 8; j++)
                        str = r.ReadLine();
                    temp = str.Split(charSeparators_space, StringSplitOptions.RemoveEmptyEntries);
                    if (temp[0] == "704-VND")
                        t140_data.VNDAmount = Double.Parse(temp[1], System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    else
                        if (temp[0] == "840-USD")
                            t140_data.USDAmount = Double.Parse(temp[1], System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    str = r.ReadLine();
                    temp = str.Split(charSeparators_space, StringSplitOptions.RemoveEmptyEntries);
                    if (temp[0] == "704-VND")
                        t140_data.VNDAmount = Double.Parse(temp[1], System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    else
                        if (temp[0] == "840-USD")
                            t140_data.USDAmount = Double.Parse(temp[1], System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    //t140_data.currencyCode = temp[0];
                    //t140_data.currencyAmount = Double.Parse(temp[1], System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    break;
                }
                str = r.ReadLine();
            }
            int index = filename.LastIndexOf('\\');
            temp = t140_data.clearingDate.Split(charSeparators_flash);
            string clearingdate = temp[1] + temp[0] + temp[2];
            string newname = filename.Substring(0, index) + "\\T140_" + clearingdate + "_" + t140_data.clearingCycle + ".report";
            t140_data.filename = filename;
            t140_data.newfilename = newname;

            r.Close();
            fs.Close();
            return t140_data;
        }

        private void btnGhiThongTinXuongDB_Click(object sender, EventArgs e)
        {
            int n = grdT140ReconReport.Rows.Count;
            MC_T140 data = new MC_T140();
            String[] temp = new String[1];
            int index = 0;
            string filename = "";
            int count = 0;
            string newname = "";

            for (int i = 0; i < n; i++)
            {
                newname = grdT140ReconReport.Rows[i].Cells[3].Value.ToString();
                if (newname != existed_str)
                {
                    filename = grdT140ReconReport.Rows[i].Cells[1].Value.ToString();
                    index = filename.LastIndexOf('\\');
                    filename = filename.Substring(index + 1, filename.Length - (index + 1));
                    data.filename = filename;
                    data.newfilename = newname;
                    data.runDate = grdT140ReconReport.Rows[i].Cells[4].Value.ToString();
                    data.clearingDate = grdT140ReconReport.Rows[i].Cells[5].Value.ToString();
                    data.clearingCycle = grdT140ReconReport.Rows[i].Cells[6].Value.ToString();
                    //data.currencyCode = grdT140ReconReport.Rows[i].Cells[7].Value.ToString();
                    data.USDAmount = Double.Parse(grdT140ReconReport.Rows[i].Cells[7].Value.ToString(), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    data.VNDAmount = Double.Parse(grdT140ReconReport.Rows[i].Cells[8].Value.ToString(), System.Globalization.NumberStyles.AllowThousands | System.Globalization.NumberStyles.AllowDecimalPoint);
                    if (xl.GhiT140XuongDB(data) == 1)
                    {
                        count++;
                        grdT140ReconReport.Rows[i].Cells[2].Value = "OK";
                    }
                    else
                        grdT140ReconReport.Rows[i].Cells[2].Value = "Exsited";
                }
                else
                    grdT140ReconReport.Rows[i].Cells[2].Value = "Fail";
            }

            MessageBox.Show("Information of " + count + " files be inserted to database!");
        }

        private void HienThiKetQuaTimKiem(DataTable data)
        {
            int n = data.Rows.Count;
            grdT140KetQuaTimKiem.DataSource = data;
            //set color for field FileName to mark this field is the link
            for (int i = 0; i < grdT140KetQuaTimKiem.Rows.Count; i++)
                grdT140KetQuaTimKiem.Rows[i].Cells[0].Style.ForeColor = Color.Blue;
        }

        private void btnSearchData_Click(object sender, EventArgs e)
        {
            DataTable data = xl.TimT140GCSMTheoNgayClearing(datepickFromDate.Text, datepickToDate.Text);
            HienThiKetQuaTimKiem(data);
            txtUSDTotal2.Text = String.Format("{0:#,##0.##}", TinhTongSoTien(grdT140KetQuaTimKiem, 4, 5));
            txtVNDTotal2.Text = String.Format("{0:#,##0.##}", TinhTongSoTien(grdT140KetQuaTimKiem, 4, 6));
            txtSoLuongRow.Text = data.Rows.Count.ToString();
        }

        private void checkOverrideNewFileName_MouseClick(object sender, MouseEventArgs e)
        {
            if (checkOverrideNewFileName.Checked == true)
            {
                DialogResult dialogResult = MessageBox.Show("Are you sure overwrite the newfilename if that existed?", "Warning!", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.No)
                    checkOverrideNewFileName.Checked = false;
                else
                    checkOverrideNewFileName.Checked = true;
            }
        }

        private void grdT140ReconReport_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = Int16.Parse(e.RowIndex.ToString());
            int column = Int16.Parse(e.ColumnIndex.ToString());
            if (column == 1)
            {
                string path = grdT140ReconReport.Rows[row].Cells[column].Value.ToString();
                if (File.Exists(path))
                    Process.Start(path);
                else
                    MessageBox.Show("\'" + path + "\'" + " not exist!", "Warning!");
            }
        }

        private void grdT140KetQuaTimKiem_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int row = Int16.Parse(e.RowIndex.ToString());
            int column = Int16.Parse(e.ColumnIndex.ToString());
            if (column == 0)
            {
                string filename = grdT140KetQuaTimKiem.Rows[row].Cells[column].Value.ToString();
                //string path = "C:\\MCONLINE\\MFE\\DOWNLOAD\\T140\\" + filename;
                string path = txtFilePath.Text + "\\" + filename;
                if (File.Exists(path))
                    Process.Start(path);
                else
                    MessageBox.Show("\'" + path + "\'" + " not exist!", "Warning!");
            }
        }

        private void ckbEditFilePath_Click(object sender, EventArgs e)
        {
            if (ckbEditFilePath.Checked == true)
                txtFilePath.ReadOnly = false;
            else
                txtFilePath.ReadOnly = true;
        }
    }
}