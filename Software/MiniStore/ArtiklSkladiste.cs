namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtiklSkladiste")]
    public partial class ArtiklSkladiste
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artiklId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int skaldisteId { get; set; }

        public int? kolicina { get; set; }

        public virtual Artikl Artikl { get; set; }

        public virtual Skladiste Skladiste { get; set; }
    }
}
