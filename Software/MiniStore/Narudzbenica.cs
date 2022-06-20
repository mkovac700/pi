namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Narudzbenica")]
    public partial class Narudzbenica
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Narudzbenica()
        {
            ArtiklNarudzbenicas = new HashSet<ArtiklNarudzbenica>();
        }

        public int id { get; set; }

        public int? korisnikId { get; set; }

        public int? trgovinaId { get; set; }

        public DateTime? datumVrijeme { get; set; }

        public int? dobavljacId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<ArtiklNarudzbenica> ArtiklNarudzbenicas { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Trgovina Trgovina { get; set; }
    }
}
