using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;
using DoiChieuGiaoDich_IPC;

namespace MasterCardTool
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();
        }

       
        private void submenuT057CurrencyRateFile_Click(object sender, EventArgs e)
        {
            frmMasterCard_T057_CurrencyRate frmT112 = new frmMasterCard_T057_CurrencyRate();
            frmT112.ShowDialog();
        }

        private void submenuT140_Click(object sender, EventArgs e)
        {
            frmMasterCard_T140_ReconReport frmT112 = new frmMasterCard_T140_ReconReport();
            frmT112.ShowDialog();
        }

        private void submenuT112IncomingFile_Click(object sender, EventArgs e)
        {
            frmMasterCard_T112_FirstPresentment frmT112 = new frmMasterCard_T112_FirstPresentment();
            frmT112.ShowDialog();
        }

        //private void submenuFindUnknowCard_Click(object sender, EventArgs e)
        //{
        //    //frmFindUnknownCard frm = new frmFindUnknownCard();
        //    //frm.ShowDialog();
        //}

        private void u70013ReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmU70013Report frm = new frmU70013Report();
            frm.ShowDialog();
        }

        private void checkFilterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmCheckFilterOverDraftsAccount frm = new frmCheckFilterOverDraftsAccount();
            frm.ShowDialog();
        }

        private void welcomeLetterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmWelcome_Letter frm = new frmWelcome_Letter();
            frm.ShowDialog();
        }
    }
}