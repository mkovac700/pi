//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MiniStore
{
    using System;
    using System.Collections.Generic;
    
    public partial class ArtiklSkladiste
    {
        public int artiklId { get; set; }
        public int skaldisteId { get; set; }
        public Nullable<int> kolicina { get; set; }
    
        public virtual Artikl Artikl { get; set; }
        public virtual Skladiste Skladiste { get; set; }
    }
}
