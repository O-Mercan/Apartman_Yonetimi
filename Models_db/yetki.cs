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
    
    public partial class yetki
    {
        public int id { get; set; }
        public string tc_no { get; set; }
        public Nullable<byte> gelir_islemleri { get; set; }
        public Nullable<byte> gider_islemleri { get; set; }
        public Nullable<byte> kasa_islemleri { get; set; }
        public Nullable<byte> borc_islemleri { get; set; }
        public Nullable<byte> daire_islemleri { get; set; }
        public Nullable<byte> kullanici_islemleri { get; set; }
    }
}
