
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

        public bool addBook(String masach, String ten,int soluong,String tacgia, int namxb,String nhaxb)
        {
            try
            {
                db.pr_ThemSach(masach, ten, soluong, tacgia, namxb, nhaxb);
                return true;
            }catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
                return false;
            }
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
            var p = db.SACHes.FirstOrDefault(b=>b.MaSach==id);
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
                    var sp = db.SACHes.FirstOrDefault(b => b.MaSach==bookId);
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
                    String t=book.MaSach;
                    var b = db.SACHes.FirstOrDefault(s=>s.MaSach==t);
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
        public dynamic searchBook(String book)
        {
            book = book.ToUpper();
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    dynamic ds;
                    ds = db.SACHes.Where(b=> b.MaSach.ToUpper().IndexOf(book)!=-1 || b.TenSach.ToUpper().IndexOf(book)!=-1 || b.NamXuatBan.ToString().IndexOf(book)!=-1|| b.NhaXuatBan.ToUpper().IndexOf(book)!=-1).Select(b=> new
                    {
                        b.MaSach,
                        b.TenSach,
                        b.SoLuong,
                        b.TacGia,
                        b.NamXuatBan,
                        b.NhaXuatBan
                    }).ToList();
                    return ds;
                }
            }catch (Exception ex)
            {
                return null;
            }
        }
        public void deleteBook(String id)
        {
            try
            {
                using (libraryEntities db = new libraryEntities())
                {
                    var book=db.SACHes.FirstOrDefault(b=>b.MaSach==id);
                    db.SACHes.Remove(book);
                    db.SaveChanges();
                    MessageBox.Show("Succesfully!");
                }
            }catch(Exception ex)
            {
                MessageBox.Show("Error");
            }
        }
    }

}
