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
        private String id;
        int choice=0;
        BookServices bs;
        UserServices us;
        IssueBookServices iss;
        IssueDetailServices ids;

        public string Id { get => id; set => id = value; }

        public Main()
        {
            bs = new BookServices();
            us = new UserServices();
            iss= new IssueBookServices();
            ids = new IssueDetailServices();
            InitializeComponent();
            lblManage.Text = btnUser.Text;
            btnUser.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  initUserTable();
                  
              });
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
                dataGridView.Focus();
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
                  dataGridView.Focus();
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
                             t = dataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
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
                  initTable();
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
                          Add_Issue formIssue = new Add_Issue();
                          formIssue.Text = "Add Issue Book";
                          formIssue.ShowDialog();
                          initBookIssue();
                          break;
                  }
              });
            btnDelete.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  try
                  {
                      switch (choice)
                      {
                          case 0:
                              us.deleteUser(t);
                              initUserTable();
                              break;
                          case 1:
                              bs.deleteBook(t);
                              initBookTable();
                              break;
                          case 2:
                              MessageBox.Show("Can't delete issua book!");
                              break;
                      }
                  }catch (Exception ex)
                  {
                      MessageBox.Show("Check your choice ");
                  }
              });
            btnEdit.Click += new EventHandler(delegate (object sender, EventArgs e)
             {
                 try
                 {
                     edit();
                 } catch (Exception ex)
                 {
                     MessageBox.Show("Check your choice !");
                 }
             });
            btnRefesh.Click += new EventHandler(delegate (object sender, EventArgs e) { 
                refesh();
                txtSearchBox.Text =String.Empty;
            });
            btnInfo.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  Acount_Info acount = new Acount_Info(id);
                  acount.ShowDialog();
              });
            btnLogOut.Click += new EventHandler(delegate (object sender, EventArgs e) 
            {
                Login login = new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            });
            btnExit.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                this.Close();
            });
            btnLanguage.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                MessageBox.Show("The function is developing, please wait for the next update ");
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
                    ListIssueBook issue = new ListIssueBook(t);
                    issue.ShowDialog();
                    initBookIssue();
                    break;
            }
        }

        protected void refesh()
        {
            switch (choice)
            {
                case 0:
                    initUserTable();
                    break;
                case 1:
                    initBookTable();
                    break;
                case 2:
                    initBookIssue();
                    break;
            }
        }
        protected void search()
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
                    dataGridView.DataSource=s!=""?bs.searchBook(s) : bs.getListBook();
                    break;
                case 2:

                    break;
            }
        }

        protected void Main_Load(object sender, EventArgs e)
        {
            initUserTable();
            btnUser.Focus();
            dataGridView.Focus();
        }
        protected void initUserTable()
        {
            choice=0;
            lblManage.Text = btnUser.Text;
            btnUser.BackColor = Color.DodgerBlue;
            btnUser.ForeColor = Color.Black;
            btnBook.BackColor = Color.White;
            btnBook.ForeColor = Color.DarkGreen;
            btnIssueBook.BackColor = Color.White;
            btnIssueBook.ForeColor = Color.DarkGreen;
            // Đổ dữ liệu vào grid view
            dataGridView.DataSource = null;
            dataGridView.DataSource = us.getListUser();
            initTable();
            dataGridView.Focus();
        }
        protected void initBookTable()
        {
            choice = 1;
            dataGridView.DataSource = null;
            dataGridView.DataSource = bs.getListBook();
            initTable();
        }
        protected void initBookIssue()
        {
            choice = 2;
            dataGridView.DataSource = null;
            dataGridView.DataSource = iss.getIssueBook();
            initTable();
            // Đổ dữ liệu vào grid view
        }
        protected void initTable()
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
