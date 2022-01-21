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
        private String id;
        public EditIssueBook(String id)
        {
            ids = new IssueDetailServices();
            this.id = id;
            InitializeComponent();
            issueDetail = ids.getInforIssueDetail(id);
            lblBookId.Text = issueDetail.MaSach;
            lblQuantity.Text = issueDetail.SoLuong.ToString();
            dtpReturnDate.Enabled = cbReturned.Checked;
            if (issueDetail.TinhTrang!="")
            {
                dtpReturnDate.Value = issueDetail.NgayTra;
                cbReturned.Checked = true;
                txtStatus.Text = issueDetail.TinhTrang;
            }
        }

        private void cbReturned_CheckedChanged(object sender, EventArgs e)
        {
            dtpReturnDate.Enabled = cbReturned.Checked;
            if(cbReturned.Checked)
                txtPenalty.Text = (-ids.getTienPhat(int.Parse(id), dtpReturnDate.Value) * 5000).ToString();
            else
                txtPenalty.Text = "";

        }

        //ddang lam

        private void btnDone_Click(object sender, EventArgs e)
        {
            if (cbReturned.Checked)
            {
                if (txtStatus.Text != "")
                {
                    ids.updateIssueDetai(id, dtpReturnDate.Value, txtStatus.Text, int.Parse(txtPenalty.Text));
                    Close();
                }
                else MessageBox.Show("Vui lòng nhập tình trạng sách");
            }
        }

        private void dtpReturnDate_ValueChanged(object sender, EventArgs e)
        {
            txtPenalty.Text = (-ids.getTienPhat(int.Parse(id), dtpReturnDate.Value) * 5000).ToString();

        }
    }
}
