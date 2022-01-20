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
            lblManage.Text = btnUser.Text;
            btnUser.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  initUserTable();
                  lblManage.Text=btnUser.Text;
                  btnUser.BackColor = Color.DodgerBlue;
                  btnUser.ForeColor = Color.Black;
                  btnBook.BackColor = Color.White;
                  btnBook.ForeColor = Color.DarkGreen;
                  btnIssueBook.BackColor = Color.White;
                  btnIssueBook.ForeColor = Color.DarkGreen;
              });
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
                lblManage.Text=btnBook.Text;
                btnUser.BackColor = Color.White;
                btnUser.ForeColor= Color.DarkGreen;
                btnBook.BackColor = Color.DodgerBlue;
                btnBook.ForeColor = Color.Black;
                btnIssueBook.BackColor = Color.White;
                btnIssueBook.ForeColor = Color.DarkGreen;
            });
            btnIssueBook.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  initBookIssue();
                  lblManage.Text= btnIssueBook.Text;
                  btnUser.BackColor = Color.White;
                  btnUser.ForeColor = Color.DarkGreen;
                  btnIssueBook.BackColor = Color.DodgerBlue;
                  btnBook.BackColor = Color.White;
                  btnBook.ForeColor= Color.DarkGreen;
                  btnIssueBook.ForeColor = Color.Black;
              });
            
            dataGridView.CellClick += new DataGridViewCellEventHandler(delegate (object sender,DataGridViewCellEventArgs e)
             {
                 try
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
                 } catch (Exception ex)
                 {
                     t = null;
                 }
             });
            dataGridView.CellDoubleClick += new DataGridViewCellEventHandler(delegate (Object sender, DataGridViewCellEventArgs e)
             {
                 try {
                     switch (choice)
                     {
                         case 0:
                             t = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                             break;
                         case 1:
                             t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                             break;
                         case 2:
                             t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                             break;
                     }
                     edit();
                 } catch (Exception ex)
                 {
                     t = null;
                 }
             });
            txtSearchBox.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
              {
                  search();
              });
            btnAdd.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  switch (choice)
                  {
                      case 0:
                          SignUp form=new SignUp();
                          form.Text = "Add User Control";
                          form.ShowDialog();
                          initUserTable();
                          break;
                      case 1:
                          Add_Book formbook=new Add_Book();
                          formbook.Text = "Add New Book";
                          formbook.ShowDialog();
                          initBookTable();
                          break;
                      case 2:

                          break;
                  }
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
                    change.ShowDialog();
                    initUserTable();
                    break;
                case 1:
                    dynamic ds;
                    ds = bs.bookInfo(t);
                    Add_Book book = new Add_Book(ds);
                    book.Text = "Change Information Book";
                    book.ShowDialog();
                    initBookTable();
                    break;
                case 2:
                    break;
            }
        }
        private void search()
        {
            String s=txtSearchBox.Text;
            switch (choice)
            {
                case 0:
                    dataGridView.DataSource = null;
                    dataGridView.DataSource = s != "" ? us.searchUser(s) : us.getListUser();
                    break;
                case 1:
                    dataGridView.DataSource= null;

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
            initTable();
        }
        private void initBookTable()
        {
            choice = 1;
            dataGridView.DataSource = null;
            dataGridView.DataSource = bs.getListBook();
            initTable();
        }
        private void initBookIssue()
        {
            choice = 2;
            dataGridView.DataSource = null;
            dataGridView.DataSource = iss.getIssueBook();
            initTable();
            // Đổ dữ liệu vào grid view
        }
        private void initTable()
        {
            for (int i = 0; i < dataGridView.Columns.Count - 1; i++)
            {
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
            }
            dataGridView.Columns[dataGridView.Columns.Count - 1].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;

            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                int colw = dataGridView.Columns[i].Width;
                dataGridView.Columns[i].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
                dataGridView.Columns[i].Width = colw;
            }
        }
        private void initMenu()
        {
            
        }
    }
}
