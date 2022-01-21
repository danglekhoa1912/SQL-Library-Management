using Library_Management.src.services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.ui
{
    public partial class EditIssueBook : MetroFramework.Forms.MetroForm
    {
        IssueDetailServices ids ;
        dynamic issueDetail ;
        public EditIssueBook(String id)
        {
            ids = new IssueDetailServices();
            InitializeComponent();
            issueDetail = ids.getInforIssueDetail(id);
            lblBookId.Text = issueDetail.MaSach;
            lblQuantity.Text = issueDetail.SoLuong.ToString();
            dtpReturnDate.Enabled = cbReturned.Checked;
        }

        private void cbReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpReturnDate.Enabled = cbReturned.Checked;
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbReturned.Checked)
            {

            }
        }
    }
}
