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
    public partial class Change_Password : MetroFramework.Forms.MetroForm
    {
        String Password;
        dynamic acount;
        services.UserServices us;
        services.AdminServices ads;
        services.isValidInput valid;
        public Change_Password(String id, int type)
        {
            InitializeComponent();
            us=new services.UserServices();
            ads=new services.AdminServices();
            valid=new services.isValidInput();
            if (type == 0) 
            {
                acount = us.checkUser(id);
            }
            else
            {
                acount=ads.checkUser(id);
            }
            Password = acount.MatKhau;
            txtPassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
              {
                  String s=txtPassword.Text;
                  lblErrorPassword.Text = s != Password ? "Incorrect password !" : String.Empty;
              });
            txtNewPassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtNewPassword.Text;
                lblErrorNewPassword.Text = !valid.isValidPassword(s) && s != "" ? "Password must be more than 8 characters including\n uppercase letters, special characters and numbers" : (s == "" ? "You must enter this information" : "");
                String s1 = txtRePassword.Text;
                txtRePassword.Text = "";
                txtRePassword.Text = s1;
            });
            txtRePassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e) {
                String s = txtRePassword.Text;
                lblErrorRePassword.Text = s != txtNewPassword.Text && s != "" ? "Re-Password doesn't match !" : (s == "" ? "You must enter this information!" : "");
            });
            btnSave.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                if (check())
                {
                    acount.MatKhau = txtNewPassword.Text;
                    if (type == 0)
                    {
                        us.changePassword(acount);
                        MessageBox.Show("Succesfully !");
                    }
                    else
                    {
                        ads.changePassword(acount);
                        MessageBox.Show("Succesfully !");
                    }
                    this.Close();
                }
                else MessageBox.Show("Invalid infomation ! ");
            });
        }
        public bool check()
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
    }
}
