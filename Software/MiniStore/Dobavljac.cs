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
    
    public partial class Dobavljac
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Dobavljac()
        {
            this.ArtiklPrimkas = new HashSet<ArtiklPrimka>();
            this.Narudzbenicas = new HashSet<Narudzbenica>();
            this.Povratnicas = new HashSet<Povratnica>();
            this.Primkas = new HashSet<Primka>();
        }
    
        public int id { get; set; }
        public string naziv { get; set; }
        public string adresa { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPrimka> ArtiklPrimkas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzbenica> Narudzbenicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Povratnica> Povratnicas { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Primka> Primkas { get; set; }
    }
}