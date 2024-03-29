﻿using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Library_Management.src.services
{
    class IssueDetailServices
    {
        libraryEntities db;
        public IssueDetailServices()
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
        public void addIssueDetail(String bookId, String issueId, int quantity)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
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

            }
            catch (SqlException e)
            {
                MessageBox.Show(e.Message);
                MessageBox.Show("Thêm thất bại");
            }
        }

        public dynamic getListIssueDetail(String issueId)
        {
            var ds = db.CHITIETPHIEUMUONs.Where(s => s.MaPhieuMuon == issueId).Select(s => new { 
            s.MaChiTietPhieuMuon,
            s.MaSach,
            s.NgayTra,
            s.TienPhat,
            s.TinhTrang,
            s.SoLuong
            }).ToList();
            return ds;
        }

        public dynamic getInforIssueDetail(String issueDetailId)
        {
            try
            {
            var ds = db.CHITIETPHIEUMUONs.Find(int.Parse(issueDetailId));
                if (ds != null)
                    return ds;
            }catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            return null;
        }
        public int getTienPhat(int issueDetailId,DateTime returnDate)
        {
            try
            {
                var p = db.PHIEUMUONs.Join(db.CHITIETPHIEUMUONs, i => i.MaPhieuMuon, id => id.MaPhieuMuon, (i, id) => new
                {
                    id.MaChiTietPhieuMuon,
                    i.HanTra,
                }).Where(s=>s.MaChiTietPhieuMuon==issueDetailId).FirstOrDefault();
                if (p != null)
                {
                    TimeSpan t = p.HanTra - returnDate;
                    if(t.Days<0)
                        return t.Days;
                }

            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
            return 0;
        }

        public void updateIssueDetai(String issueDetailId,DateTime returnDate,String status,int penalty)
        {
            try
            {
                var p = db.CHITIETPHIEUMUONs.Find(int.Parse(issueDetailId));
                if(p!=null)
                {
                    p.NgayTra = returnDate;
                    p.TinhTrang = status;
                    p.TienPhat = penalty;
                    db.SaveChanges();
                }
            }catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }
        }

    }
}
