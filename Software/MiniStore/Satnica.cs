namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Satnica")]
    public partial class Satnica
    {
        public int id { get; set; }

        public int? korisnikId { get; set; }

        [Column(TypeName = "date")]
        public DateTime? datum { get; set; }

        public int? brojSati { get; set; }

        public virtual Korisnik Korisnik { get; set; }
    }
}
