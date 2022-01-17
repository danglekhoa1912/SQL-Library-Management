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

        public AccountUser checkUser(String account,String password)
        {
            String query = String.Format("select *  from TAIKHOANDOCGIA where TaiKhoan='{0}' and MatKhau='{1}'", account, password);
            AccountUser user = null;
            SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
            try
            {
                sqlConn.Open();
                var reader = sqlCommand.ExecuteReader();
                if (reader.HasRows)
                {
                    while (reader.Read())
                    {
                        // Đọc từng dòng tập kết quả
                        user = new AccountUser(reader.GetString(0), reader.GetString(1), reader.GetBoolean(2), reader.GetString(3));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return user;

        }
        
    }
}
