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
    
    public partial class PlatbaDTO : IEntityConvertible<Platba, PlatbaDTO>
    {
        public PlatbaDTO()
        {
    	}
    
        public PlatbaDTO(Platba entity)
        {
    	}
    
    	public  Platba ToEntity()
    	{
    		Platba entity = new  Platba();
    		entity.Id = this.Id;
    		return entity;
    	}
    
    
        public int Id { get; set; }
    	//dong
    		//susu
        public virtual int Zakaznik { get; set; }
    }
}
