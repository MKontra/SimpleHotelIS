// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:28:00
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS.DTO
{
    [DataContract()]
    public class PlatbaDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public Int32 Zakaznik_Id { get; set; }

        public PlatbaDTO()
        {
        }

        public PlatbaDTO(Int32 id, Int32 zakaznik_Id)
        {
			this.Id = id;
			this.Zakaznik_Id = zakaznik_Id;
        }
    }
}
