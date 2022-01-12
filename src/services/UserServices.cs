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
        public bool addUser(User user,AccountUser accountUser)
        {
            SqlCommand sqlCommand = new SqlCommand();
            SqlConnection sqlConn = Connectdb.getConn();
            int i = getQuanlityUser();
            String query = String.Format("insert into DOCGIA(MaDocGia,TenDocGia,Email,MSSV,NamSinh,SoDienThoai)  values('{0}',N'{1}','{2}','{3}','{4}','{5}')"+
                "insert  into TAIKHOANDOCGIA(TaiKhoan,MatKhau,MaDocGia) values('{6}','{7}','{8}')"
                , "N"+(i+1), user.UserName, user.Email, user.StudentId, user.BirthDay, user.PhoneNumber, accountUser.Account,accountUser.Password,i+1);
            try
            {
                sqlCommand.Connection = sqlConn;
                sqlCommand.CommandText = query;
                sqlCommand.CommandType = CommandType.Text;

                sqlConn.Open();
                sqlCommand.ExecuteNonQuery();
                sqlConn.Close();
                return true;

            }
            catch(SqlException ex)
            {
                Console.Write(ex.Message);
                sqlConn.Close();
                return false;
            }
        }
        public User checkUserExists(String s)
        {
            return null;
        }
        public int getQuanlityUser()
        {
            SqlConnection sqlConn = Connectdb.getConn();
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
    }
}
