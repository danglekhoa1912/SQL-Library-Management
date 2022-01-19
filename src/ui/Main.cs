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
        String t;
        int choice=0;
        BookServices bs;
        UserServices us;
        IssueBookServices iss;
        public Main()
        {
            bs = new BookServices();
            us = new UserServices();
            iss= new IssueBookServices();
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
            
            dataGridView.CellClick += new DataGridViewCellEventHandler(delegate (object sender,DataGridViewCellEventArgs e)
             {
                 switch (choice)
                 {
                     case 0:
                         t=dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                         break;
                     case 1:
                         t=dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                         break;
                     case 2:
                         t=dataGridView.Rows[e.RowIndex ].Cells[0].Value.ToString();
                         break;
                 }
             });
            dataGridView.CellDoubleClick += new DataGridViewCellEventHandler(delegate (Object sender, DataGridViewCellEventArgs e)
             {
                 switch (choice)
                 {
                     case 0:
                         t = dataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                         break;
                     case 1:
                         t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                         break;
                     case 2:
                         t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                         break;
                 }
                 edit();
             });
        }
        private void edit()
        {
            switch (choice)
            {
                case 0:
                    dynamic user;
                    user = us.getUser(t);
                    SignUp change=new SignUp(user);
                    change.Text = "Change Information User";
                    change.Show();
                    break;
                case 1:
                    dynamic ds;
                    ds = bs.bookInfo(t);
                    Add_Book book = new Add_Book(ds);
                    book.Text = "Change Information Book";
                    book.Show();
                    break;
                case 2:
                    break;
            }
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
