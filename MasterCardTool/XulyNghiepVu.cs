using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Data.OracleClient;
using TUONGHD;

namespace MasterCardTool
{
    public class XulyNghiepVu
    {

        string _key = "HanVien";

        public DataTable GetCurrencyCodeList()
        {
            DataTable data = new DataTable();
            //DateTime date = DateTime.ParseExact(Currencydate, "dd'/'MM'/'yyyy", null);

            //DateTime toDate = DateTime.ParseExact(denngay, "dd'/'MM'/'yyyy", null);

            string sqlConnStr = System.Configuration.ConfigurationManager.AppSettings["SQLServerMasterCard"];
            sqlConnStr = EnCode.DeCodeToString(sqlConnStr, _key);
            SqlConnection sqlConn = new SqlConnection(sqlConnStr);
            sqlConn.Open();
            DataTable ipcData = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("GET_T057_CURRENCY_CODE_LIST", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            //sqlCmd.Parameters.Add(new SqlParameter("@RATEDATE", date));
            //sqlCmd.Parameters.Add(new SqlParameter("@TOCLEARINGDATE", toDate));
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(data);
            sqlConn.Close();
            return data;
        }

        public DataTable TimT140GCSMTheoNgayClearing(string tungay, string denngay)
        {
            DataTable data = new DataTable();
            DateTime fromDate = DateTime.ParseExact(tungay, "dd'/'MM'/'yyyy", null);
            DateTime toDate = DateTime.ParseExact(denngay, "dd'/'MM'/'yyyy", null);

            string sqlConnStr = System.Configuration.ConfigurationManager.AppSettings["SQLServerMasterCard"];
            sqlConnStr = EnCode.DeCodeToString(sqlConnStr, _key);
            SqlConnection sqlConn = new SqlConnection(sqlConnStr);
            sqlConn.Open();
            DataTable ipcData = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("SEARCH_T140_GCMS_REPORT_BY_CLEARINGDATE", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@FROMCLEARINGDATE", fromDate));
            sqlCmd.Parameters.Add(new SqlParameter("@TOCLEARINGDATE", toDate));
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(data);
            sqlConn.Close();
            return data;
        }

        public DataTable LoadCurrencyRateFromDB(string Currencydate)
        {
            DataTable data = new DataTable();
            DateTime date = DateTime .ParseExact(Currencydate, "dd'/'MM'/'yyyy", null);
            
            //DateTime toDate = DateTime.ParseExact(denngay, "dd'/'MM'/'yyyy", null);

            string sqlConnStr = System.Configuration.ConfigurationManager.AppSettings["SQLServerMasterCard"];
            sqlConnStr = EnCode.DeCodeToString(sqlConnStr, _key);
            SqlConnection sqlConn = new SqlConnection(sqlConnStr);
            sqlConn.Open();
            DataTable ipcData = new DataTable();
            SqlCommand sqlCmd = new SqlCommand("SEARCH_T057_CURRENCY_CONVERSION_RATE", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@RATEDATE", date));
            //sqlCmd.Parameters.Add(new SqlParameter("@TOCLEARINGDATE", toDate));
            SqlDataAdapter sqlDa = new SqlDataAdapter(sqlCmd);
            sqlDa.Fill(data);
            sqlConn.Close();
            return data;
        }

        public int GhiT140XuongDB(MC_T140 data)
        {
            DateTime runDate = DateTime.ParseExact(data.runDate, "dd'/'MM'/'yy", null);
            DateTime clearingDate = DateTime.ParseExact(data.clearingDate, "dd'/'MM'/'yyyy", null);
            int numofinserted = -1;

            string sqlConnStr = System.Configuration.ConfigurationManager.AppSettings["SQLServerMasterCard"];
            sqlConnStr = EnCode.DeCodeToString(sqlConnStr, _key);
            SqlConnection sqlConn = new SqlConnection(sqlConnStr);
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("INSERT_T140_GCMS_REPORT", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@FILENAME", data.filename));
            sqlCmd.Parameters.Add(new SqlParameter("@NEWFILENAME", data.newfilename));
            sqlCmd.Parameters.Add(new SqlParameter("@RUNDATE", runDate));
            sqlCmd.Parameters.Add(new SqlParameter("@CLEARINGDATE", clearingDate));
            sqlCmd.Parameters.Add(new SqlParameter("@CYCLE", data.clearingCycle));
            //sqlCmd.Parameters.Add(new SqlParameter("@CURRENCYCODE", data.currencyCode));
            sqlCmd.Parameters.Add(new SqlParameter("@USDAMOUNT", data.USDAmount));
            sqlCmd.Parameters.Add(new SqlParameter("@VNDAMOUNT", data.VNDAmount));

            try{
                numofinserted = sqlCmd.ExecuteNonQuery();
            }
            catch{}

            sqlConn.Close();
            //dtIPC = ICMSDataWithOrderIdx(ipcData);
            //return dtIPC;
            return numofinserted;
        }

        public int GhiT057XuongDB(MC_T057 data, int i)
        {
            //string date = data.date.Substring(0, 2) + "/" + data.date.Substring(2, 2) + "/" + data.date.Substring(4, 4); 
            DateTime currencyDate = DateTime.ParseExact(data.date, "dd'/'MM'/'yyyy", null);
            //DateTime clearingDate = DateTime.ParseExact(data.clearingDate, "dd'/'MM'/'yy", null);
            int numofinserted = -1;

            string sqlConnStr = System.Configuration.ConfigurationManager.AppSettings["SQLServerMasterCard"];
            sqlConnStr = EnCode.DeCodeToString(sqlConnStr, _key);
            SqlConnection sqlConn = new SqlConnection(sqlConnStr);
            sqlConn.Open();
            SqlCommand sqlCmd = new SqlCommand("INSERT_T057_CURRENCY_CONVERSION_RATE", sqlConn);
            sqlCmd.CommandType = CommandType.StoredProcedure;
            sqlCmd.Parameters.Add(new SqlParameter("@FILENAME", data.filename));
            sqlCmd.Parameters.Add(new SqlParameter("@NEWFILENAME", data.newfilename));
            sqlCmd.Parameters.Add(new SqlParameter("@RATEDATE", currencyDate));
            sqlCmd.Parameters.Add(new SqlParameter("@SOURCECODE", data.detail[i].sourceCurrencyCode));
            sqlCmd.Parameters.Add(new SqlParameter("@REFERENCECODE", data.detail[i].referenceCurrencyCode));
            sqlCmd.Parameters.Add(new SqlParameter("@CURRENCYEXPONENT", data.detail[i].sourceCurrencyExponent));
            sqlCmd.Parameters.Add(new SqlParameter("@RATECLASS", data.detail[i].rateClass));
            sqlCmd.Parameters.Add(new SqlParameter("@BUYRATE", data.detail[i].buyCurrencyConversionRate));
            sqlCmd.Parameters.Add(new SqlParameter("@MIDRATE", data.detail[i].midCurrencyConversionRate));
            sqlCmd.Parameters.Add(new SqlParameter("@SELLRATE", data.detail[i].sellCurrencyConversionRate));

            try
            {
                numofinserted = sqlCmd.ExecuteNonQuery();
            }
            catch { }

            sqlConn.Close();
            return numofinserted;
        }


       
    }
}
