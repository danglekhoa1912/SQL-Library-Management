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
    public partial class ListIssueBook : MetroFramework.Forms.MetroForm
    {
        String id;
        IssueDetailServices ids;
        IssueBookServices ibs;
        public ListIssueBook(String issueId)
        {
            ids = new IssueDetailServices();
            ibs = new IssueBookServices();
            InitializeComponent();
            initIssueDetailTable(issueId);
            lblIssueId.Text = issueId;
        }

        public void initIssueDetailTable(String issueId)
        {
            dgvIssueDetail.DataSource = null;
            dgvIssueDetail.DataSource = ids.getListIssueDetail(issueId);
            dgvIssueDetail.Focus();
            initTable();
            dgvIssueDetail.CellDoubleClick+= new DataGridViewCellEventHandler(delegate (Object sender, DataGridViewCellEventArgs e)
            {
                try
                {                    
                    id = dgvIssueDetail.Rows[e.RowIndex].Cells[0].Value.ToString();
                    edit( issueId);
                }
                catch (Exception ex)
                {
                    id = null;
                }
            });
        }

        private void edit(String issueId)
        {
           EditIssueBook issue = new EditIssueBook(id);
           issue.Text = "Edit Issue Book";
           issue.ShowDialog();
            initIssueDetailTable(issueId);
            ibs.updateIssue(issueId);
        }


        protected void initTable()
        {
            for (int i = 0; i < dgvIssueDetail.Columns.Count - 1; i++)
            {
                dgvIssueDetail.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dgvIssueDetail.Columns[dgvIssueDetail.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dgvIssueDetail.Columns.Count; i++)
            {
                int colw = dgvIssueDetail.Columns[i].Width;
                dgvIssueDetail.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dgvIssueDetail.Columns[i].Width = colw;
            }
        }
    }
}
