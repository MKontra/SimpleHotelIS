//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleHotelIS.Models
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    
    public partial class Izba
    {
        public int Id { get; set; }
    
        public virtual Rezervacia Rezervacia { get; set; }
        public virtual Pobyt Pobyt { get; set; }
    }
}
