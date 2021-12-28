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
        public Login()
        {
            InitializeComponent();
            btnLogin.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  //do some thing
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
