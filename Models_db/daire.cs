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
    
    public partial class daire
    {
        public int id { get; set; }
        public string tipi { get; set; }
        public Nullable<decimal> kira_tutari { get; set; }
        public Nullable<decimal> aidat { get; set; }
        public int apartman_id { get; set; }
        public string daire_no { get; set; }
    
        public virtual apartman_islemleri apartman_islemleri { get; set; }
    }
}
