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
            txtAccount.Focus();
            this.KeyPreview = true;
            btnLogin.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  loginHandle();
              });
            btnSignUp.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  this.Close();
                  SignUp signUp = new SignUp();
                  signUp.Show();
              });
        }
        private void loginHandle()
        {
            if (String.IsNullOrEmpty(txtAccount.Text.Trim()))
            {
                MessageBox.Show("Please enter username!");
                txtAccount.Focus();
                return;
            }

            if (String.IsNullOrEmpty(txtAccount.Text.Trim()))
            {
                MessageBox.Show("Please enter password!");
                txtAccount.Focus();
                return;
            }
            if (us.checkUserAccount(txtAccount.Text, txtPassword.Text) != String.Empty)
            {
                Main_User mainUser =new Main_User();
                mainUser.Id = us.checkUserAccount(txtAccount.Text,txtPassword.Text);
                this.Hide();
                mainUser.ShowDialog();
                this.Close();
            }
            else if (ads.checkAdmin(txtAccount.Text, txtPassword.Text) != String.Empty)
            {
                Main main = new Main();
                main.Id = ads.checkAdmin(txtAccount.Text, txtPassword.Text);
                this.Hide();
                main.ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Tài khoản không tồn tại");
            }
        }
        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
