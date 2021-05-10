using System;
using System.Collections.Generic;
using System.Text;

namespace MasterCardTool
{
    public struct T057_Detail
    {
        public string detailDescription;
        public string sourceCurrencyCode;
        public string referenceCurrencyCode;
        public string sourceCurrencyExponent;
        public string rateClass;
        public string rateFormatIndicator;
        public double buyCurrencyConversionRate;
        public double midCurrencyConversionRate;
        public double sellCurrencyConversionRate;
        public string reservedField;
    }

    public class MC_T057
    {
        public string filename;
        public string newfilename;
        public string headerDescription;
        public string date;
        public string time;
        public string version;
        public T057_Detail[] detail;
        public string trailerDescription;
        public int totalDetailRecordCount;
        public double hasTotal;

        public MC_T057()
        {
            filename = "";
            newfilename = "";
            headerDescription = "";
            date = "";
            time = "";
            version = "";
            detail = new T057_Detail[600];//hhhhh
            trailerDescription = "";
            totalDetailRecordCount = 0;
            hasTotal = 0.0;
        }
    }
}
