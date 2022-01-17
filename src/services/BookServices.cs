using Library_Management.src.configs;
using Library_Management.src.pojo;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class BookServices
    {
        private SqlConnection sqlConn = Connectdb.getConn();
        public bool addBook(Book book)
        {
            int quanlityBook = getQuanlityBook();
            String query = String.Format("insert into SACH(MaSach,TenSach,SoLuong,TacGia,NamXuatBan,NhaXuatBan) values('{0}','{1}','{2}','{3}','{4}','{5}')","S"+quanlityBook+1,book.BookName,book.Quantily,book.Author,book.PublishingYear,book.Publisher);
            SqlCommand sqlCommand = new SqlCommand(query,sqlConn);
            sqlConn.Open();
            try
            {
                sqlCommand.ExecuteNonQuery();
                sqlConn.Close();
                return true;

            }
            catch (SqlException ex)
            {
                Console.WriteLine(ex.Message);
                sqlConn.Close();
                return false;
            }
        }

        public int getQuanlityBook()
        {
            String query = "Select Count(MaSach) from SACH";
            int quanlity = 0;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
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

        public Book getBookById(String id)
        {
            String query = String.Format("Select * from SACH where MaSach='{0}'", id);
            Book book=null;
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
                        book = new Book(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));                   
                    }
                   }
            }
            catch(SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return book;
        }

        public Book getBookByName(String name)
        {
            String query = String.Format("Select * from SACH where TenSach=N'{0}'", name);
            Book book = null;
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
                        book = new Book(reader.GetString(0), reader.GetString(1), reader.GetInt32(2), reader.GetString(3), reader.GetInt32(4), reader.GetString(5));
                    }
                }
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            sqlConn.Close();
            return book;
        }
    }

}
