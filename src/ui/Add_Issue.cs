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
        private bool allowAccount=false;
        public Add_Issue()
        {
            InitializeComponent();
            dpReturnDueDate.Value= dpReturnDueDate.Value.AddDays(30);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            TAIKHOANDOCGIA user = us.getAccountUser(txtUserID.Text);
            if (user!=null)
            {
                ibs.addIssueBook(dpIssueDate.Value, dpReturnDueDate.Value, user.TaiKhoan);
                foreach (Control i in flpListIssueBook.Controls)
                {
                    String name = bs.getBookId(i.Controls[0].Controls[0].Text).MaSach;
                    int quantity = int.Parse(i.Controls[0].Controls[2].Text);
                    ids.addIssueDetail(name, "PM" + ibs.getQuantityIssue(), quantity);
                }
            }
            this.Close();
        }

        private void btnCheckUser_Click(object sender, EventArgs e)
        {
            var user = us.checkUser(txtUserID.Text);
            if (user != null)
            {
                if ((bool)!user.TrangThai)
                    lblErrorUserID.Text = "Tài khoản không đủ đk để mượn sách";
                else
                    lblErrorUserID.Text = "Tài khoản hợp lệ";
            }
            else
                lblErrorUserID.Text = "Tài khoản không tồn tại";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void btAddIssueBook_Click(object sender, EventArgs e)
        {
            String name, quantity;
            Add_IssueBook addIssueBook = new Add_IssueBook();
            addIssueBook.FlpIB = flpListIssueBook;
            addIssueBook.ShowDialog();
            name = addIssueBook.BookName;
            quantity = addIssueBook.BookQuantity;
            if (name != "" && quantity != "0")
            {
                IssueBookUC ib = new IssueBookUC(name, quantity);
                flpListIssueBook.Controls.Add(ib);
            }
        }
    }
}
