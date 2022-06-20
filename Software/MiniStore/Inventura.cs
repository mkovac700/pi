namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Inventura")]
    public partial class Inventura
    {
        public int id { get; set; }

        public int? korisnikId { get; set; }

        public int? trgovinaId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum { get; set; }

        public int? primkaKolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? primkaCijena { get; set; }

        public int? povratnicaKolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? povratnicaCijena { get; set; }

        public int? racunKolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? racunCijena { get; set; }

        public int? skladisteKolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? skladisteCijena { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Trgovina Trgovina { get; set; }
    }
}
