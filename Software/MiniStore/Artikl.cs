namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Artikl")]
    public partial class Artikl
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Artikl()
        {
            ArtiklNarudzbenicas = new HashSet<ArtiklNarudzbenica>();
            ArtiklPovratnicas = new HashSet<ArtiklPovratnica>();
            ArtiklPrimkas = new HashSet<ArtiklPrimka>();
            ArtiklSkladistes = new HashSet<ArtiklSkladiste>();
            RacunArtikls = new HashSet<RacunArtikl>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string naziv { get; set; }

        [StringLength(255)]
        public string kategorija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklNarudzbenica> ArtiklNarudzbenicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPovratnica> ArtiklPovratnicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPrimka> ArtiklPrimkas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklSkladiste> ArtiklSkladistes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacunArtikl> RacunArtikls { get; set; }
    }
}
