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
    
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            this.RacunArtikls = new HashSet<RacunArtikl>();
        }
    
        public int id { get; set; }
        public Nullable<System.DateTime> datumVrijeme { get; set; }
        public string nacinPlacanja { get; set; }
        public Nullable<decimal> iznos { get; set; }
        public Nullable<int> korisnikId { get; set; }
        public Nullable<int> trgovinaId { get; set; }
    
        public virtual Korisnik Korisnik { get; set; }
        public virtual Trgovina Trgovina { get; set; }
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacunArtikl> RacunArtikls { get; set; }
    }
}
