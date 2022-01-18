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





    }

}
