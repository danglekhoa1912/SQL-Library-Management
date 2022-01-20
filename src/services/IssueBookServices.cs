using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class IssueBookServices
    {
        libraryEntities db;
        public IssueBookServices()
        {
            db = new libraryEntities();
        }
        public dynamic getIssueBook()
        {
            var ds = db.PHIEUMUONs.Select(s => new
            {
                s.MaPhieuMuon,
                s.NgayMuon,
                s.TongTienPhat,
                s.HanTra,
                s.TrangThai,
                s.TaiKhoanThuThu,
                s.TaiKhoanDocGia
            }).ToList();
            return ds;
        }

        public void addIssueBook(DateTime issueDate, DateTime returnDate, String accountUser)
        {

            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    PHIEUMUON issueBook = new PHIEUMUON();
                    issueBook.MaPhieuMuon = "PM" + (getQuantityIssue() + 1);
                    issueBook.NgayMuon = issueDate;
                    issueBook.TongTienPhat = 0;
                    issueBook.HanTra = returnDate;
                    issueBook.TrangThai = false;
                    issueBook.TaiKhoanThuThu = "thuthu1";
                    issueBook.TaiKhoanDocGia = accountUser;
                    db.PHIEUMUONs.Add(issueBook);
                    db.SaveChanges();
                }


            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Thêm phiếu mượn thất bại");
            }
        }

        public int getQuantityIssue()
        {
            int quanlity = 0;
            try
            {
                quanlity = db.PHIEUMUONs.Count();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return quanlity;
        }
    }
}
