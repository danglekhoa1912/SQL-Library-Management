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
        public String checkAdmin(String account,String password)
        {
            try
            {
                var us = db.TAIKHOANTHUTHUs.Where(s => s.TaiKhoan == account && s.MatKhau == password).FirstOrDefault<TAIKHOANTHUTHU>();
                if (us != null)
                    return us.MaThuThu;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return "";
        }
    }
}
