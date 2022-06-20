namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtiklNarudzbenica")]
    public partial class ArtiklNarudzbenica
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artiklId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int narudzbenicaId { get; set; }

        public int? kolicina { get; set; }

        public virtual Artikl Artikl { get; set; }

        public virtual Narudzbenica Narudzbenica { get; set; }
    }
}
