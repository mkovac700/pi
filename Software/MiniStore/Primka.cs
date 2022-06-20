namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Primka")]
    public partial class Primka
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Primka()
        {
            ArtiklPrimkas = new HashSet<ArtiklPrimka>();
        }

        public int id { get; set; }

        public int? dobavljacId { get; set; }

        public int? skladisteId { get; set; }

        public DateTime? datumVrijeme { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklPrimka> ArtiklPrimkas { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }

        public virtual Skladiste Skladiste { get; set; }
    }
}
