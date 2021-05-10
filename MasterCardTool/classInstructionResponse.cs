using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MasterCardTool
{
    class classInstructionResponse
    {
        public int numberOfRecord = 0;
        public string fileProcessDate = "";
        public List<string> account = new List<string>();
        public List<string> amount = new List<string>();
        public List<string> datetime = new List<string>();
        public List<string> status = new List<string>();
        public List<string> recordContent = new List<string>();


        public void ReadInstructionFile(string filename)
        {
            FileStream fs = new FileStream(filename, FileMode.Open);
            StreamReader r = new StreamReader(fs, Encoding.ASCII);
            string line = r.ReadLine();
            while (line != null)
            {
                ParseRecord(line);
                line = r.ReadLine();
            }
            r.Close();
            fs.Close();
        }

        private void ParseRecord(string line)
        {
            string prefix = line.Substring(0, 2);
            switch (prefix)
            {
                case "00":
                    this.fileProcessDate = line.Substring(2, 8);
                    break;
                case "01":
                    this.account.Add(line.Substring(39, 30).Trim());
                    this.amount.Add(line.Substring(69, 16).Trim());// get 16 only because not get decimal
                    this.datetime.Add(line.Substring(108, 16).Trim());
                    this.status.Add(line.Substring(124, 2).Trim());
                    this.recordContent.Add(line);
                    break;
                case "99":
                    this.numberOfRecord = int.Parse(line.Substring(10, 12));
                    break;
                default:
                    break;
            }
        }
    }
}
