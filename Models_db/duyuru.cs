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
    
    public partial class duyuru
    {
        public int id { get; set; }
        public string duyuru_adi { get; set; }
        public string duyuru_konusu { get; set; }
        public string yonetici_id { get; set; }
        public string aciklama { get; set; }
        public Nullable<System.DateTime> tarih { get; set; }
    }
}
