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
    using System.ComponentModel.DataAnnotations;
    using System.Data.Common;
    using System.Data.Entity;
    using System.Data.Entity.ModelConfiguration;
    using System.Data.Entity.Infrastructure;
    
    internal partial class Rezervacia_Mapping : EntityTypeConfiguration<Rezervacia>
    {
        public Rezervacia_Mapping()
        {					
    		this.HasKey(t => t.Id);		
    		this.ToTable("Rezervacias");
    		this.Property(t => t.Id).HasColumnName("Id");
    	}
    }
}
