//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace E_Ticaret_MVC.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class Faturalar
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Faturalar()
        {
            this.FaturaDetay = new HashSet<FaturaDetay>();
        }
    
        public int FaturaID { get; set; }
        public Nullable<System.DateTime> Tarih { get; set; }
        public Nullable<int> MusteriID { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }
        public virtual Musteriler Musteriler { get; set; }
    }
}
