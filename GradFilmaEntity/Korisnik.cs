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
    
    public partial class Korisnik
    {
        public Korisnik()
        {
            this.Rezervacijas = new HashSet<Rezervacija>();
        }
    
        public int idKorisnik { get; set; }
        public string ime { get; set; }
        public string prezime { get; set; }
        public string jmbg { get; set; }
        public string telefon { get; set; }
        public string adresa { get; set; }
        public string username { get; set; }
        public string password { get; set; }
    
        public virtual ICollection<Rezervacija> Rezervacijas { get; set; }
    }
}
