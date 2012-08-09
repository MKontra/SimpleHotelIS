// Generated with EntitiesToDTOs.v2.1 (entitiestodtos.codeplex.com).
// Timestamp: 09/08/2012 - 03:03:50
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace SimpleHotelIS
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

    [DataContract()]
    public class RezervaciaDTO
    {
        [DataMember()]
        public Int32 Id { get; set; }

        [DataMember()]
        public Int32 Zakaznik_Id { get; set; }

        [DataMember()]
        public List<Int32> Izbas_Id { get; set; }

        public RezervaciaDTO()
        {
        }

        public RezervaciaDTO(Int32 id, Int32 zakaznik_Id, List<Int32> izbas_Id)
        {
            this.Id = id;
            this.Zakaznik_Id = zakaznik_Id;
            this.Izbas_Id = izbas_Id;
        }
    }

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
