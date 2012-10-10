// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:27:58
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS.DTO
{
    [DataContract()]
    public class ZakaznikDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public String meno { get; set; }

        [DataMember()]
        public String priezvisko { get; set; }

        [DataMember()]
        public String kontakt { get; set; }

        [DataMember()]
        public List<Int32> Rezervacias_Id { get; set; }

        [DataMember()]
        public List<Int32> Platbas_Id { get; set; }

        [DataMember()]
        public List<Int32> Pobyts_Id { get; set; }

        public ZakaznikDTO()
        {
        }

        public ZakaznikDTO(Int32 id, String meno, String priezvisko, String kontakt, List<Int32> rezervacias_Id, List<Int32> platbas_Id, List<Int32> pobyts_Id)
        {
			this.Id = id;
			this.meno = meno;
			this.priezvisko = priezvisko;
			this.kontakt = kontakt;
			this.Rezervacias_Id = rezervacias_Id;
			this.Platbas_Id = platbas_Id;
			this.Pobyts_Id = pobyts_Id;
        }
    }
}
