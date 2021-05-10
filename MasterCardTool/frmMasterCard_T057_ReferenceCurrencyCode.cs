using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace MasterCardTool
{
    public partial class frmMasterCard_T057_ReferenceCurrencyCode : Form
    {
        DataTable code_table = new DataTable();
        XulyNghiepVu xl = new XulyNghiepVu();

        public frmMasterCard_T057_ReferenceCurrencyCode()
        {
            InitializeComponent();
            xl = new XulyNghiepVu();
            code_table = xl.GetCurrencyCodeList();
            grdCurrencyCodeList.DataSource = code_table;
            
        }
        
    }
}