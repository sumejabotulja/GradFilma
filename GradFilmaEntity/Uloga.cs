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
    
    public partial class Uloga
    {
        public Uloga()
        {
            this.Privilegijes = new HashSet<Privilegije>();
            this.Uposleniks = new HashSet<Uposlenik>();
        }
    
        public int idUloga { get; set; }
        public Nullable<int> administrator { get; set; }
        public Nullable<int> upravnik { get; set; }
        public Nullable<int> menadzer { get; set; }
    
        public virtual ICollection<Privilegije> Privilegijes { get; set; }
        public virtual ICollection<Uposlenik> Uposleniks { get; set; }
    }
}