//------------------------------------------------------------------------------
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
    using System.Collections.Generic;
    
    public partial class TAIKHOANTHUTHU
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public TAIKHOANTHUTHU()
        {
            this.PHIEUMUONs = new HashSet<PHIEUMUON>();
        }
    
        public string TaiKhoan { get; set; }
        public string MatKhau { get; set; }
        public string MaThuThu { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<PHIEUMUON> PHIEUMUONs { get; set; }
        public virtual THUTHU THUTHU { get; set; }
    }
}
