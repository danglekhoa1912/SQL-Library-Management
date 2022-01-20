using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class AdminServices
    {
        libraryEntities db;
        public AdminServices()
        {
            db = new libraryEntities();
        }
        public bool checkAdmin(String account,String password)
        {
            MessageBox.Show(account + " " + password);
            MessageBox.Show(db.pr_KiemTraTKThuThu(account, password).ToString());
            return db.pr_KiemTraTKThuThu(account, password) == 1;
        }
    }
}
