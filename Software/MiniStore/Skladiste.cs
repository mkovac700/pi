namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Skladiste")]
    public partial class Skladiste
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Skladiste()
        {
            ArtiklPrimkas = new HashSet<ArtiklPrimka>();
            ArtiklSkladistes = new HashSet<ArtiklSkladiste>();
            Primkas = new HashSet<Primka>();
        }

        public int id { get; set; }

        public int? trgovinaId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPrimka> ArtiklPrimkas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklSkladiste> ArtiklSkladistes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Primka> Primkas { get; set; }

        public virtual Trgovina Trgovina { get; set; }
    }
}
