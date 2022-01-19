﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Library_Management
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class libraryEntities : DbContext
    {
        public libraryEntities()
            : base("name=libraryEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<CHITIETPHIEUMUON> CHITIETPHIEUMUONs { get; set; }
        public virtual DbSet<DOCGIA> DOCGIAs { get; set; }
        public virtual DbSet<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual DbSet<SACH> SACHes { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TAIKHOANDOCGIA> TAIKHOANDOCGIAs { get; set; }
        public virtual DbSet<TAIKHOANTHUTHU> TAIKHOANTHUTHUs { get; set; }
        public virtual DbSet<THUTHU> THUTHUs { get; set; }
    
        public virtual int pr_KiemTraDG(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_KiemTraDG", maParameter);
        }
    
        public virtual int pr_KiemTraThuThu(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_KiemTraThuThu", maParameter);
        }
    
        public virtual int pr_KiemTraTKDG(string ten, string pass)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_KiemTraTKDG", tenParameter, passParameter);
        }
    
        public virtual int pr_KiemTraTKThuThu(string ten, string pass)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_KiemTraTKThuThu", tenParameter, passParameter);
        }
    
        public virtual int pr_KTSach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_KTSach", masachParameter);
        }
    
        public virtual int pr_ThemDG(string ma, string ten, Nullable<System.DateTime> nam, string sdt, string email, string mssv)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(System.DateTime));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            var mssvParameter = mssv != null ?
                new ObjectParameter("mssv", mssv) :
                new ObjectParameter("mssv", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemDG", maParameter, tenParameter, namParameter, sdtParameter, emailParameter, mssvParameter);
        }
    
        public virtual int pr_ThemSach(string masach, string ten, Nullable<int> sl, string tacgia, Nullable<int> namXB, string nhaXB)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var slParameter = sl.HasValue ?
                new ObjectParameter("sl", sl) :
                new ObjectParameter("sl", typeof(int));
    
            var tacgiaParameter = tacgia != null ?
                new ObjectParameter("tacgia", tacgia) :
                new ObjectParameter("tacgia", typeof(string));
    
            var namXBParameter = namXB.HasValue ?
                new ObjectParameter("namXB", namXB) :
                new ObjectParameter("namXB", typeof(int));
    
            var nhaXBParameter = nhaXB != null ?
                new ObjectParameter("nhaXB", nhaXB) :
                new ObjectParameter("nhaXB", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemSach", masachParameter, tenParameter, slParameter, tacgiaParameter, namXBParameter, nhaXBParameter);
        }
    
        public virtual int pr_ThemTKDG(string ten, string pass, string maTT)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var maTTParameter = maTT != null ?
                new ObjectParameter("maTT", maTT) :
                new ObjectParameter("maTT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemTKDG", tenParameter, passParameter, maTTParameter);
        }
    
        public virtual int pr_ThemTKThuThu(string ten, string pass, string maTT)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var passParameter = pass != null ?
                new ObjectParameter("pass", pass) :
                new ObjectParameter("pass", typeof(string));
    
            var maTTParameter = maTT != null ?
                new ObjectParameter("maTT", maTT) :
                new ObjectParameter("maTT", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemTKThuThu", tenParameter, passParameter, maTTParameter);
        }
    
        public virtual int pr_ThemTT(string ma, string ten, Nullable<System.DateTime> nam, string sdt, string email)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            var namParameter = nam.HasValue ?
                new ObjectParameter("nam", nam) :
                new ObjectParameter("nam", typeof(System.DateTime));
    
            var sdtParameter = sdt != null ?
                new ObjectParameter("sdt", sdt) :
                new ObjectParameter("sdt", typeof(string));
    
            var emailParameter = email != null ?
                new ObjectParameter("email", email) :
                new ObjectParameter("email", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemTT", maParameter, tenParameter, namParameter, sdtParameter, emailParameter);
        }
    
        public virtual int pr_XoaDG(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_XoaDG", maParameter);
        }
    
        public virtual int pr_XoaSach(string masach)
        {
            var masachParameter = masach != null ?
                new ObjectParameter("masach", masach) :
                new ObjectParameter("masach", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_XoaSach", masachParameter);
        }
    
        public virtual int pr_XoaTKDG(string ten)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_XoaTKDG", tenParameter);
        }
    
        public virtual int pr_XoaTKThuThu(string ten)
        {
            var tenParameter = ten != null ?
                new ObjectParameter("ten", ten) :
                new ObjectParameter("ten", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_XoaTKThuThu", tenParameter);
        }
    }
}
