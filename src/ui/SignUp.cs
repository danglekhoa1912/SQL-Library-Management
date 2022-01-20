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
        //update information user
        public SignUp(dynamic user)
        {
            this.InitializeComponent();
            txtUName.Text = "Security information !";
            txtUName.Enabled = false;
            txtPassword.Text = "********";
            txtPassword.Enabled = false;
            txtRePassword.Text=txtPassword.Text;
            txtRePassword.Enabled = false;
            txtName.Text = user.TenDocGia;
            txtMobile.Text = user.SoDienThoai;
            txtStudentID.Text = user.MSSV;
            txtEmail.Text = user.Email;
            dtpBirthday.Value = user.NamSinh;
            initControl();
            cbAgree.Checked = true;
            cbAgree.Visible = false;
            btnRegister.Text = "Save Change";
            btnClear.Text = "Cancel";
            btnClear.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                this.Close();
            });
            btnRegister.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                if (validSignUp())
                {
                    //update;
                    dynamic u=us.getUser(user.MaDocGia);
                    u.TenDocGia=txtName.Text;
                    u.NamSinh=dtpBirthday.Value;
                    u.SoDienThoai=txtMobile.Text;
                    u.Email=txtEmail.Text;
                    u.MSSV=txtStudentID.Text;
                    us.updateUser(u);
                    MessageBox.Show("Succesfully !");
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Invalid information! Please check again.");
                }
            });
        }
        // Sign up for new user
        public SignUp()
        {
            InitializeComponent();
            initControl();
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
                        if ((label as Label).ForeColor == Color.Red)
                            (label as Label).Text = string.Empty;
                    }
                }
                cbAgree.Checked = false;
            });
            btnRegister.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                if (validSignUp())
                {
                    //do something
                    if (us.addUser(txtName.Text, dtpBirthday.Value, txtMobile.Text, txtEmail.Text, txtStudentID.Text, txtUName.Text, txtPassword.Text))
                    {
                        MessageBox.Show("Sign up sucessfully! You can use account for sign in");
                        this.Close();
                        Login login = new Login();
                        login.Show();
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
        private void initControl()
        {
            txtName.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtName.Text;
                lblErrorFullname.Text = valid.isValidName(s) && s != "" ? "Invalid full name !" : (s == "" ? "You must enter this information!" : "");
            });
            txtName.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                txtName.Text = txtName.Text != "" ? valid.styleString(txtName.Text) : txtName.Text;
            });
            txtUName.TextChanged += new EventHandler(delegate (object sender, EventArgs e) {
                String s = txtUName.Text;
                if (us.checkAccount(s) != "")
                {
                    lblErrorUName.Text = "Account already exists!";
                }
                else
                    lblErrorUName.Text = valid.isValidUserName(s) && s != "" ? "Invalid User Name !" : (s == "" ? "You must enter this inforamtion!" : "");
            });
            txtPassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtPassword.Text;
                lblErrorPassword.Text = !valid.isValidPassword(s) && s != "" ? "Password must be more than 8 characters including\n uppercase letters, special characters and numbers" : (s == "" ? "You must enter this information" : "");
                String s1 = txtRePassword.Text;
                txtRePassword.Text = "";
                txtRePassword.Text = s1;
            });
            txtRePassword.TextChanged += new EventHandler(delegate (object sender, EventArgs e) {
                String s = txtRePassword.Text;
                lblErrorRePassword.Text = s != txtPassword.Text && s != "" ? "Re-Password doesn't match !" : (s == "" ? "You must enter this information!" : "");
            });
            txtStudentID.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtStudentID.Text;
                if (us.checkInforUser(s, 0) != "")
                {
                    lblErrorStudentID.Text = "Student Id already exists!";
                }
                else
                    lblErrorStudentID.Text = !valid.isValidStdId(s) && s != "" ? "Student Id must have 10 numeric characters" : (s == "" ? "You must enter this information!" : "");
            });
            txtMobile.TextChanged += new EventHandler(delegate (object sender, EventArgs e) {
                String s = txtMobile.Text;
                if (us.checkInforUser(s, 1) != "")
                {
                    lblErrorMobile.Text = "Moblie already exists!";
                }
                else
                    lblErrorMobile.Text = !valid.isValidMoblie(s) && s != "" ? "Invalid moblie !" : (s == "" ? "You must enter this information !" : "");
            });
            txtEmail.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtEmail.Text;
                if (us.checkInforUser(s, 2) != "")
                {
                    lblErrorEmail.Text = "Email already exists!";
                }
                else
                    lblErrorEmail.Text = !valid.isValidEmail(s) && s != "" ? "Invalid email !" : (s == "" ? "You must enter this information !" : "");
            });
            cbAgree.CheckedChanged += new EventHandler(delegate (object sender, EventArgs e) {
                btnRegister.Enabled = !btnRegister.Enabled;
            });
        }
    }
}
