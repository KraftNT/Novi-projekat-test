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
    
    public partial class DOKUMENTI
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public DOKUMENTI()
        {
            this.STAVKE = new HashSet<STAVKE>();
        }
    
        public int ID_DOKUMENTA { get; set; }
        public Nullable<System.DateTime> DATUM { get; set; }
        public Nullable<int> ID_KOMITENTA { get; set; }
        public string NAZIV_KOMITENTA { get; set; }
        public Nullable<decimal> IZNOS { get; set; }
        public string DETALJI { get; set; }
    
        public virtual KOMITENTI KOMITENTI { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<STAVKE> STAVKE { get; set; }
    }
}