namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtiklPovratnica")]
    public partial class ArtiklPovratnica
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artiklId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int povratnicaId { get; set; }

        public int? kolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? cijena { get; set; }

        public virtual Artikl Artikl { get; set; }
    }
}
