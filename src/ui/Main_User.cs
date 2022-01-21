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
    public partial class Main_User : MetroFramework.Forms.MetroForm
    {
        private String id;
        String t;
        dynamic u;
        int choice, count, tienphat;
        src.services.UserServices us;
        src.services.BookServices bs;
        src.services.IssueBookServices iss;

        public string Id { get => id; set => id = value; }
        //dynamic ds;
        struct cart
        {
            public String MaSach;
            public String TenSach;
            public String TacGia;
            public DateTime NgayDat;
        }
        List<cart> carts = new List<cart>();
        
        public Main_User()
        {
            InitializeComponent();
            us=new src.services.UserServices();
            bs=new src.services.BookServices();
            iss=new src.services.IssueBookServices();
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
            });
            btnIssueBook.Click += new EventHandler(delegate (Object sender, EventArgs e)
            {
                initIssueBook();
                dataGridView.Focus();
                btnAdd.Visible = false;
                btnDelete.Visible = false;
                lblManage.Text = btnIssueBook.Text;
                btnCart.BackColor = Color.White;
                btnCart.ForeColor = Color.DarkGreen;
                btnIssueBook.BackColor = Color.DodgerBlue;
                btnBook.BackColor = Color.White;
                btnBook.ForeColor = Color.DarkGreen;
                btnIssueBook.ForeColor = Color.Black;
            });
            btnCart.Click += new EventHandler(delegate (Object sender, EventArgs e)
            {
                initCartTable();
                dataGridView.Focus();
                lblManage.Text=btnCart.Text;
                btnCart.BackColor = Color.DodgerBlue;
                btnCart.ForeColor = Color.Black;
                btnBook.BackColor = Color.White;
                btnBook.ForeColor = Color.DarkGreen;
                btnIssueBook.BackColor = Color.White;
                btnIssueBook.ForeColor = Color.DarkGreen;
                btnDelete.Visible = true;
                btnAdd.Visible = true;
                btnAdd.Text = "Save Issue";
            });
            dataGridView.CellClick += new DataGridViewCellEventHandler(delegate (object sender, DataGridViewCellEventArgs e)
              {
                  try
                  {
                      switch (choice)
                      {
                          case 0:
                              t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                              break;
                          case 1:
                              t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                              break;
                          case 2:
                              t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                              break;
                      }
                      //MessageBox.Show(t);
                  }
                  catch (Exception ex)
                  {
                      t = null;
                  }
              });
            btnAdd.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  try
                  {
                      switch (choice)
                      {
                          case 1:
                              addToCart();
                              break;
                          case 2:
                              //Add issue
                              break;

                      }
                  }
                  catch(Exception ex)
                  {
                      MessageBox.Show(ex.Message);
                  }
              });
            btnDelete.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  if (choice ==2)
                  {
                      try
                      {
                          int vt = carts.FindIndex(s => s.MaSach == t);
                          carts.RemoveAt(vt);
                          MessageBox.Show("Succesfully!!");
                          initCartTable();
                      } catch (Exception ex)
                      {
                          MessageBox.Show("Please check you choice !!");
                      }
                  }
              });
            btnInfo.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  Acount_Info acount_Info = new Acount_Info(id);
                  acount_Info.ShowDialog();
              });
            btnExit.Click += new EventHandler(delegate (Object sender, EventArgs e)
            {
                this.id = null;
                this.Close();
            });
            btnLogOut.Click += new EventHandler(delegate (Object sender, EventArgs e) 
            {
                this.id = null;
                Login login=new Login();
                this.Hide();
                login.ShowDialog();
                this.Close();
            });
            txtSearchBox.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
              {
                  String s=txtSearchBox.Text;
                  switch (choice)
                  {
                      case 1:
                          dataGridView.DataSource = null;
                          dataGridView.DataSource = s != "" ? bs.searchBook(s) : bs.getListBook();
                          break;
                  }
              });
        }


        private void addToCart()
        {
            try
            {
                dynamic sach = bs.bookInfo(t);
                if (sach.SoLuong>0 && carts.Count<(5-count))
                {
                    cart c;
                    c.MaSach=sach.MaSach;
                    c.TacGia=sach.TacGia;
                    c.TenSach=sach.TenSach;
                    c.NgayDat = DateTime.Today;
                    if (carts.IndexOf(c) != -1)
                    {
                        MessageBox.Show("The book is already in the cart!");
                    }
                    else
                    {
                        carts.Add(c);
                        MessageBox.Show("Add book to cart successfully!");
                    }
                }
                else
                {
                    MessageBox.Show("The book is currently unavailable! " );
                }
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        private void initBookTable()
        {
            choice = 1;
            dataGridView.DataSource = null;
            dataGridView.DataSource = bs.getListBook();
            dataGridView.Focus();
            btnAdd.Visible = true;
            btnDelete.Visible = false;
            btnAdd.Text = "Add to cart";
            lblManage.Text = btnBook.Text;
            btnCart.BackColor = Color.White;
            btnCart.ForeColor = Color.DarkGreen;
            btnBook.BackColor = Color.DodgerBlue;
            btnBook.ForeColor = Color.Black;
            btnIssueBook.BackColor = Color.White;
            btnIssueBook.ForeColor = Color.DarkGreen;
            initTable();
        }

        private void initIssueBook()
        {
            choice = 0;
            dataGridView.DataSource = null;
            dataGridView.DataSource = iss.getUserBook(u.TaiKhoan);
            initTable();
        }

        private void Main_User_Load(object sender, EventArgs e)
        {
            u = us.getAccountUser(id);
            count = us.getSachChuaTra(u.TaiKhoan);
            lblUser.Text = String.Format("Borrowed books:{0}\nRemaining:{1}", count, 5 - count); carts = new List<cart>();
            initBookTable();
        }

        private void initCartTable()
        {
            choice = 2;
            DataTable dataTable = new DataTable();
            dataTable.Columns.Add("Ma sach");
            dataTable.Columns.Add("Ten sach");
            dataTable.Columns.Add("Tac gia");
            dataTable.Columns.Add("Ngay dat");
            carts.ForEach(c =>
            {
                DataRow row;
                row = dataTable.NewRow();
                row[0] = c.MaSach;
                row[1] = c.TenSach;
                row[2] = c.TacGia;
                row[3] = c.NgayDat;
                dataTable.Rows.Add(row);
            });
            dataGridView.DataSource = null;
            dataGridView.DataSource = dataTable;
            //dataGridView.DataSource = list;
            initTable();
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

    }
}
