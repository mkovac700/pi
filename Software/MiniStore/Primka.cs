//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class Primka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Primka()
        {
            this.ArtiklPrimkas = new HashSet<ArtiklPrimka>();
        }
    
        public int id { get; set; }
        public Nullable<int> dobavljacId { get; set; }
        public Nullable<int> skladisteId { get; set; }
        public Nullable<System.DateTime> datumVrijeme { get; set; }
        public Nullable<byte> zaprimljeno { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPrimka> ArtiklPrimkas { get; set; }
        public virtual Dobavljac Dobavljac { get; set; }
        public virtual Skladiste Skladiste { get; set; }
    }
}
