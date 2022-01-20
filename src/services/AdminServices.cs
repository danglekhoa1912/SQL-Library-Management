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
            return String.Empty;
        }
        public TAIKHOANTHUTHU checkUser(String id)
        {
            return db.TAIKHOANTHUTHUs.Where(s => s.MaThuThu == id).FirstOrDefault<TAIKHOANTHUTHU>();
        }
        public THUTHU getUser(String id)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var p = db.THUTHUs.FirstOrDefault(s=>s.MaThuThu==id);
                    if (p != null)
                    {
                        return p;
                    }
                    else
                        return null;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error 1");
                return null;
            }
        }
        public String checkInforUser(String inforUser, int i)
        {
            String[] options = { "MSSV", "SoDienThoai", "Email" };
            var us = new THUTHU();
            try
            {
                if (i == 0)
                {
                    return "";
                }
                else if (i == 1)
                    us = db.THUTHUs.Where(s => s.SoDienThoai == inforUser).FirstOrDefault<THUTHU>();
                else
                    us = db.THUTHUs.Where(s => s.Email == inforUser).FirstOrDefault<THUTHU>();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return us != null ? us.MaThuThu : "";
        }
        public void updateUser(dynamic user)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    String id = user.MaThuThu;
                    var b = db.THUTHUs.FirstOrDefault(u => u.MaThuThu == id);
                    if (b != null)
                    {
                        b.TenThuThu = user.TenThuThu;
                        b.NamSinh = user.NamSinh;
                        b.SoDienThoai = user.SoDienThoai;
                        b.Email = user.Email;
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Error");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool changePassword(dynamic u)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    String id = u.MaThuThu;
                    var b = db.TAIKHOANTHUTHUs.FirstOrDefault(s => s.MaThuThu == id);
                    if (b != null)
                    {
                        b.MatKhau = u.MatKhau;
                        db.SaveChanges();
                        return true;
                    }
                    else return false;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }
    }
}
