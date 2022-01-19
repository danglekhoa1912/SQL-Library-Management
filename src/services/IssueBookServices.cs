using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

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
    }
}
