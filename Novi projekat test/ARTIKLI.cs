//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Novi_projekat_test
{
    using System;
    using System.Collections.Generic;
    
    public partial class ARTIKLI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public ARTIKLI()
        {
            this.STAVKE = new HashSet<STAVKE>();
        }
    
        public int ID_ARTIKLA { get; set; }
        public string NAZIV_ARTIKLA { get; set; }
        public Nullable<decimal> CIJENA { get; set; }
        public string JED_MJERE { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAVKE> STAVKE { get; set; }
    }
}
