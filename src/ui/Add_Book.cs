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
    public partial class Add_Book : MetroFramework.Forms.MetroForm
    {
        isValidInput valid =new isValidInput();
        private BookServices bs = new BookServices();
        private bool validAddBook()
        {
            foreach (Control c in this.Controls)
            {
                if (c is Label)
                {
                    if ((c as Label).ForeColor == Color.Red)
                        if ((c as Label).Text != "") return false;
                }
                else if (c is TextBox)
                {
                    if ((c as TextBox).Text == "")
                        return false;
                }
            }
            // Them check du lieu
            return true;
        }
        public Add_Book()
        {
            InitializeComponent();
            txtBookID.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
             {
                 String s=txtBookID.Text;
                 lblErrorBookID.Text = valid.isValidUserName(s) && s != "" ? "Invalid Book ID!" : (s == "" ? "You must enter this inforamtion!" : "");
             });
            addBook();
            btnSave.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                if (validAddBook())
                {
                    if (bs.addBook(txtBookID.Text, txtBookTitle.Text, Int32.Parse(txtAmount.Text), txtBookAuthor.Text, Int32.Parse(txtPublisherYear.Text), txtPublisher.Text))
                    {
                        //call add book in db
                        MessageBox.Show("Succesfully!");
                        this.Close();
                    }
                    else
                        MessageBox.Show("Invalid input !");
                }
                else MessageBox.Show("Invalid input !");
            });
        }
        public Add_Book(dynamic book)
        {
            InitializeComponent();
            txtBookID.Text = book.MaSach;
            txtBookID.Enabled = false;
            lblErrorBookID.Enabled=false;
            txtBookTitle.Text = book.TenSach;
            txtBookAuthor.Text = book.TacGia;
            txtAmount.Text = String.Format("{0}",book.SoLuong);
            txtPublisher.Text = book.NhaXuatBan;
            txtPublisherYear.Text = String.Format("{0}", book.NamXuatBan);
            addBook();
            btnSave.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                if (validAddBook())
                {
                    //call updatebook add book in db
                    dynamic book2=bs.bookInfo(book.MaSach);
                    book2.MaSach = book.MaSach;
                    book2.TacGia = txtBookAuthor.Text;
                    book2.TenSach = txtBookTitle.Text;
                    book2.SoLuong= Int32.Parse(txtAmount.Text);
                    book2.NhaXuatBan= txtPublisher.Text;
                    book2.NamXuatBan = Int32.Parse(txtPublisherYear.Text);
                    bs.updateBook(book2);
                    MessageBox.Show("Succesfully!");
                    this.Close();
                }
                else MessageBox.Show("Invalid input !");
            });

        }
        private void addBook()
        {
            txtBookID.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
              {
                  String s=txtBookID.Text;
                  if (bs.getBookName(s) != null) {
                      lblErrorBookID.Text = "Book already exists !";
                  }
                  else
                    lblErrorBookID.Text= valid.isValidUserName(s) && s != "" ? "Invalid Book Id !" : (s == "" ? "You must enter this infomation!" : "");
              });
            txtBookTitle.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtBookTitle.Text;
                s = s.Trim();
                while (s.IndexOf("  ") != -1)
                {
                    s = isValidInput.removeCharAt(s, s.IndexOf("  ") + 1, 1);
                }
                txtBookTitle.Text = s;
            });
            txtBookAuthor.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtBookAuthor.Text;
                lblErrorAuthor.Text = valid.isValidName(s) && s != "" ? "Invalid full name !" : (s == "" ? "You must enter this infomation!" : "");
            });
            txtBookAuthor.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                txtBookAuthor.Text = txtBookAuthor.Text != "" ? valid.styleString(txtBookAuthor.Text) : txtBookAuthor.Text;
            });
            txtPublisher.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtPublisher.Text;
                lblErrorPublisher.Text = valid.isValidName(s) && s != "" ? "Invalid name !" : (s == "" ? "You must enter this information!" : "");
            });
            txtPublisher.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                txtPublisher.Text = txtPublisher.Text != "" ? valid.styleString(txtPublisher.Text) : txtPublisher.Text;
            });
            txtPublisherYear.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtPublisherYear.Text;
                lblErrorPublisherYear.Text = !valid.isValidYear(s) && s != "" ? "Invalid Year !" : (s == "" ? "You must enter this information!" : "");
            });
            txtAmount.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtAmount.Text;
                int i;
                try
                {
                    i = int.Parse(s);
                    lblErrorAmount.Text = String.Empty;
                }
                catch (Exception)
                {
                    lblErrorAmount.Text = "Invalid Amount !";
                }
            });
            btnClear.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                foreach (Control mycontrols in this.Controls)
                {
                    if (mycontrols is TextBox)
                    {
                        (mycontrols as TextBox).Text = string.Empty;

                    }
                    else if (mycontrols is DateTimePicker)
                    {

                        (mycontrols as DateTimePicker).Value = DateTime.Now;

                    }
                }
                foreach (Control label in this.Controls)
                {
                    if (label is Label)
                    {
                        if ((label as Label).ForeColor == Color.Red)
                            (label as Label).Text = string.Empty;
                    }
                }
            });

        }
    }
}
