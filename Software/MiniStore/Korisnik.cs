namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Korisnik")]
    public partial class Korisnik
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Korisnik()
        {
            Inventuras = new HashSet<Inventura>();
            Narudzbenicas = new HashSet<Narudzbenica>();
            Povratnicas = new HashSet<Povratnica>();
            Racuns = new HashSet<Racun>();
            Satnicas = new HashSet<Satnica>();
            Trgovinas = new HashSet<Trgovina>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string ime { get; set; }

        [StringLength(255)]
        public string prezime { get; set; }

        [StringLength(255)]
        public string adresa { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datumRodjenja { get; set; }

        [StringLength(255)]
        public string korisnickoIme { get; set; }

        [StringLength(255)]
        public string lozinka { get; set; }

        public int? vrstaKorisnika { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventura> Inventuras { get; set; }

        public virtual VrstaKorisnika VrstaKorisnika1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzbenica> Narudzbenicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Povratnica> Povratnicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Satnica> Satnicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trgovina> Trgovinas { get; set; }
    }
}
