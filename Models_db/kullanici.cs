//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Apartman_Yonetimi_ms.Models_db
{
    using System;
    using System.Collections.Generic;
    
    public partial class kullanici
    {
        public int id { get; set; }
        public string tc_no { get; set; }
        public string ad { get; set; }
        public string soyad { get; set; }
        public string email { get; set; }
        public string telefon { get; set; }
        public Nullable<int> apartman_id { get; set; }
        public string daire_no { get; set; }
        public string ev_durumu { get; set; }
        public string rol { get; set; }
        public string sifre { get; set; }
    }
}
