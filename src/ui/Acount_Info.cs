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
    public partial class Acount_Info : MetroFramework.Forms.MetroForm
    {
        int type;
        src.services.isValidInput valid;
        src.services.AdminServices ads;
        src.services.UserServices us;
        dynamic user;
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
        public Acount_Info(String id)
        {
            InitializeComponent();
            ads= new src.services.AdminServices();
            us= new src.services.UserServices();
            valid = new src.services.isValidInput();
            if (us.getUser(id) != null)
            {
                user = us.getUser(id);
                type = 0;
            }
            else {
                user = ads.getUser(id);
                type = 1;
            }
            txtName.Text = type == 0 ? user.TenDocGia : user.TenThuThu;
            dtpNamSinh.Value = user.NamSinh;
            txtEmail.Text = user.Email;
            txtMobile.Text = user.SoDienThoai;
            txtStudentID.Text = type ==0?user.StudentID:"ADMIN ACCOUNT !";
            txtStudentID.Enabled=type==0?true:false;
            txtName.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtName.Text;
                lblErrorName.Text = valid.isValidName(s) && s != "" ? "Invalid full name !" : (s == "" ? "You must enter this information!" : "");
            });
            txtName.Leave += new EventHandler(delegate (object sender, EventArgs e)
            {
                txtName.Text = txtName.Text != "" ? valid.styleString(txtName.Text) : txtName.Text;
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
                if (us.checkInforUser(s, 1) != "" || ads.checkInforUser(s,1)!="")
                {
                    lblErrorMobile.Text = "Moblie already exists!";
                }
                else
                    lblErrorMobile.Text = !valid.isValidMoblie(s) && s != "" ? "Invalid moblie !" : (s == "" ? "You must enter this information !" : "");
            });
            txtEmail.TextChanged += new EventHandler(delegate (object sender, EventArgs e)
            {
                String s = txtEmail.Text;
                if (us.checkInforUser(s, 2) != "" || ads.checkInforUser(s,2)!="")
                {
                    lblErrorEmail.Text = "Email already exists!";
                }
                else
                    lblErrorEmail.Text = !valid.isValidEmail(s) && s != "" ? "Invalid email !" : (s == "" ? "You must enter this information !" : "");
            });
            btnSave.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  if (validSignUp())
                  {
                      try
                      {
                          //update;
                          if (type==0){
                              dynamic u = us.getUser(user.MaDocGia);
                              u.TenDocGia = txtName.Text;
                              u.NamSinh = dtpNamSinh.Value;
                              u.SoDienThoai = txtMobile.Text;
                              u.Email = txtEmail.Text;
                              u.MSSV = txtStudentID.Text;
                              us.updateUser(u);
                              MessageBox.Show("Succesfully !");
                          }
                          else
                          {
                              dynamic u = ads.getUser(user.MaThuThu);
                              u.TenThuThu = txtName.Text;
                              u.NamSinh = dtpNamSinh.Value;
                              u.SoDienThoai = txtMobile.Text;
                              u.Email = txtEmail.Text;
                              ads.updateUser(u);
                              MessageBox.Show("Succesfully !");
                          }
                          this.Close();
                      } catch (Exception ex)
                      {
                          MessageBox.Show(ex.Message);
                      }
                  }
                  else
                  {
                      MessageBox.Show("Invalid information! Please check again.");
                  }
              });
            btnCancel.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                this.Close();
            });
            btnChangePassword.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                Change_Password change =new Change_Password(id,type);
                change.ShowDialog();
            });
        }
    }
}
