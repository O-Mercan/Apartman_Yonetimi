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
    
    public partial class apartman_islemleri
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public apartman_islemleri()
        {
            this.daires = new HashSet<daire>();
        }
    
        public int id { get; set; }
        public string aparman_adi { get; set; }
        public string blok { get; set; }
        public string adres { get; set; }
        public Nullable<int> daire_sayisi { get; set; }
        public Nullable<int> yonetici_id { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<daire> daires { get; set; }
    }
}
