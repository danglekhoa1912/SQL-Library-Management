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
            MessageBox.Show(us.checkUser(txtUserID.Text).ToString());
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {

        }

        private void txtBookID_TextChanged(object sender, EventArgs e)
        {
            lbBookName.Text = bs.getBookName(txtBookID.Text);
        }
    }
}
