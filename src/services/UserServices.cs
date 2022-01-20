
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class UserServices
    {
        libraryEntities db;
        isValidInput valid;
        public UserServices()
        {
            db= new libraryEntities();
            valid= new isValidInput();
        }
        public bool addUser(String UserName,DateTime BirthDay,String PhoneNumber,String Email,String StudentId,String account,String pass)
        {
            int i = getQuanlityUser();
            try
            {
                db.pr_ThemDG("N" + (i + 1), UserName, BirthDay, PhoneNumber, Email, StudentId);
                db.pr_ThemTKDG(account, pass, "N" + (i + 1),true);
                return true;
            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                return false;
            }
        }

        public int getQuanlityUser()
        {
            int quanlity = 0;
            try
            {
                quanlity= db.DOCGIAs.Count();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return quanlity;
        }

        public String checkAccount(String account)
        {
            String userId = "";
            try
            {
                var p = db.TAIKHOANDOCGIAs.Find(account);
                if (p != null)
                    userId = p.MaDocGia;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return userId;
        }

        public String checkInforUser(String inforUser,int i)
        {
            String[] options = { "MSSV", "SoDienThoai", "Email" };
            var us=new DOCGIA();
            try
            {
                if (i == 0)
                {
                     us = db.DOCGIAs.Where(s => s.MSSV == inforUser).FirstOrDefault<DOCGIA>();
                }
                else if (i == 1)
                     us = db.DOCGIAs.Where(s => s.SoDienThoai == inforUser).FirstOrDefault<DOCGIA>();
                else
                     us = db.DOCGIAs.Where(s => s.Email == inforUser).FirstOrDefault<DOCGIA>();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return us!=null?us.MaDocGia:"";
        }

        public dynamic getListUser()
        {
            var ds = db.TAIKHOANDOCGIAs.Select(s => new
            {
                s.TaiKhoan,
                s.MaDocGia,
                s.DOCGIA.TenDocGia
            }).ToList();
            return ds;
        }

        public String checkUserAccount(String account, String password)
        {
            try
            {
                var us = db.TAIKHOANDOCGIAs.Where(s => s.TaiKhoan == account && s.MatKhau == password).FirstOrDefault<TAIKHOANDOCGIA>();
                if (us != null)
                    return us.MaDocGia;
            }
            catch (Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return String.Empty;
        }

        public TAIKHOANDOCGIA checkUser(String id)
        {
            return db.TAIKHOANDOCGIAs.Where(s => s.MaDocGia == id).FirstOrDefault<TAIKHOANDOCGIA>();

        }

        public void updateUser(dynamic user)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var b = db.DOCGIAs.Find(user.MaDocGia);
                    if (b != null)
                    {                        
                        b.TenDocGia = user.TenDocGia;
                        b.NamSinh = user.NamSinh;
                        b.SoDienThoai = user.SoDienThoai;
                        b.Email = user.Email;
                        b.MSSV = user.MSSV;
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


        public dynamic searchUser(String s)
        {
            dynamic ds;
            //s=valid.unAccent(s).ToUpper();
            ds = db.TAIKHOANDOCGIAs.Where(us => us.MaDocGia.ToUpper().IndexOf(s)!=-1 || us.TaiKhoan.ToUpper().IndexOf(s)!=-1 ||us.DOCGIA.TenDocGia.ToUpper().IndexOf(s)!=-1).Select(us => new
            {
                us.TaiKhoan,
                us.MaDocGia,
                us.DOCGIA.TenDocGia
            }).ToList();
            return ds;
        } 
        public DOCGIA getUser(String id)
        {
            try { 
                using (libraryEntities db=new libraryEntities())
                {
                    var p = db.DOCGIAs.Find(id);
                    if (p != null)
                    {
                        return p;
                    }
                    else
                        return null;
                } 
            }catch (Exception ex)
            {
                MessageBox.Show("Error");
                return null;
            }
        }
    }
}
