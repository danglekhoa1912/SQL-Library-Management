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
    public partial class IssueBookUC : UserControl
    {
        public IssueBookUC(String bookname, String quantity)
        {
            InitializeComponent();
            lbBookName.Text = bookname;
            lbQuantityBook.Text = quantity;
        }
    }
}
