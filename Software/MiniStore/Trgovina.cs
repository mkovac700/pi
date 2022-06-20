namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Trgovina")]
    public partial class Trgovina
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Trgovina()
        {
            Inventuras = new HashSet<Inventura>();
            Narudzbenicas = new HashSet<Narudzbenica>();
            Povratnicas = new HashSet<Povratnica>();
            Povratnicas1 = new HashSet<Povratnica>();
            Racuns = new HashSet<Racun>();
            Skladistes = new HashSet<Skladiste>();
            Korisniks = new HashSet<Korisnik>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string oznaka { get; set; }

        public int? lokacijaId { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Inventura> Inventuras { get; set; }

        public virtual Lokacija Lokacija { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Narudzbenica> Narudzbenicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Povratnica> Povratnicas { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Povratnica> Povratnicas1 { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Racun> Racuns { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Skladiste> Skladistes { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Korisnik> Korisniks { get; set; }
    }
}
