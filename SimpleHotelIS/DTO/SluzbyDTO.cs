// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:28:00
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS.DTO
{
    [DataContract()]
    public class SluzbyDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public Int32 Pobyt_Id { get; set; }

        public SluzbyDTO()
        {
        }

        public SluzbyDTO(Int32 id, Int32 pobyt_Id)
        {
			this.Id = id;
			this.Pobyt_Id = pobyt_Id;
        }
    }
}
