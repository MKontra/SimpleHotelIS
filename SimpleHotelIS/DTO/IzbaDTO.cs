// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:27:59
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS.DTO
{
    [DataContract()]
    public class IzbaDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public Int32 Rezervacia_Id { get; set; }

        [DataMember()]
        public Int32 Pobyt_Id { get; set; }

        public IzbaDTO()
        {
        }

        public IzbaDTO(Int32 id, Int32 rezervacia_Id, Int32 pobyt_Id)
        {
			this.Id = id;
			this.Rezervacia_Id = rezervacia_Id;
			this.Pobyt_Id = pobyt_Id;
        }
    }
}
