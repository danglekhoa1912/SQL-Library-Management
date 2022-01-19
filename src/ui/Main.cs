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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        int choice=0;
        BookServices bs;
        UserServices us;
        IssueBookServices iss;
        public Main()
        {
            InitializeComponent();
            btnUser.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  initUserTable();
              });
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
            });
            btnIssueBook.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  initBookIssue();
              });
            bs = new BookServices();
            us = new UserServices();
            iss= new IssueBookServices();
        }

        private void Main_Load(object sender, EventArgs e)
        {
            initUserTable();
        }
        private void initUserTable()
        {
            choice=0;
            // Đổ dữ liệu vào grid view
           dataGridView.DataSource = null;
            dataGridView.DataSource = us.getListUser();
        }
        private void initBookTable()
        {
            choice = 1;
            dataGridView.DataSource = null;
            dataGridView.DataSource = bs.getListBook();
        }
        private void initBookIssue()
        {
            choice = 2;
            dataGridView.DataSource = null;
            dataGridView.DataSource = iss.getIssueBook();
            // Đổ dữ liệu vào grid view
        }
    }
}
