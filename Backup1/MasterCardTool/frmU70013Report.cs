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
    public partial class frmU70013Report : Form
    {
        public frmU70013Report()
        {
            InitializeComponent();
        }

        private void btnThucHien_Click(object sender, EventArgs e)
        {
            string date = dateTimePickerNgayBaoCao.Value.ToString("yyyyMMdd");

            DataTable table = GetMasterCardList(date);
            grdU70013Report.DataSource = table;
        }

        private DataTable GetMasterCardList(string date)
        {
            DataTable cardData = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = OracleDBConnection.OpenConnection("CW_DW");
                OracleCommand cmd = new OracleCommand("Get_U70013_Report", conn);

                OracleParameter reportDate = new OracleParameter("reportDate", date);
                reportDate.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(reportDate);

                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter sysCursor = new OracleParameter("sysCursor", OracleType.Cursor);
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