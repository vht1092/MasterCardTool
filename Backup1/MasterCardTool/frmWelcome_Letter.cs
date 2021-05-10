using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;

namespace MasterCardTool
{
    public partial class frmWelcome_Letter : Form
    {
        public frmWelcome_Letter()
        {
            InitializeComponent();
        }

        private void btnGetData_Click(object sender, EventArgs e)
        {
            string fromDate = dateTimePickerFromDate.Value.ToString("yyyyMMdd");
            string toDate = dateTimePickerToDate.Value.ToString("yyyyMMdd");

            DataTable table = GetWelcomeLetterList(fromDate, toDate);
            grdWelcomeLetter.DataSource = table;
        }

        private DataTable GetWelcomeLetterList(string fromDate, string toDate)
        {
            DataTable cardData = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = OracleDBConnection.OpenConnection("CW_IM");
                OracleCommand cmd = new OracleCommand("Get_Welcome_Letter", conn);

                OracleParameter p_fromDate = new OracleParameter("from_date", fromDate);
                p_fromDate.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_fromDate);

                OracleParameter p_toDate = new OracleParameter("to_date", toDate);
                p_toDate.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(p_toDate);

                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter sysCursor = new OracleParameter("sys_cursor", OracleType.Cursor);
                sysCursor.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(sysCursor);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(cardData);
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return cardData;
        }
    }
}