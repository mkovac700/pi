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
    
    public partial class Povratnica
    {
        public int id { get; set; }
        public Nullable<System.DateTime> datumVrijeme { get; set; }
        public Nullable<int> dobavljacId { get; set; }
        public Nullable<int> korisnikId { get; set; }
        public Nullable<int> trgovinaId { get; set; }
    
        public virtual Dobavljac Dobavljac { get; set; }
        public virtual Korisnik Korisnik { get; set; }
        public virtual Trgovina Trgovina { get; set; }
        public virtual Trgovina Trgovina1 { get; set; }
    }
}