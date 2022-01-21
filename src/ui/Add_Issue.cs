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
    public partial class Add_Issue : MetroFramework.Forms.MetroForm
    {
        UserServices us = new UserServices();
        BookServices bs = new BookServices();
        IssueDetailServices ids = new IssueDetailServices();
        IssueBookServices ibs = new IssueBookServices();
        public bool isValidUserId = false;
        public Add_Issue()
        {
            InitializeComponent();
            dpReturnDueDate.Value = dpReturnDueDate.Value.AddDays(30);
            btAddIssueBook.Enabled = isValidUserId;
        }

        public bool valid()
        {
            if (txtUserID.Text != ""&& flpListIssueBook.Controls.Count>0)
                return true;
            return false;
                
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            TAIKHOANDOCGIA user = us.getAccountUser(txtUserID.Text);
            if (user != null&&valid())
            {
                if ((bool)user.TrangThai)
                {
                    ibs.addIssueBook(dpIssueDate.Value, dpReturnDueDate.Value, user.TaiKhoan);
                    foreach (Control i in flpListIssueBook.Controls)
                    {
                        String name = bs.getBookId(i.Controls[1].Controls[0].Text).MaSach;
                        int quantity = int.Parse(i.Controls[1].Controls[2].Text);
                        ids.addIssueDetail(name, "PM" + ibs.getQuantityIssue(), quantity);
                    }
                    MessageBox.Show("Thêm phiếu mượn thành công");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Tài khoản không đủ điều kiện để mượn sách");
                }
            }
            else
            {
                MessageBox.Show("Vui lòng kiểm tra lại thông tin");
            }
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            var user = us.checkUser(txtUserID.Text);
            if (user != null)
            {
                if ((bool)!user.TrangThai)
                    lblErrorUserID.Text = "Tài khoản không đủ đk để mượn sách";
                else if (ibs.getQuantityBookUserIssue(user.TaiKhoan) >= 5)
                    lblErrorUserID.Text = "Tài khoản đã mượn 5 cuốn";
                else
                {
                    isValidUserId = true;
                    lblErrorUserID.Text = "Tài khoản hợp lệ";
                }
            }
            else
                lblErrorUserID.Text = "Tài khoản không tồn tại";
            btAddIssueBook.Enabled = isValidUserId;
        }


        private void btAddIssueBook_Click(object sender, EventArgs e)
        {
                String name, quantity;
                Add_IssueBook addIssueBook = new Add_IssueBook();
                addIssueBook.FlpIB = flpListIssueBook;
                addIssueBook.ShowDialog();
                name = addIssueBook.BookName;
                quantity = addIssueBook.BookQuantity;
                if (name != "" && quantity != "0" && name != null)
                {
                    IssueBookUC ib = new IssueBookUC(name, quantity);
                    ib.Btn.Click += new EventHandler(delegate (object s, EventArgs ev)
                    {
                        flpListIssueBook.Controls.Remove(ib);
                        btAddIssueBook.Enabled = true;
                    });
                    flpListIssueBook.Controls.Add(ib);
                if (ibs.getQuantityBookUserIssue(us.getAccountUser(txtUserID.Text).TaiKhoan)+ flpListIssueBook.Controls.Count == 5)
                    btAddIssueBook.Enabled = false;
                }
            }
               
        }
    }
