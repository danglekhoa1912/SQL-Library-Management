using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class IssueDetail
    {
        libraryEntities db;
        public IssueDetail()
        {
            db = new libraryEntities();
        }
        public int getQuantityIssueDetail()
        {
            int quanlity = 0;
            try
            {
                quanlity = db.CHITIETPHIEUMUONs.Count();
            }
            catch (SqlException ex)
            {
                MessageBox.Show(ex.Message);
            }
            return quanlity;
        }
        public void addIssueDetail(String bookId,String issueId,int quantity)
        {
            try
            {
                    CHITIETPHIEUMUON issueDetail = new CHITIETPHIEUMUON();
                issueDetail.MaChiTietPhieuMuon = getQuantityIssueDetail() + 1;
                issueDetail.TienPhat = 0;
                issueDetail.TinhTrang = "";
                    issueDetail.MaSach = bookId;
                    issueDetail.MaPhieuMuon = issueId;
                    issueDetail.SoLuong = quantity;
                    db.CHITIETPHIEUMUONs.Add(issueDetail);
                    db.SaveChanges();
            }
            catch(Exception e)
            {
                MessageBox.Show("Thêm thất bại");
            }
        }

    }
}
