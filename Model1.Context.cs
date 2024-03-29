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
    
        public virtual int pr_ThemTKDG(string ten, string pass, string maTT, Nullable<bool> trangThai)
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
    
            var trangThaiParameter = trangThai.HasValue ?
                new ObjectParameter("trangThai", trangThai) :
                new ObjectParameter("trangThai", typeof(bool));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_ThemTKDG", tenParameter, passParameter, maTTParameter, trangThaiParameter);
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
    
        public virtual int pr_XoaTT(string ma)
        {
            var maParameter = ma != null ?
                new ObjectParameter("ma", ma) :
                new ObjectParameter("ma", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("pr_XoaTT", maParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    }
}
