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
        public Add_Issue()
        {
            InitializeComponent();
            dpReturnDueDate.Value= dpReturnDueDate.Value.AddDays(30);
        }

        private void btnDone_Click(object sender, EventArgs e)
        {
            
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
            addIssueBook.ShowDialog();
            name = addIssueBook.BookName;
            quantity = addIssueBook.BookQuantity;
            addIssueBook.Add_Issue = this;
            if (name != "" && quantity != "0")
            {
                IssueBookUC ib = new IssueBookUC(name, quantity);
                flpListIssueBook.Controls.Add(ib);
            }
        }
    }
}
