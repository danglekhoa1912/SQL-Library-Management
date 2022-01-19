using Library_Management.src.configs;
using Library_Management.src.pojo;
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
        public UserServices()
        {
            db= new libraryEntities();
        }
        private SqlConnection sqlConn = Connectdb.getConn();
        public bool addUser(User user,AccountUser accountUser)
        {
            int i = getQuanlityUser();
            String query = String.Format("insert into DOCGIA(MaDocGia,TenDocGia,Email,MSSV,NamSinh,SoDienThoai)  values('{0}',N'{1}','{2}','{3}','{4}','{5}')"+
                "insert  into TAIKHOANDOCGIA(TaiKhoan,MatKhau,MaDocGia) values('{6}','{7}','{0}')"
                , "N"+(i+1), user.UserName, user.Email, user.StudentId, user.BirthDay, user.PhoneNumber,accountUser.Account,accountUser.Password);
            SqlCommand sqlCommand = new SqlCommand(query,sqlConn);
            sqlConn.Open();
            SqlTransaction transaction = sqlConn.BeginTransaction();
            sqlCommand.Transaction = transaction;
            try
            {               
                sqlCommand.ExecuteNonQuery();
                transaction.Commit();
                sqlConn.Close();
                return true;

            }
            catch(SqlException ex)
            {
                Console.WriteLine(ex.Message);
                transaction.Rollback();
                sqlConn.Close();
                return false;
            }
        }

        public int getQuanlityUser()
        {
            String query = String.Format("Select Count(MaDocGia) from DOCGIA");
            int quanlity = 0;
            SqlCommand sqlCommand = new SqlCommand(query,sqlConn);
            try
            {
                sqlConn.Open();
                quanlity = (int)sqlCommand.ExecuteScalar();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return quanlity;
        }

        public String checkAccount(String account)
        {
            String query = String.Format("Select MaDocGia from TAIKHOANDOCGIA where TaiKhoan='{0}'", account);
            String userId = "";
            SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
            try
            {
                sqlConn.Open();
                var reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        userId = reader.GetString(0);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return userId;
        }

        public String checkInforUser(String inforUser,int i)
        {
            String[] options = { "MSSV", "SoDienThoai", "Email" };
            String query = String.Format("Select MaDocGia from DOCGIA where {0}='{1}'", options[i], inforUser);
            String userId = "";
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
                sqlConn.Open();
                var reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    // Đọc từng dòng tập kết quả
                    while (reader.Read())
                    {
                        userId = reader.GetString(0);
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return userId;
        }

        public dynamic getListUser()
        {
            var ds = db.TAIKHOANDOCGIAs.Select(s => new
            {
                s.TaiKhoan,
                s.MatKhau,
                s.MaDocGia,
                s.DOCGIA.TenDocGia
            }).ToList();
            return ds;
        }
        
        public dynamic getUser(String id)
        {
            var ds=db.DOCGIAs.Find(id);
            if (ds == null)
            {
                return null;
            }
            else return ds;
        }

        public void updateUser(dynamic user)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var u = db.DOCGIAs.Find(user.MaDocGia);
                    if (u != null)
                    {
                        u.TenDocGia = user.TenDocGia;
                        u.NamSinh = user.NamSinh;
                        u.SoDienThoai = user.SoDienThoai;
                        u.Email = user.Email;
                        u.MSSV = user.MSSV;
                        db.SaveChanges();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
        public bool checkUser(String account,String password)
        {
            return db.pr_KiemTraTKDG(account, password)==1;
        }

    }
}
