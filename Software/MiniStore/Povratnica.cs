namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Povratnica")]
    public partial class Povratnica
    {
        public int id { get; set; }

        public DateTime? datumVrijeme { get; set; }

        public int? dobavljacId { get; set; }

        public int? korisnikId { get; set; }

        public int? trgovinaId { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }

        public virtual Korisnik Korisnik { get; set; }

        public virtual Trgovina Trgovina { get; set; }

        public virtual Trgovina Trgovina1 { get; set; }
    }
}
