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
    
    public partial class Urunler
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Urunler()
        {
            this.BedenvsUrun = new HashSet<BedenvsUrun>();
            this.FaturaDetay = new HashSet<FaturaDetay>();
            this.Gorseller = new HashSet<Gorseller>();
            this.kampanya = new HashSet<kampanya>();
            this.Yorumlar = new HashSet<Yorumlar>();
        }
    
        public int UrunID { get; set; }
        public string UrunAdi { get; set; }
        public string UrunAciklama { get; set; }
        public Nullable<int> KategoriID { get; set; }
        public Nullable<System.DateTime> VitrineCikisTarih { get; set; }
        public Nullable<int> MarkaID { get; set; }
        public Nullable<decimal> BirimFiyat { get; set; }
        public Nullable<int> GirenAdet { get; set; }
        public Nullable<int> CikanAdet { get; set; }
        public Nullable<int> NetAdet { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<BedenvsUrun> BedenvsUrun { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<FaturaDetay> FaturaDetay { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Gorseller> Gorseller { get; set; }
        public virtual Kategori Kategori { get; set; }
        public virtual Markalar Markalar { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<kampanya> kampanya { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Yorumlar> Yorumlar { get; set; }
    }
}
