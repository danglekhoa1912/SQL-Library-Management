
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



    }

}
