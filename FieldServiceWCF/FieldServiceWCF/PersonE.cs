//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FieldServiceWCF
{
    using System;
    using System.Collections.Generic;
    
    public partial class PersonE
    {
        public PersonE()
        {
            this.Reservations = new HashSet<ReservationE>();
        }
    
        public string name { get; set; }
        public string phone { get; set; }
        public string address { get; set; }
    
        public virtual ICollection<ReservationE> Reservations { get; set; }
    }
}
