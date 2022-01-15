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
            SqlCommand sqlCommand = new SqlCommand();
            int i = getQuanlityUser();
            String query = String.Format("insert into DOCGIA(MaDocGia,TenDocGia,Email,MSSV,NamSinh,SoDienThoai)  values('{0}',N'{1}','{2}','{3}','{4}','{5}')"+
                "insert  into TAIKHOANDOCGIA(MaTaiKhoanDocGia,TaiKhoan,MatKhau,MaDocGia) values('{6}','{7}','{8}','{0}')"
                , "N"+(i+1), user.UserName, user.Email, user.StudentId, user.BirthDay, user.PhoneNumber,i+1 ,accountUser.Account,accountUser.Password);
            sqlCommand.Connection = sqlConn;
            sqlCommand.CommandText = query;
            sqlCommand.CommandType = CommandType.Text;
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
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query,sqlConn);
                sqlConn.Open();
                quanlity = (int)sqlCommand.ExecuteScalar();
                sqlConn.Close();
                return quanlity;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                sqlConn.Close();
                return quanlity;
            }
        }

        public String checkAccount(String account)
        {
            String query = String.Format("Select MaDocGia from TAIKHOANDOCGIA where TaiKhoan='{0}'", account);
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
                sqlConn.Close();
                return userId;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                sqlConn.Close();
                return userId;
            }
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
                sqlConn.Close();
                return userId;
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
                sqlConn.Close();
                return userId;
            }
        }
        
    }
}
