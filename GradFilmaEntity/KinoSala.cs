//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace GradFilmaEntity
{
    using System;
    using System.Collections.Generic;
    
    public partial class KinoSala
    {
        public KinoSala()
        {
            this.Projekcijas = new HashSet<Projekcija>();
        }
    
        public int idKinoSala { get; set; }
        public int brojSale { get; set; }
        public int brojMjesta { get; set; }
        public string tipMjesta { get; set; }
        public int TipMjestaId { get; set; }
    
        public virtual TipMjesta TipMjesta1 { get; set; }
        public virtual ICollection<Projekcija> Projekcijas { get; set; }
    }
}
