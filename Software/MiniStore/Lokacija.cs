namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("Lokacija")]
    public partial class Lokacija
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Lokacija()
        {
            Trgovinas = new HashSet<Trgovina>();
        }

        public int id { get; set; }

        [StringLength(255)]
        public string adresa { get; set; }

        public int? gradId { get; set; }

        public virtual Grad Grad { get; set; }

        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<Trgovina> Trgovinas { get; set; }
    }
}
