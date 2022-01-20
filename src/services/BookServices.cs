
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
        libraryEntities db;
        public BookServices()
        {
            db = new libraryEntities();
        }


        public dynamic getListBook()
        {
            var ds = db.SACHes.Select(s => new
            {
                s.MaSach,
                s.TenSach,
                s.TacGia,
                s.NhaXuatBan,
                s.SoLuong,
                s.NamXuatBan
            }).ToList();
            return ds;
        }


        public String getBookName(String id)
        {
            var p = db.SACHes.Find(id);
            if (p != null)
            {
                return p.TenSach;
            }
            else
                return null;
        }

        public dynamic bookInfo(String bookId) 
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var sp = db.SACHes.Find(bookId);
                    if (sp != null)
                    {
                        return sp;
                    }
                    else return null;
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                return null;
            }
            
        }
        public void updateBook(dynamic book)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var b = db.SACHes.Find(book.MaSach);
                    if (b != null)
                    {
                        b.MaSach = book.MaSach;
                        b.TenSach = book.TenSach;
                        b.TacGia = book.TacGia;
                        b.SoLuong = book.SoLuong;
                        b.NamXuatBan = book.NamXuatBan;
                        b.NhaXuatBan = book.NhaXuatBan;
                        db.SaveChanges();
                    }
                    else MessageBox.Show("Error");
                }
            }catch (Exception ex)
            {
                MessageBox.Show(ex.Message);    
            }
        }
    }

}
