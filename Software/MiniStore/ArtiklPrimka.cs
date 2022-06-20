namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ArtiklPrimka")]
    public partial class ArtiklPrimka
    {
        [Key]
        [Column(Order = 0)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int artiklId { get; set; }

        [Key]
        [Column(Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int primkaId { get; set; }

        public int? dobavljacId { get; set; }

        public int? skladisteId { get; set; }

        public int? kolicina { get; set; }

        [Column(TypeName = "money")]
        public decimal? cijena { get; set; }

        public virtual Artikl Artikl { get; set; }

        public virtual Dobavljac Dobavljac { get; set; }

        public virtual Primka Primka { get; set; }

        public virtual Skladiste Skladiste { get; set; }
    }
}
