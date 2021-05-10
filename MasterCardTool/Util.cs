using System;
using System.Data;
using System.Data.SqlClient;
using System.Configuration;
using System.Collections.Generic;
using System.Text;
using Microsoft.Office.Interop.Excel;
using TUONGHD;

//namespace DoiChieuGDATM_IPC
namespace DoiChieuGiaoDich_IPC
{
    public class Util
    {
        string _key = "HanVien";

        public static string GetMD5Hash(string input)
        {
            System.Security.Cryptography.MD5CryptoServiceProvider x = new System.Security.Cryptography.MD5CryptoServiceProvider();
            byte[] bs = System.Text.Encoding.UTF8.GetBytes(input);
            bs = x.ComputeHash(bs);
            System.Text.StringBuilder s = new System.Text.StringBuilder();
            foreach (byte b in bs)
            {
                s.Append(b.ToString("x2").ToLower());
            }
            string password = s.ToString();
            return password;
        }

        public static string FormatConversionRate(string rate)
        {
            rate = rate.Substring(0, 1) + "000" + rate.Substring(1, 7);
            int numberOfDecimalPlace = int.Parse(rate.Substring(0, 1));
            string exponent = rate.Substring(rate.Length - numberOfDecimalPlace, numberOfDecimalPlace);
            int a = int.Parse(rate.Substring(1, (rate.Length - 1) - numberOfDecimalPlace));
            string interger = String.Format("{0:#,##0}", a);
            string result = interger;
            if (exponent != "")
                result = interger + "." + exponent;
            return result;
        }

        public void ExportToExcelNoColumn(System.Data.DataTable table)
        {
            try
            {
                ApplicationClass excel = new ApplicationClass();

                excel.Application.Workbooks.Add(true);

                int ColumnIndex = 0;
                int rowIndex = -1;
                foreach (DataRow row in table.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0; foreach (DataColumn col in table.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row[col.ColumnName];
                    }
                }

                excel.Visible = true;

                _Worksheet worksheet = (_Worksheet)excel.ActiveSheet;

                worksheet.Activate();
            }
            catch (Exception exml)
            {
            }
        }
        
        public void ExportToExcelWithColumn(System.Data.DataTable table)
        {
            try
            {
                ApplicationClass excel = new ApplicationClass();

                excel.Application.Workbooks.Add(true);
                
                int ColumnIndex = 0;
                foreach (System.Data.DataColumn col in table.Columns)
                {
                    ColumnIndex++;
                    excel.Cells[1, ColumnIndex] = col.ColumnName;
                }
                int rowIndex = 0;
                foreach (DataRow row in table.Rows)
                {
                    rowIndex++;
                    ColumnIndex = 0; foreach (DataColumn col in table.Columns)
                    {
                        ColumnIndex++;
                        excel.Cells[rowIndex + 1, ColumnIndex] = row[col.ColumnName];
                    }
                }

                excel.Visible = true;

                _Worksheet worksheet = (_Worksheet)excel.ActiveSheet;

                worksheet.Activate();
            }
            catch (Exception exml)
            {
            }
        }
        public void ThucThiProc(string ProcName,string ServerName)
        {
            string strConn = System.Configuration.ConfigurationManager.AppSettings[ServerName].ToString();
            strConn = EnCode.DeCodeToString(strConn, _key);
            SqlConnection conn = new SqlConnection(strConn);
            conn.Open();
            SqlCommand cmd = new SqlCommand(ProcName, conn);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.ExecuteNonQuery();
            cmd.Dispose();
            conn.Close();
        }
    }
}
