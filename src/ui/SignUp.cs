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
    public partial class SignUp : MetroFramework.Forms.MetroForm
    {
        public SignUp()
        {
            InitializeComponent();
            txtName.TextChanged += new EventHandler(delegate(object sender,EventArgs e)
            {
                lblErrorUsername.Text = txtName.Text;
            });
        }

    }
}
