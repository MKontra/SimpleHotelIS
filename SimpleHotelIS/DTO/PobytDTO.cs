// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:27:59
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS.DTO
{
    [DataContract()]
    public class PobytDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public List<Int32> Izbas_Id { get; set; }

        [DataMember()]
        public List<Int32> Sluzbies_Id { get; set; }

        [DataMember()]
        public Int32 Zakaznik_Id { get; set; }

        public PobytDTO()
        {
        }

        public PobytDTO(Int32 id, List<Int32> izbas_Id, List<Int32> sluzbies_Id, Int32 zakaznik_Id)
        {
			this.Id = id;
			this.Izbas_Id = izbas_Id;
			this.Sluzbies_Id = sluzbies_Id;
			this.Zakaznik_Id = zakaznik_Id;
        }
    }
}
