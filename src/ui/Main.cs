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
    public partial class Main : MetroFramework.Forms.MetroForm
    {
        int choice=0;
        public Main()
        {
            InitializeComponent();
            btnUser.Click += new EventHandler(delegate (object sender, EventArgs e)
              {
                  initUserTable();
              });
            btnBook.Click += new EventHandler(delegate (object sender, EventArgs e)
            {
                initBookTable();
            });
            btnIssueBook.Click += new EventHandler(delegate (Object sender, EventArgs e)
              {
                  initBookIssue();
              });
        }

        private void Main_Load(object sender, EventArgs e)
        {
        }
        private void initUserTable()
        {
            choice=0;
            // Đổ dữ liệu vào grid view
        }
        private void initBookTable()
        {
            choice = 1;
            //Đổ dữ liệu vào grid view
        }
        private void initBookIssue()
        {
            choice = 2;
            // Đổ dữ liệu vào grid view
        }
    }
}
