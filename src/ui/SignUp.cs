using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using Library_Management.src.services;
using Library_Management.src.pojo;

namespace Library_Management.src.ui
{
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        services.isValidInput valid=new services.isValidInput();
        private UserServices us = new UserServices(); 
        private bool validSignUp()
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
        public SignUp()
        {
            InitializeComponent();
            txtName.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s=txtName.Text;
                lblErrorFullname.Text = valid.isValidName(s) && s != "" ? "Invalid full name !" : (s==""? "You must enter this information!" : "");
            });
            txtName.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                txtName.Text=txtName.Text!=""?valid.styleString(txtName.Text):txtName.Text;
            });
            txtUName.TextChanged += new EventHandler(delegate (object sender, EventArgs e) { 
                String s=txtUName.Text;
                lblErrorUName.Text = valid.isValidUserName(s) && s != "" ? "Invalid User Name !" : (s == "" ? "You must enter this inforamtion!" : "");
            });
            txtPassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s=txtPassword.Text;
                lblErrorPassword.Text = !valid.isValidPassword(s) && s != "" ? "Password must be more than 8 characters including\n uppercase letters, special characters and numbers" : (s == "" ? "You must enter this information" : "");
                String s1=txtRePassword.Text;
                txtRePassword.Text = "";
                txtRePassword.Text = s1;
            });
            txtRePassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e) { 
                String s=txtRePassword.Text;
                lblErrorRePassword.Text = s!=txtPassword.Text && s!=""?"Re-Password doesn't match !":(s==""?"You must enter this information!":"");
            });
            txtStudentID.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s=txtStudentID.Text;
                lblErrorStudentID.Text = !valid.isValidStdId(s) && s != "" ? "Student Id must have 10 numeric characters" : (s == "" ? "You must enter this information!" : "");
            });
            txtMobile.TextChanged += new EventHandler(delegate (object sender, EventArgs e) { 
                String s= txtMobile.Text;
                lblErrorMobile.Text=!valid.isValidMoblie(s) && s!="" ?"Invalid moblie !":(s==""?"You must enter this information !":"");
            });
            txtEmail.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s=txtEmail.Text;
                lblErrorEmail.Text = !valid.isValidEmail(s) && s != "" ? "Invalid email !" : (s == "" ? "You must enter this information !" : "");
            });
            cbAgree.CheckedChanged += new EventHandler(delegate (object sender, EventArgs e) { 
                btnRegister.Enabled = !btnRegister.Enabled;
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
                        if ((label as Label).ForeColor==Color.Red)
                            (label as Label).Text = string.Empty;
                    }
                }
                cbAgree.Checked = false;
            });
            btnRegister.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                MessageBox.Show(us.checkInforUser("1111111111", 0));
                MessageBox.Show(us.checkInforUser("1111111111", 1));
                MessageBox.Show(us.checkInforUser("1@gmail.com", 2));
                if (validSignUp())
                {
                    //do something
                    User user = new User( txtName.Text, txtEmail.Text, txtStudentID.Text, dtpBirthday.Value, txtMobile.Text);
                    AccountUser accountUser = new AccountUser(txtUName.Text, txtPassword.Text, true);
                    if (us.addUser(user, accountUser))
                    {
                        MessageBox.Show("Sign up sucessfully! You can use account for sign in");
                        this.Close();
                    }
                    else
                    { 
                        MessageBox.Show("Invalid information! Please check again.");
                    }
                }
                else
                {
                    MessageBox.Show("Invalid information! Please check again.");
                }
            });
        }
    }
}
