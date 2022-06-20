namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Racun")]
    public partial class Racun
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Racun()
        {
            RacunArtikls = new HashSet<RacunArtikl>();
        }

        public int id { get; set; }

        public DateTime? datumVrijeme { get; set; }

        [StringLength(255)]
        public string nacinPlacanja { get; set; }

        [Column(TypeName = "money")]
        public decimal? iznos { get; set; }

        public int? korisnikId { get; set; }

        public int? trgovinaId { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Trgovina Trgovina { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<RacunArtikl> RacunArtikls { get; set; }
    }
}
