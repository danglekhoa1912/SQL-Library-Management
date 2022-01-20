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
    public partial class Add_IssueBook : MetroFramework.Forms.MetroForm
    {
        BookServices bs = new BookServices();
        private Add_Issue add_Issue = new Add_Issue();
        private String bookName, bookQuantity;

        public string BookName { get => bookName; set => bookName = value; }
        public string BookQuantity { get => bookQuantity; set => bookQuantity = value; }
        public Add_Issue Add_Issue { get => add_Issue; set => add_Issue = value; }

        public Add_IssueBook()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if(int.Parse(lbBookQuantity.Text)<=3)
            lbBookQuantity.Text = (int.Parse(lbBookQuantity.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if(int.Parse(lbBookQuantity.Text)>0)
                lbBookQuantity.Text = (int.Parse(lbBookQuantity.Text) - 1).ToString();
        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            String name = bs.getBookName(txtBookID.Text);
            if (name != null)
                lbBookName.Text = name;
            else
                lbBookName.Text = "Sách không tồn tại";
        }

        private void btDone_Click(object sender, EventArgs e)
        {
            MessageBox.Show(add_Issue.Controls[add_Issue.Controls.IndexOfKey("flpListIssueBook")].ToString());
            this.bookName = lbBookName.Text== "Sách không tồn tại"?"": lbBookName.Text;
            this.bookQuantity = lbBookQuantity.Text;
            this.Close();
        }
    }
}
