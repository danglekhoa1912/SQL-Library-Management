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
        private FlowLayoutPanel flpIB = new FlowLayoutPanel();
        private String bookName, bookQuantity;

        public string BookName { get => bookName; set => bookName = value; }
        public string BookQuantity { get => bookQuantity; set => bookQuantity = value; }
        public FlowLayoutPanel FlpIB { get => flpIB; set => flpIB = value; }

        public Add_IssueBook()
        {
            InitializeComponent();
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbBookQuantity.Text) <= 3)
                lbBookQuantity.Text = (int.Parse(lbBookQuantity.Text) + 1).ToString();
        }

        private void btnMinus_Click(object sender, EventArgs e)
        {
            if (int.Parse(lbBookQuantity.Text) > 0)
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
            foreach (Control i in flpIB.Controls)
            {
                if (i.Controls[0].Controls[0].Text == lbBookName.Text)
                {
                    MessageBox.Show("Bạn đã mượn cuốn này");
                    return;
                }
            }
            this.bookName = lbBookName.Text == "Sách không tồn tại" ? "" : lbBookName.Text;
            this.bookQuantity = lbBookQuantity.Text;
            this.Close();
        }
    }
}
