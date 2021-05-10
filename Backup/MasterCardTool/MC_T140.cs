using System;
using System.Collections.Generic;
using System.Text;

namespace MasterCardTool
{
    public class MC_T140
    {
        public string filename;
        public string newfilename;
        public string runDate;
        public string clearingDate;
        public string clearingCycle;
        public Double USDAmount;
        public Double VNDAmount;

        public MC_T140()
        {
            filename = "";
            newfilename = "";
            runDate = "";
            clearingDate = "";
            clearingCycle = "";
            USDAmount = 0.0;
            VNDAmount = 0.0;
        }
    }
    
}
