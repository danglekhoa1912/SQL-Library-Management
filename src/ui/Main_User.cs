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
        int choice, count, tienphat;
        src.services.UserServices us;
        src.services.BookServices bs;
        src.services.IssueBookServices iss;
        dynamic ds;
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
            this.Id = "T6";
            count = us.getSachChuaTra(Id);
            lblUser.Text = String.Format("Borrowed books:{0}\nRemaining:{1}", count,5-count);
            ds = bs.getListBook();
            carts = new List<cart>();
            initBookTable();
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
            });
            btnIssueBook.Click += new EventHandler(delegate (Object sender, EventArgs e)
            {
                initIssueBook();
                dataGridView.Focus();
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
                        /*  case 2:
                              t = dataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                              break;*/
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
                      }
                  }
                  catch(Exception ex)
                  {

                  }
              });
        }


        private void addToCart()
        {
            try
            {
                dynamic sach = bs.bookInfo(t);
                if (sach.SoLuong>0)
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
            btnDelete.Visible = false;
            btnEdit.Visible = false;
            btnRefesh.Visible = false;
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
            this.id = "T6";
            dataGridView.DataSource = null;
            dataGridView.DataSource = iss.getUserBook(this.id);
            initTable();
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

        public string Id { get => id; set => id = value; }
    }
}
