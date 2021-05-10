using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Data.OracleClient;
using System.IO;

namespace MasterCardTool
{
    public partial class frmCheckFilterOverDraftsAccount : Form
    {
        public frmCheckFilterOverDraftsAccount()
        {
            InitializeComponent();
        }

        private void btnBrowser_Click(object sender, EventArgs e)
        {
            if (openFileDialogRequestFile.ShowDialog() == DialogResult.OK)
            {
                txtRequestFile.Text = openFileDialogRequestFile.FileName;
            }
        }

        private void CheckAndFilterOverDraftsAccount(string filename)
        {
            classInstructionRequest instruction = new classInstructionRequest();
            instruction.ReadInstructionFile(filename);
            File.Move(filename,filename.Substring(0,filename.LastIndexOf(".dat")) + "_bk_" + DateTime.Now.ToString("hhmmss_tt") + ".dat");
            DataTable overDraftsAccountList = GetOverDraftsAccountdList();
            AddLineToNewInstructionFile(instruction, overDraftsAccountList, filename);
            //ShowDataGridView(instruction, grdRequestValidAccount);
        }

        private string CreateFailInstructionFileName(string filename)
        {
            int index = filename.LastIndexOf(".dat");
            string newName = filename.Substring(0, index) + "_FailAccount_" + DateTime.Now.ToString("hhmmss_tt") + ".dat";
            return newName;
        }

        private bool CheckOverDraftsAccount(string account, long amount, DataTable list)
        {
            string acct = "";
            long balance = 0;
            foreach(DataRow row in list.Rows)
            {
                acct = row.ItemArray[0].ToString();
                //if(account == "0710100619560002")
                //{
                //    int a = 1;
                //}
                //if (acct == "0710100619560002")
                //{
                //    int b = 1;
                //}
                balance = long.Parse(row.ItemArray[1].ToString());
                if (acct == account)
                {
                    if (balance < amount)
                        return false;
                    return true;
                }
            }
            return true;
        }

        private string CreateResponseRecord(string request)
        {
            string response = "";
            string amuont = request.Substring(189,18);
            response = "01" + "RBS" + request.Substring(5, 64) + request.Substring(189, 21) + amuont + request.Substring(210, 16) + "33";
            return response;
        }



        private void AddLineToNewInstructionFile(classInstructionRequest instruction, DataTable list, string filename)
        {
            grdRequestValidAccount.Rows.Clear();
            grdRequestInvalidAccount.Rows.Clear();
            string failName = CreateFailInstructionFileName(filename);
            FileStream fs = new FileStream(filename, FileMode.Create);
            StreamWriter w = new StreamWriter(fs, Encoding.ASCII);
            FileStream fs1 = new FileStream(failName, FileMode.Create);
            StreamWriter w1 = new StreamWriter(fs1, Encoding.ASCII);
            FileStream fs2 = new FileStream(failName.Replace('Q','P'), FileMode.Create);
            StreamWriter w2 = new StreamWriter(fs2, Encoding.ASCII);

            w.Write("00" + instruction.fileProcessDate);
            w.Write('\n');
            w1.Write("00" + instruction.fileProcessDate);
            w1.Write('\n');
            int count = 0;
            int count1 = 0;
            for (int i = 0; i < instruction.numberOfRecord; i++)
            {
                if (CheckOverDraftsAccount(instruction.account[i], long.Parse(instruction.amount[i]), list) == true)
                {
                    w.Write(instruction.recordContent[i]);
                    w.Write('\n');
                    count++;
                    AddRowToGridView(instruction, grdRequestValidAccount, i);
                }
                else
                {
                    w1.Write(instruction.recordContent[i]);
                    w1.Write('\n');
                    w2.WriteLine(CreateResponseRecord(instruction.recordContent[i]));
                    count1++;
                    AddRowToGridView(instruction, grdRequestInvalidAccount, i);
                }
            }
            w.Write("99" + instruction.fileProcessDate + count.ToString().PadLeft(12, '0'));
            w.Write('\n');
            w1.Write("99" + instruction.fileProcessDate + count1.ToString().PadLeft(12, '0'));
            w1.Write('\n');

            w.Flush();
            w.Close();
            fs.Close();
            w1.Flush();
            w1.Close();
            fs1.Close();
            w2.Flush();
            w2.Close();
            fs2.Close();
        }

        private DataTable GetOverDraftsAccountdList()
        {
            DataTable cardData = new DataTable();
            OracleConnection conn = new OracleConnection();
            try
            {
                conn = OracleDBConnection.OpenConnection("FCC_LIVE");
                string str = "SELECT "
                            + " cust_ac_no account, "
                            + " acy_avl_bal balance "
                            + " FROM FCUSR01.sttm_cust_account "
                            + " where account_class = 'TCI001'";
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

        private void btnProcessRequestFile_Click(object sender, EventArgs e)
        {
            grdRequestValidAccount.Rows.Clear();
            string filename = openFileDialogRequestFile.FileName;
            string today = DateTime.Now.ToString("yyyyMMdd");
            string fileNamePrefix = "CBINSTRQ";

            if (filename.IndexOf(fileNamePrefix) != -1)
            {
                if (filename.IndexOf(fileNamePrefix + today) != -1)
                {
                    btnProcessRequestFile.Enabled = false;
                    CheckAndFilterOverDraftsAccount(filename);
                }
                else
                    if (MessageBox.Show("Are you sure to process this Instruction File: " + filename
                                        , "Waring", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnProcessRequestFile.Enabled = false;
                        CheckAndFilterOverDraftsAccount(filename);
                    }
                    else
                        return;
            }
            else
                MessageBox.Show("Format of FileName invalid");
        }

        private void btnFileResponseFailAccount_Click(object sender, EventArgs e)
        {
            if (openFileDialogResponseFailAccount.ShowDialog() == DialogResult.OK)
            {
                txtResponseFileFailAccount.Text = openFileDialogResponseFailAccount.FileName;
            }
        }

        private void btnFileResponseFromLP_Click(object sender, EventArgs e)
        {
            if (openFileDialogResponseFile.ShowDialog() == DialogResult.OK)
            {
                txtResponseFileFromLP.Text = openFileDialogResponseFile.FileName;
            }
        }

        private void AppendRecordToResponseFile(string filename1, string filename2)
        {
            string newfilename2 = filename2.Substring(0,filename2.LastIndexOf(".dat")) + "_bk_" + DateTime.Now.ToString("hhmmss_tt") + ".dat";
            File.Move(filename2,newfilename2);
            FileStream fs1 = new FileStream(filename1, FileMode.Open);
            StreamReader r1 = new StreamReader(fs1, Encoding.ASCII);
            FileStream fs2 = new FileStream(newfilename2, FileMode.Open);
            StreamReader r2 = new StreamReader(fs2, Encoding.ASCII);
            FileStream fs3 = new FileStream(filename2, FileMode.Create);
            StreamWriter w = new StreamWriter(fs3, Encoding.ASCII);

            string line1 = r1.ReadLine();
            string line2 = r2.ReadLine();

            while(line2 != null && line2.Substring(0,2) != "99")
            {
                w.WriteLine(line2);
                w.Flush();
                line2 = r2.ReadLine();
                //if (line2.IndexOf("01RBS00012000058288000001886120991401090010100448400001")!=-1)
                //{
                //    int a = 1;
                //}
            }

            string tailerLine = line2;
            int numOfRecord = int.Parse(tailerLine.Substring(10, 12));

            int count1 = 0;
            while (line1 != null && line1.Substring(0, 5) == "01RBS")
            {
                w.WriteLine(line1);
                w.Flush();
                line1 = r1.ReadLine();
                count1++;
            }

            numOfRecord = numOfRecord + count1;
            tailerLine = tailerLine.Substring(0, 10) + numOfRecord.ToString().PadLeft(12,'0');
            w.WriteLine(tailerLine);
            
            r1.Close();
            fs1.Close();
            r2.Close();
            fs2.Close();
            w.Flush();
            w.Close();
            fs3.Close();
        }

        private void ShowDataGridView(string filename, DataGridView grid)
        {
            grid.Rows.Clear();
            classInstructionResponse instructionResponse = new classInstructionResponse();
            instructionResponse.ReadInstructionFile(filename);
            string[] row = new string[5];
            int count = 1;
            for (int i = 0; i < instructionResponse.numberOfRecord; i++)
            {
                row[0] = (grid.Rows.Count + 1).ToString();
                row[1] = instructionResponse.account[i];
                row[2] = instructionResponse.amount[i];
                row[3] = instructionResponse.datetime[i].Substring(0, 8) + " - " + instructionResponse.datetime[i].Substring(8, 8);
                row[4] = instructionResponse.status[i];
                grid.Rows.Add(row);
                count++;
            }
        }

        private void AddRowToGridView(classInstructionRequest instruction, DataGridView grid, int index)
        {
            string[] row = new string[4];
            row[0] = (grid.Rows.Count+1).ToString();
            row[1] = instruction.account[index];
            row[2] = instruction.name[index];
            row[3] = instruction.amount[index];
            grid.Rows.Add(row);
        }

        
        private void btnProcessResponseFile_Click(object sender, EventArgs e)
        {
            string filename1 = openFileDialogResponseFailAccount.FileName;
            string filename2 = openFileDialogResponseFile.FileName;
            string today = DateTime.Now.ToString("yyyyMMdd");
            string fileNamePrefix = "CBINSTRP";
            

            if (filename1.IndexOf(fileNamePrefix) != -1 || filename2.IndexOf(fileNamePrefix) != -1)
            {
                if (filename2.IndexOf(fileNamePrefix + today) != -1 || filename1.IndexOf(fileNamePrefix + today + "_FailAccount") != -1)
                {
                    btnProcessResponseFile.Enabled = false;
                    AppendRecordToResponseFile(filename1,filename2);
                    ShowDataGridView(filename2, grdResponseFile);
                }
                else
                    if (MessageBox.Show("Are you sure to process this Response Files: " + filename1 + " and " + filename2
                                        , "Waring", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        btnProcessResponseFile.Enabled = false;
                        AppendRecordToResponseFile(filename1, filename2);
                        ShowDataGridView(filename2, grdResponseFile);
                    }
                    else
                        return;
            }
            else
                MessageBox.Show("Format of FileName invalid");
        }
    }
}