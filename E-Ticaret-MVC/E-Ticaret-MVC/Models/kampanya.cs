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
    
    public partial class kampanya
    {
        public int kampanyaID { get; set; }
        public string KampanyaBasligi { get; set; }
        public string Aciklama { get; set; }
        public string Resim { get; set; }
        public Nullable<System.DateTime> BaslangicTarihi { get; set; }
        public Nullable<int> UrunID { get; set; }
        public Nullable<System.DateTime> BitisTarihi { get; set; }
    
        public virtual Urunler Urunler { get; set; }
    }
}