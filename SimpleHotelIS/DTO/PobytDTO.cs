//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace SimpleHotelIS.DTO
{
    #pragma warning disable 1573
    using System;
    using System.Collections.Generic;
    using SimpleHotelIS.Models;
    
    public partial class PobytDTO : IEntityConvertible<Pobyt, PobytDTO>
    {
        public PobytDTO()
        {
    	}
    
        public PobytDTO(Pobyt entity)
        {
    	}
    
    	public  Pobyt ToEntity()
    	{
    		Pobyt entity = new  Pobyt();
    		entity.Id = this.Id;
    		return entity;
    	}
    
    
        public int Id { get; set; }
    	//dong
    		//susu
        public virtual ICollection<int> Izbas { get; set; }
        public virtual ICollection<int> Sluzbies { get; set; }
        public virtual int Zakaznik { get; set; }
    }
}
