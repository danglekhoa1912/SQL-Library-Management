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
        IssueDetailServices ids = new IssueDetailServices();
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


        public dynamic getUserBook(string tk)
        {
            var ds = (from p in db.CHITIETPHIEUMUONs
                      join t in db.PHIEUMUONs on p.MaPhieuMuon equals t.MaPhieuMuon
                      where t.TaiKhoanDocGia == tk
                      select new
                      {
                          p.MaChiTietPhieuMuon,
                          p.MaSach,
                          p.SACH.TenSach,
                          p.MaPhieuMuon,
                          p.NgayTra,
                          p.TienPhat,
                          p.TinhTrang,
                          p.SoLuong
                      }).ToList();
            return ds;
        }

        public int getQuantityBookUserIssue(String account)
        {
            int quantity = 0;
            try
            {
                var p = (db.PHIEUMUONs.Join(db.CHITIETPHIEUMUONs, i => i.MaPhieuMuon, id => id.MaPhieuMuon, (i, id) => new
                {
                    i.TaiKhoanDocGia,
                    i.TrangThai,
                    id.SoLuong
                })).Where(s=>s.TaiKhoanDocGia==account&&s.TrangThai==false);
                if (p != null)
                {
                    foreach (var i in p)
                    {
                        quantity += i.SoLuong ;
                    }
                }
            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
            }

            return quantity;
        }
        public int getTongTienPhat(string maPhieuMuon)//Hàm này sẽ cho phiếu mượn cập nhật lại tổng tiền phạt
        {
            int count = 0;
            using (libraryEntities lb = new libraryEntities())
            {
                var p = lb.PHIEUMUONs.FirstOrDefault(s => s.MaPhieuMuon == maPhieuMuon);
                count = lb.CHITIETPHIEUMUONs.Where(s => s.MaPhieuMuon == maPhieuMuon).Select(s => s.TienPhat).Sum();
                if (p != null && count != 0)
                {
                    p.TongTienPhat = count;
                    lb.SaveChanges();
                }
            }
            return count;
        }

        public void updateIssue(String issueId)
        {
            int tongTien = 0;
            bool status=true;
            try
            {
                var p1 = db.PHIEUMUONs.Find(issueId);
                var p = db.PHIEUMUONs.Join(db.CHITIETPHIEUMUONs, i => i.MaPhieuMuon, id => id.MaPhieuMuon, (i, id) => new
                {
                    i.MaPhieuMuon,
                    i.TongTienPhat,
                    i.TrangThai,
                    id.TienPhat,
                    id.TinhTrang,
                    id.MaSach,id.SoLuong
                }).Where(s=>s.MaPhieuMuon==issueId);
                if (p != null&&p1!=null)
                {
                    foreach(var isb in p)
                    {
                        tongTien += isb.TienPhat;
                        if (isb.TinhTrang == "")
                            status = false;
                        else
                        {
                            var book = db.SACHes.Find(isb.MaSach);
                            book.SoLuong = book.SoLuong + isb.SoLuong;
                        }
                    }

                    p1.TongTienPhat = tongTien;
                    p1.TrangThai = status;
                    db.SaveChanges();
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
