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
        private SqlConnection sqlConn = new SqlConnection();
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
            String query = String.Format("Select Count(MaSach) from SACH");
            int quanlity = 0;
            try
            {
                SqlCommand sqlCommand = new SqlCommand(query, sqlConn);
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
