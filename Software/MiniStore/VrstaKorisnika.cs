namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("VrstaKorisnika")]
    public partial class VrstaKorisnika
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public VrstaKorisnika()
        {
            Korisniks = new HashSet<Korisnik>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string oznaka { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
