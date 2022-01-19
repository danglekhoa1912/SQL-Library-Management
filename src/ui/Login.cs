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
    public partial class Login : MetroFramework.Forms.MetroForm
    {
        UserServices us = new UserServices();
        AdminServices ads = new AdminServices();
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  if (us.checkUser(txtAccount.Text, txtPassword.Text))
                  {
                      MessageBox.Show("User");
                  }
                  else if(ads.checkAdmin(txtAccount.Text, txtPassword.Text))
                  {
                      MessageBox.Show("Admin");
                  }
                  else
                  {
                      MessageBox.Show("Tài khoản không tồn tại");
                  }
              });
            btnSignUp.Click += new EventHandler(delegate (object sender, EventArgs e)
              {

              });
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
