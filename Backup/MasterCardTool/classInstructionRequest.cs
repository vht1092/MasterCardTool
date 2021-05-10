using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace MasterCardTool
{
    public class classInstructionRequest
    {
        public int numberOfRecord = 0;
        public string fileProcessDate = "";
        public List<string> account = new List<string>();
        public List<string> name = new List<string>();
        public List<string> amount = new List<string>();
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
            string prefix = line.Substring(0,2);
            switch (prefix)
            {
                case "00":
                    this.fileProcessDate = line.Substring(2, 8);
                    break;
                case "01":
                    this.account.Add(line.Substring(39, 30).Trim());
                    this.name.Add(line.Substring(69, 120).Trim());
                    this.amount.Add(line.Substring(189, 16).Trim());// get 16 only because not get decimal
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
