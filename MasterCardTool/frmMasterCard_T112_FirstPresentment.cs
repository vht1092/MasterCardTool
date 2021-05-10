using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.Data.OracleClient;
using TUONGHD;
using IPM;

namespace MasterCardTool
{
    public partial class frmMasterCard_T112_FirstPresentment : Form
    {
        string _key = "HanVien";
        List<classMessage> _messages = new List<classMessage>();
        List<classMessage> _transOfCard = new List<classMessage>();
        List<classMessage> _unknownTrans = new List<classMessage>();
        FileStream fs_input;
        BinaryReader br;
        bool endOfFile = false;
        int REPLACE_SIZE = 1012;
        string EXTENTION = ".Replaced";
        string STANDARD = "510235";
        string GOLD = "545579";       

        private void iniFieldOfDataGridView(DataGridView grid)
        {
            grid.Columns.Clear();
            grid.Columns.Add("FileName", "FileName");
            grid.Columns[0].Width = 50;
            grid.Columns.Add("PAN","PAN");
            grid.Columns[1].Width = 110;
            grid.Columns.Add("PProcessing Code","Processing Code");
            grid.Columns[2].Width = 50;
            grid.Columns.Add("Amount Transaction","Amount Transaction");
            grid.Columns[3].Width = 70;
            grid.Columns.Add("Amount Reconciliation","Amount Reconciliation");
            grid.Columns[4].Width = 70;
            grid.Columns.Add("Amount Cardholder Billing","Amount Cardholder Billing");
            grid.Columns[5].Width = 70;

            grid.Columns.Add("Currency Code Transaction", "Currency Code Transaction");// chaged position
            grid.Columns[6].Width = 35;
            grid.Columns.Add("Currency Code Reconciliation", "Currency Code Reconciliation");// chaged position
            grid.Columns[7].Width = 35;
            grid.Columns.Add("Currency Code Cardholder Billing", "Currency Code Cardholder Billing");// chaged position
            grid.Columns[8].Width = 35;
            grid.Columns.Add("Data Record", "Data Record");// chaged position
            grid.Columns[9].Width = 25;
             
            grid.Columns.Add("Reconciliation Conversion Rate","Reconciliation Conversion Rate");
            grid.Columns[10].Width = 65;
            grid.Columns.Add("Cardholder Billing Conversion Rate","Cardholder Billing Conversion Rate");
            grid.Columns[11].Width = 65;
            grid.Columns.Add("DateTime","DateTime");
            grid.Columns[12].Width = 90;
            grid.Columns.Add("Expiration Date","Expiration Date");
            grid.Columns[13].Width = 35;
            grid.Columns.Add("Point of Service Data Code","Point of Service Data Code");
            grid.Columns[14].Width = 90;
            grid.Columns.Add("Card Sequence Number","Card Sequence Number");
            grid.Columns[15].Width = 30;
            grid.Columns.Add("Function Code","Function Code");
            grid.Columns[16].Width = 30;
            grid.Columns.Add("Message Reason Code","Message Reason Code");
            grid.Columns[17].Width = 35;
            grid.Columns.Add("Card Acceptor Business Code","Card Acceptor Business Code");
            grid.Columns[18].Width = 35;
            grid.Columns.Add("Original Amounts","Original Amounts");
            grid.Columns[19].Width = 25;
            grid.Columns.Add("Acquirer Reference Data","Acquirer Reference Data");
            grid.Columns.Add("Acquiring Institution ID Code","Acquiring Institution ID Code");
            grid.Columns.Add("Forwarding Institution ID Code","Forwarding Institution ID Code");
            grid.Columns.Add("Retrieval Reference Number","Retrieval Reference Number");
            grid.Columns.Add("Approval Code","Approval Code");
            grid.Columns.Add("Service Code","Service Code");
            grid.Columns.Add("Card Acceptor Terminal ID","Card Acceptor Terminal ID");
            grid.Columns.Add("Card Acceptor ID Code","Card Acceptor ID Code");
            grid.Columns.Add("Card Acceptor Name","Card Acceptor Name");
            grid.Columns.Add("Additional Data","Additional Data");
            //grdT112.Columns.Add("Currency Code Transaction","Currency Code Transaction");
            //grdT112.Columns.Add("Currency Code Reconciliation","Currency Code Reconciliation");
            //grdT112.Columns.Add("Currency Code Cardholder Billing","Currency Code Cardholder Billing");
            grid.Columns.Add("Additional Amounts","Additional Amounts");
            grid.Columns.Add("Integrated Circuit Card (ICC)","Integrated Circuit Card (ICC)");
            grid.Columns.Add("Additional Data 2","Additional Data 2");
            grid.Columns.Add("Transaction Life Cycle ID","Transaction Life Cycle ID");
            grid.Columns.Add("Message Number","Message Number");
            //grdT112.Columns.Add("Data Record","Data Record");
            grid.Columns.Add("Action Date","Action Date");
            grid.Columns.Add("Transaction Destination Institution ID Code","Transaction Destination Institution ID Code");
            grid.Columns.Add("Transaction Originator Institution ID Code","Transaction Originator Institution ID Code");
            grid.Columns.Add("Card Issuer Reference Data","Card Issuer Reference Data");
            grid.Columns.Add("Receiving Institution ID Code","Receiving Institution ID Code");
            grid.Columns.Add("Amount, Currency Conversion Assessment","Amount, Currency Conversion Assessment");
            //grid.Columns.Add("Additional Data 3","Additional Data 3");
            //grid.Columns.Add("Additional Data 4","Additional Data 4");
            //grid.Columns.Add("Additional Data 5","Additional Data 5");
            //grid.Columns.Add("Network Data","Network Data");
            grid.Columns.Add("Currency Code TXN", "Currency Code TXN");
            grid.Columns.Add("Amount Fee TXN", "Amount  Fee TXN");
            grid.Columns.Add("Currency Code Reconciliation", "Currency Code Reconciliation");
            grid.Columns.Add("Amount Fee Reconciliation", "Amount Fee Reconciliation");
            //
            grid.Columns.Add("LOC", "LOC");      
            grid.Columns.Add("Branch", "Branch");
            grid.Columns.Add("Card Type", "Card Type");
        }

        public frmMasterCard_T112_FirstPresentment()
        {
            InitializeComponent();
            iniFieldOfDataGridView(grdT112);
            iniFieldOfDataGridView(grdTransactionsOfCard);
            iniFieldOfDataGridView(grdUnknownTrans);
        }
        
        //subfield of DE3(ProcessingCode): Cardholder “From” Account Type Code
        private string GetAccountTypeCodeDescriptionByValue(string value)
        {
            string desc = "";
            switch (value)
            {
                case "00":
                    desc = "Default Account";
                    break;
                case "10":
                    desc = "Savings Account";
                    break;
                case "20":
                    desc = "Checking Account";
                    break;
                case "30":
                    desc = "Credit Card Account";
                    break;
                case "39":
                    desc = "Corporate Credit Account";
                    break;
                case "60":
                    desc = "Stored Value Account";
                    break;
            }
            return desc;
        }

        //subfield of DE3(ProcessingCode): card holder transaction type
        private string GetCardHolderTransactionDescriptionByValue(string value)// lay description thong qua value cua processingcode
        {
            string desc = "";
            switch (value)
            {
                case "00":
                    desc = "Purchase";
                    break;
                case "01":
                    desc = "ATM Cash Withdrawal";
                    break;
                case "09":
                    desc = "Purchase with Cash Back";
                    break;
                case "12":
                    desc = "Cash Disbursement";
                    break;
                case "17":
                    desc = "Convenience Check";
                    break;
                case "18":
                    desc = "Unique Transaction";
                    break;
                case "19":
                    desc = "Fee Collection (Credit to Transaction Originator)";
                    break;
                case "20":
                    desc = "Credit (PurchaseReturn)";
                    break;
                case "28":
                    desc = "Payment Transaction";
                    break;
                case "29":
                    desc = "Fee Collection (Debit to Transaction Originator)";
                    break;
                case "30":
                    desc = "Balance Inquiry";
                    break;
                case "91":
                    desc = "PIN Unblock";
                    break;
                case "92":
                    desc = "PIN Change";
                    break;
                case "50":
                    desc = "Payment/Balance Transfer (Available Only in Collection Only Messages)";
                    break;
            }
            return desc;
        }

        private int GetExponentType(string currCode)
        {
            string[] no_exponent_list = { "174", "262", "360", "392", "410", "548", "600", "646", "704", "950", "952", "953", "974" };
            string[] two_exponent_list = { "008", "012", "032", "036", "044", "050", "051", "052", "060", "064", "068", "072", "084", "090", "096", "104", "108", "116", "124", "132", "136", "144", "152", "156", "157", "158", "170", "188", "191", "192", "203", "208", "214", "222", "230", "233", "238", "242", "270", "292", "320", "328", "332", "340", "344", "348", "352", "356", "376", "388", "398", "404", "417", "418", "422", "426", "428", "430", "434", "440", "446", "454", "458", "462", "478", "480", "484", "496", "498", "504", "516", "524", "532", "533", "554", "558", "566", "578", "586", "590", "598", "604", "608", "634", "643", "654", "678", "682", "690", "694", "702", "706", "710", "748", "752", "756", "760", "764", "776", "780", "784", "800", "807", "818", "826", "834", "840", "858", "860", "882", "886", "894", "901", "936", "937", "941", "943", "944", "946", "949", "951", "968", "969", "971", "972", "973", "975", "976", "977", "978", "980", "981", "985", "986" };
            string[] three_exponent_list = { "048", "368", "400", "414", "512", "788" };

            for (int i = 0; i < no_exponent_list.Length; i++)
            {
                if (no_exponent_list[i] == currCode)
                    return 0;
            }
            for (int i = 0; i < two_exponent_list.Length; i++)
            {
                if (two_exponent_list[i] == currCode)
                    return 2;
            }
            for (int i = 0; i < three_exponent_list.Length; i++)
            {
                if (three_exponent_list[i] == currCode)
                    return 3;
            }
            return -1;
        }


        private string FormatAmount(string amount, string currencycode)
        {
            string result = "";

            if (string.IsNullOrEmpty(amount))
                return amount;

            amount = amount.TrimStart('0');

            int exponentType = GetExponentType(currencycode);

            switch (exponentType)
            {
                case 0:
                    long a = long.Parse(amount);
                    amount = String.Format("{0:#,##0}", a);
                    break;
                case 2:
                    amount = amount.PadLeft(3, '0');
                    string exponent = amount.Substring(amount.Length - 2, 2);
                    a = int.Parse(amount.Substring(0, amount.Length - 2));
                    string interger = String.Format("{0:#,##0}", a);
                    amount = interger + "." + exponent;
                    break;
                case 3:
                    amount = amount.PadLeft(4, '0');
                    exponent = amount.Substring(amount.Length - 3, 3);
                    a = int.Parse(amount.Substring(0, amount.Length - 3));
                    interger = String.Format("{0:#,##0}", a);
                    amount = interger + "." + exponent;
                    break;
            }
            return amount;
        }


        private DataTable GetLOC_CardType_Branch2(string pan_clear)
        {

            OracleConnection conn = new OracleConnection();
            DataTable data = new DataTable();
            try
            {
                conn = OracleDBConnection.OpenConnection("CCPS_DW");
                OracleCommand cmd = new OracleCommand("Get_LOC_T112", conn);
                cmd.CommandType = CommandType.StoredProcedure;
                OracleParameter pan_p = new OracleParameter("pan_in", pan_clear);
                pan_p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pan_p);

                OracleParameter results = new OracleParameter("sys_cursor", OracleType.Cursor);
                results.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(results);

                OracleDataAdapter da = new OracleDataAdapter(cmd);
                da.Fill(data);
                conn.Close();
                return data;
            }
            catch (Exception ex)
            {
                conn.Close();
                return data;
            }
            
        }

        private DataTable GetInfor_Card(string card_clear)
        {
            DataTable cardData = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = OracleDBConnection.OpenConnection("CCPS_DW");             
                string str_get_pan = "select ecd2(" + card_clear + ",'') from dual";
                OracleCommand cmd = new OracleCommand(str_get_pan, conn);
                cmd.CommandType = CommandType.Text;             
                string pan_temp=Convert.ToString(cmd.ExecuteScalar());

                string str_get_infor = "select loc,branch,card_type from "
               + "( select PX_DW005_PAN pan,F9_DW005_LOC_ACCT loc ,FX_DW005_CRD_PGM card_type,FX_DW005_BRCH_CDE branch "
               + "from dw005 "
               + "union "
               + "select PX_DW006_OWN_PAN pan,F9_DW006_LOC_ACCT loc ,FX_DW006_CRD_PGM card_type,FX_DW006_BRCH_CDE branch "
               + "from dw006 ) "
               + "where pan='"
               + pan_temp + "'";
                string brach_temp = null;
                cmd = new OracleCommand(str_get_infor, conn);
                cmd.CommandType = CommandType.Text;
                OracleDataReader dr = cmd.ExecuteReader();
                while (dr.Read())
                {
                    brach_temp = dr["branch"].ToString();
                }
                dr.Close();

                //OracleDataAdapter da = new OracleDataAdapter(cmd);
                //string temp = da.ToString();
                //da.Fill(cardData);
                // string str_get_infor = "select loc,branch,card_type from "
                //+ "( select PX_DW005_PAN pan,F9_DW005_LOC_ACCT loc ,FX_DW005_CRD_PGM card_type,FX_DW005_BRCH_CDE branch "
                //+ "from dw005 "
                //+ "union "
                //+ "select PX_DW006_OWN_PAN pan,F9_DW006_LOC_ACCT loc ,FX_DW006_CRD_PGM card_type,FX_DW006_BRCH_CDE branch "
                //+ "from dw006 ) "
                //+ "where pan='"
                //+ str_get_pan + "'";
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return cardData;
        }
        private string GetLOC_CardType_Branch(string pan_clear)
        {
            
            OracleConnection conn = new OracleConnection();
            string str_out = null;
            try
            {
                conn = OracleDBConnection.OpenConnection("CCPS_DW");
                OracleCommand cmd = new OracleCommand("Get_LOC_T112_T", conn);

                OracleParameter pan_p = new OracleParameter("pan_in", pan_clear);
                pan_p.Direction = ParameterDirection.Input;
                cmd.Parameters.Add(pan_p);

                cmd.CommandType = CommandType.StoredProcedure;

                OracleParameter loc_p = new OracleParameter("loc_out", OracleType.NVarChar, 17);
                loc_p.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(loc_p);

                OracleParameter card_type_p = new OracleParameter("card_type_out", OracleType.NVarChar, 17);
                card_type_p.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(card_type_p);

                OracleParameter branch_p = new OracleParameter("branch_out", OracleType.NVarChar, 17);
                branch_p.Direction = ParameterDirection.Output;
                cmd.Parameters.Add(branch_p);
               
                cmd.ExecuteNonQuery();
                str_out = cmd.Parameters["loc_out"].Value.ToString() 
                + "|" + cmd.Parameters["branch_out"].Value.ToString()
                + "|" + cmd.Parameters["card_type_out"].Value.ToString();
                conn.Close();
            }
            catch (Exception ex)
            {
                conn.Close();
                return null;
            }
            return str_out;
        }

        private void HienThiTransactionOnly(DataGridView grd, List<classMessage> Messages)
        {
            try
            {
            int n = Messages.Count;
            string[] message;
            for (int i = 0; i < n; i++)
            {
                if (Messages[i] != null && string.IsNullOrEmpty(Messages[i].DataElement[3]) == false)
                //if (Messages[i] != null && Messages[i].MTI.ToString()=="1740")
                {
                    int k = 0;
                    message = new string[128];
                    message[k++] = Messages[i].DataElement[0];
                    message[k++] = Messages[i].DataElement[1];
                    message[k++] = Messages[i].DataElement[2];
                    message[k++] = FormatAmount(Messages[i].DataElement[3], Messages[i].DataElement[48]);
                    message[k++] = FormatAmount(Messages[i].DataElement[4], Messages[i].DataElement[49]);
                    message[k++] = FormatAmount(Messages[i].DataElement[5], Messages[i].DataElement[50]);

                    message[k++] = Messages[i].DataElement[48];//DE49
                    message[k++] = Messages[i].DataElement[49];//DE50
                    message[k++] = Messages[i].DataElement[50];//DE51
                    message[k++] = Messages[i].DataElement[71];//DE72

                    message[k++] = Messages[i].DataElement[8];
                    message[k++] = Messages[i].DataElement[9];

                    message[k++] = Messages[i].DataElement[11];
                    message[k++] = Messages[i].DataElement[13];
                    message[k++] = Messages[i].DataElement[21];
                    message[k++] = Messages[i].DataElement[22];
                    message[k++] = Messages[i].DataElement[23];
                    message[k++] = Messages[i].DataElement[24];
                    message[k++] = Messages[i].DataElement[25];
                    message[k++] = Messages[i].DataElement[29];
                    message[k++] = Messages[i].DataElement[30];
                    message[k++] = Messages[i].DataElement[31];
                    message[k++] = Messages[i].DataElement[32];
                    message[k++] = Messages[i].DataElement[36];
                    message[k++] = Messages[i].DataElement[37];
                    message[k++] = Messages[i].DataElement[39];
                    message[k++] = Messages[i].DataElement[40];
                    message[k++] = Messages[i].DataElement[41];
                    message[k++] = Messages[i].DataElement[42];
                    message[k++] = Messages[i].DataElement[47];
                    //message[25] = Messages[i].DataElement[48];
                    //message[26] = Messages[i].DataElement[49];
                    //message[27] = Messages[i].DataElement[50];
                    message[k++] = Messages[i].DataElement[53];
                    message[k++] = Messages[i].DataElement[54];
                    message[k++] = Messages[i].DataElement[61];
                    message[k++] = Messages[i].DataElement[62];
                    message[k++] = Messages[i].DataElement[70];
                    //message[33] = Messages[i].DataElement[71];
                    message[k++] = Messages[i].DataElement[72];
                    message[k++] = Messages[i].DataElement[92];
                    message[k++] = Messages[i].DataElement[93];
                    message[k++] = Messages[i].DataElement[94];
                    message[k++] = Messages[i].DataElement[99];
                    message[k++] = Messages[i].DataElement[110];
                    ///////hhhh them phi giao dich
                    //message[k++] = Messages[i].DataElement[122];
                    message[k++] = Messages[i].AdditionalData[150];
                    //message[k++] = Messages[i].DataElement[123];
                    ////message[k++] = FormatAmount(Messages[i].AdditionalData[151],Messages[i].AdditionalData[150]);
                    message[k++] = Messages[i].AdditionalData[151];
                    //message[k++] = Messages[i].DataElement[124];
                    message[k++] = Messages[i].AdditionalData[152];
                    //message[k++] = Messages[i].DataElement[126];
                    ////message[k++] = FormatAmount(Messages[i].AdditionalData[153], Messages[i].AdditionalData[152]);                    
                    message[k++] = Messages[i].AdditionalData[153]; 
                    
                    //22222
                    //string card_full = Messages[i].DataElement[1];
                    //string infor = null;
                    //infor=GetLOC_CardType_Branch(card_full);
                    //if (infor != null)
                    //{
                    //    message[k++] = infor.Substring(0,12);
                    //    message[k++] = infor.Substring(13,3);
                    //    message[k++] = infor.Substring(17);
                    //}
                    //////
                    //string card_full = Messages[i].DataElement[1];
                    //DataTable table = new DataTable();
                    //table.Rows.Clear();
                    //GetInfor_Card(card_full);
                    //table = GetLOC_CardType_Branch2(card_full);
                    //if (table.Rows.Count > 0)
                    //{
                    //    foreach (DataRow row in table.Rows)
                    //    {
                    //        message[k++] = row.ItemArray[0].ToString();
                    //        message[k++] = row.ItemArray[1].ToString();
                    //        message[k++] = row.ItemArray[2].ToString();
                    //    }
                    //}
                    //////////3333
                    string card_full = null;
                    card_full = Messages[i].DataElement[1];
                    OracleConnection conn = new OracleConnection();
                    conn = OracleDBConnection.OpenConnection("CCPS_DW");
                    if (card_full != null)
                    {                        
                        string str_get_pan = "select ecd2(" + card_full + ",'') from dual";
                        OracleCommand cmd = new OracleCommand(str_get_pan, conn);
                        cmd.CommandType = CommandType.Text;
                        string pan_temp = null;
                        pan_temp = Convert.ToString(cmd.ExecuteScalar());
                        if (pan_temp != null)
                        {
                            string str_get_infor = "select loc,branch,card_type from "
                           + "( select PX_DW005_PAN pan,F9_DW005_LOC_ACCT loc ,FX_DW005_CRD_PGM card_type,FX_DW005_BRCH_CDE branch "
                           + "from dw005 "
                           + "union "
                           + "select PX_DW006_OWN_PAN pan,F9_DW006_LOC_ACCT loc ,FX_DW006_CRD_PGM card_type,FX_DW006_BRCH_CDE branch "
                           + "from dw006 ) "
                           + "where pan='"
                           + pan_temp + "'";
                            string brach_temp = null;
                            cmd = new OracleCommand(str_get_infor, conn);
                            cmd.CommandType = CommandType.Text;
                            OracleDataReader dr = cmd.ExecuteReader();
                            dr.Read();
                            if (dr["loc"].ToString() != null)
                            {
                                message[k++] = dr["loc"].ToString();
                            }
                            if (dr["branch"].ToString() != null)
                            {
                                message[k++] = dr["branch"].ToString();
                            }
                            if (dr["card_type"].ToString() != null)
                            {
                                message[k++] = dr["card_type"].ToString();
                            }
                            dr.Close();
                        }
                    }
                    conn.Close();
                    //////////
                    grd.Rows.Add(message);
                }
            }
            }
            catch (Exception ex)
            {
                classMasterCardToolLogWriter.WriteLog("Error HienThiTransactionOnly(), " + ex.Message);

            }
        }

        private void HienThiAllMessages(DataGridView grd, List<classMessage> Messages)
        {
        //try
        //{
            int n = Messages.Count;
            string[] message;
            for (int i = 0; i < n; i++)
            {
                int k = 0;
                if (Messages[i] != null)
                {
                    message = new string[128];
                    message[k++] = Messages[i].DataElement[0];
                    message[k++] = Messages[i].DataElement[1];
                    message[k++] = Messages[i].DataElement[2];
                    message[k++] = FormatAmount(Messages[i].DataElement[3], Messages[i].DataElement[48]);
                    message[k++] = FormatAmount(Messages[i].DataElement[4], Messages[i].DataElement[49]);
                    message[k++] = FormatAmount(Messages[i].DataElement[5], Messages[i].DataElement[50]);

                    message[k++] = Messages[i].DataElement[48];//DE49
                    message[k++] = Messages[i].DataElement[49];//DE50
                    message[k++] = Messages[i].DataElement[50];//DE51
                    message[k++] = Messages[i].DataElement[71];//DE72

                    message[k++] = Messages[i].DataElement[8];
                    message[k++] = Messages[i].DataElement[9];

                    message[k++] = Messages[i].DataElement[11];
                    message[k++] = Messages[i].DataElement[13];
                    message[k++] = Messages[i].DataElement[21];
                    message[k++] = Messages[i].DataElement[22];
                    message[k++] = Messages[i].DataElement[23];
                    message[k++] = Messages[i].DataElement[24];
                    message[k++] = Messages[i].DataElement[25];
                    message[k++] = Messages[i].DataElement[29];
                    message[k++] = Messages[i].DataElement[30];
                    message[k++] = Messages[i].DataElement[31];
                    message[k++] = Messages[i].DataElement[32];
                    message[k++] = Messages[i].DataElement[36];
                    message[k++] = Messages[i].DataElement[37];
                    message[k++] = Messages[i].DataElement[39];
                    message[k++] = Messages[i].DataElement[40];
                    message[k++] = Messages[i].DataElement[41];
                    message[k++] = Messages[i].DataElement[42];
                    message[k++] = Messages[i].DataElement[47];
                    //message[25] = Messages[i].DataElement[48];
                    //message[26] = Messages[i].DataElement[49];
                    //message[27] = Messages[i].DataElement[50];
                    message[k++] = Messages[i].DataElement[53];
                    message[k++] = Messages[i].DataElement[54];
                    message[k++] = Messages[i].DataElement[61];
                    message[k++] = Messages[i].DataElement[62];
                    message[k++] = Messages[i].DataElement[70];
                    //message[33] = Messages[i].DataElement[71];
                    message[k++] = Messages[i].DataElement[72];
                    message[k++] = Messages[i].DataElement[92];
                    message[k++] = Messages[i].DataElement[93];
                    message[k++] = Messages[i].DataElement[94];
                    message[k++] = Messages[i].DataElement[99];
                    message[k++] = Messages[i].DataElement[110];

                    ///////hhhh them phi giao dich
                    //message[k++] = Messages[i].DataElement[122];
                    message[k++] = Messages[i].AdditionalData[150];
                    //message[k++] = Messages[i].DataElement[123];
                    ////message[k++] = FormatAmount(Messages[i].AdditionalData[151],Messages[i].AdditionalData[150]);
                    message[k++] = Messages[i].AdditionalData[151];
                    //message[k++] = Messages[i].DataElement[124];
                    message[k++] = Messages[i].AdditionalData[152];
                    //message[k++] = Messages[i].DataElement[126];
                    ////message[k++] = FormatAmount(Messages[i].AdditionalData[153], Messages[i].AdditionalData[152]);                    
                    message[k++] = Messages[i].AdditionalData[153];
                    //22222
                    //string card_full = Messages[i].DataElement[1];
                    //string infor = null;
                    //infor=GetLOC_CardType_Branch(card_full);
                    //if (infor != null)
                    //{
                    //    message[k++] = infor.Substring(0,12);
                    //    message[k++] = infor.Substring(13,3);
                    //    message[k++] = infor.Substring(17);
                    //}
                    //////
                    //string card_full = Messages[i].DataElement[1];
                    //DataTable table = new DataTable();
                    //table.Rows.Clear();
                    //GetInfor_Card(card_full);
                    //table = GetLOC_CardType_Branch2(card_full);
                    //if (table.Rows.Count > 0)
                    //{
                    //    foreach (DataRow row in table.Rows)
                    //    {
                    //        message[k++] = row.ItemArray[0].ToString();
                    //        message[k++] = row.ItemArray[1].ToString();
                    //        message[k++] = row.ItemArray[2].ToString();
                    //    }
                    //}
                    ////////
                    //////////3333
                    string card_full = null;
                    card_full = Messages[i].DataElement[1];
                    OracleConnection conn = new OracleConnection();
                    conn = OracleDBConnection.OpenConnection("CCPS_DW");
                    if (card_full != null)
                    {
                        string str_get_pan = "select ecd2(" + card_full + ",'') from dual";
                        OracleCommand cmd = new OracleCommand(str_get_pan, conn);
                        cmd.CommandType = CommandType.Text;
                        string pan_temp = null;
                        pan_temp = Convert.ToString(cmd.ExecuteScalar());
                        if (pan_temp != null)
                        {
                            string str_get_infor = "select loc,branch,card_type from "
                           + "( select PX_DW005_PAN pan,F9_DW005_LOC_ACCT loc ,FX_DW005_CRD_PGM card_type,FX_DW005_BRCH_CDE branch "
                           + "from dw005 "
                           + "union "
                           + "select PX_DW006_OWN_PAN pan,F9_DW006_LOC_ACCT loc ,FX_DW006_CRD_PGM card_type,FX_DW006_BRCH_CDE branch "
                           + "from dw006 ) "
                           + "where pan='"
                           + pan_temp + "'";
                            string brach_temp = null;
                            cmd = new OracleCommand(str_get_infor, conn);
                            cmd.CommandType = CommandType.Text;
                            OracleDataReader dr = cmd.ExecuteReader();
                            dr.Read();
                            if (dr["loc"].ToString() != null)
                            {
                                message[k++] = dr["loc"].ToString();
                            }
                            if (dr["branch"].ToString() != null)
                            {
                                message[k++] = dr["branch"].ToString();
                            }
                            if (dr["card_type"].ToString() != null)
                            {
                                message[k++] = dr["card_type"].ToString();
                            }
                            dr.Close();
                        }
                    }
                    conn.Close();
                    //////////
                    ////////
                    grd.Rows.Add(message);
                }
            }
        //}
        //catch (Exception ex)
        //{
        //    classMasterCardToolLogWriter.WriteLog("Error GetKichHoatThe()at DataAccess, " + ex.Message);

        //}
        }

        private void btnBrowserT112_Click(object sender, EventArgs e)
        {
            string rootPath = Application.StartupPath;
            if (rdoReplaceAndRead.Checked == true)
                openFileDialogT112.Filter = " Files(TT112*.001)|TT112*.001";
            else // rdoReadOnly is checked
                openFileDialogT112.Filter = " Files(TT112*.Replaced)|TT112*.Replaced";

            string fileName = "";
            int n = 0;
            
            if (openFileDialogT112.ShowDialog() == DialogResult.OK)
            {
                grdT112.Rows.Clear();
                _messages.Clear();

                n = openFileDialogT112.FileNames.Length;
                for (int i = 0; i < n; i++)
                {
                    if(openFileDialogT112.FileNames[i].IndexOf("TT112") != -1)
                    {
                        fileName = openFileDialogT112.FileNames[i];
                        txtFilePathT112.Text = fileName;
                        //IncomingFile parser = new IncomingFile();
                        IncommingFile parser = new IncommingFile();
                        List<classMessage> messages = parser.ParseMessages(fileName, rootPath);
                        //classMessage[] messages = parser.ParseMessages(fileName, rootPath);
                        _messages.AddRange(messages);
                    }
                }
                if (rdoTransactionOnly.Checked == true)
                    HienThiTransactionOnly(grdT112, _messages);
                else
                    HienThiAllMessages(grdT112, _messages);
            }
        }

        private void btnGetTransaction_Click(object sender, EventArgs e)
        {
            //hhhh
            //if(string.IsNullOrEmpty(txtPAN.Text)||(txtPAN.Text.IndexOf(STANDARD)<0&&txtPAN.Text.IndexOf(GOLD)<0))
            //{
            //    MessageBox.Show("The PAN must begin " + STANDARD + " or " + GOLD);
            //    return;
            //}
            grdTransactionsOfCard.Rows.Clear();
            _transOfCard.Clear();
            foreach (classMessage message in _messages)
            {
                if (message != null && message.DataElement[1] == txtPAN.Text)
                    _transOfCard.Add(message);
            }
            if (_transOfCard.Count > 0)
            {
                if (rdoTransactionOnly.Checked == true)
                    HienThiTransactionOnly(grdTransactionsOfCard, _transOfCard);
                else
                    HienThiAllMessages(grdTransactionsOfCard, _transOfCard);
            }
            else
                MessageBox.Show("There is no transaction of this card");
        }

       
        private DataTable GetMasterCardList()
        {
            DataTable cardData = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = OracleDBConnection.OpenConnection("CW_DW");
                //string today = DateTime.Today.ToString("yyyyMMdd");
                string str = "(select "
                            + " ded2(px_dw005_pan,'') PAN "
                            + " from dw005 "
                            + " where fx_dw005_crd_brn = 'MC') "
                            + " union "
                            + "(select "
                            + " ded2(px_dw006_own_pan,'') PAN "
                            + " from dw006 "
                            + "where fx_dw006_crd_brn = 'MC') ";
                OracleCommand cmd = new OracleCommand(str, conn);
                cmd.CommandType = CommandType.Text;
                cmd.ExecuteNonQuery();
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

        private void btnFindUnknownCard_Click(object sender, EventArgs e)
        {
            DataTable MCList = GetMasterCardList();
            grdUnknownTrans.Rows.Clear();
            _unknownTrans.Clear();
            //bool exist_flag = false;
            int n = MCList.Rows.Count;
            int i = 0;
            foreach (classMessage tran in _messages)
            {
                for (i = 0; i < n; i++)
                {
                    //string s = MCList.Rows[i].ItemArray[0].ToString();
                    //string s1 = tran.PAN;
                    if (string.IsNullOrEmpty(tran.DataElement[1]) || tran.DataElement[1] == MCList.Rows[i].ItemArray[0].ToString())
                    {
                        break;
                    }
                }
                if (i == n)
                    _unknownTrans.Add(tran);
            }
            if (_unknownTrans.Count > 0)
            {
                if (rdoTransactionOnly.Checked == true)
                    HienThiTransactionOnly(grdUnknownTrans, _unknownTrans);
                else
                    HienThiAllMessages(grdUnknownTrans, _unknownTrans);
            }
            else
                MessageBox.Show("There is no Unknown Transaction in files");
        }

        private void txtFilePathT112_TextChanged(object sender, EventArgs e)
        {

        }

        private void rdoTransactionOnly_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void rdoAllMessages_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}