using SimpleHotelIS.Models;
using System;
using System.Linq;

namespace  SimpleHotelIS.DTO
{
	public static class DtoAssembler
	{
        public static object toDto<T>(T p)
        {
            Type tType = typeof(T);
            if (tType == typeof(Zakaznik)) return toDto(p as Zakaznik);
            if (tType == typeof(Rezervacia)) return toDto(p as Rezervacia);
            if (tType == typeof(Pobyt)) return toDto(p as Pobyt);
            if (tType == typeof(Izba)) return toDto(p as Izba);
            if (tType == typeof(Platba)) return toDto(p as Platba);
            if (tType == typeof(Sluzby)) return toDto(p as Sluzby);
            return null;
        }
		public static ZakaznikDTO toDto(Zakaznik entity)
		{
			ZakaznikDTO newdto = new ZakaznikDTO();

			//Properties
			newdto.Id = entity.Id;
			newdto.meno = entity.meno;
			newdto.priezvisko = entity.priezvisko;
			newdto.kontakt = entity.kontakt;
			//Nav. Properties
			newdto.Rezervacias = entity.Rezervacias.Select( fref => fref.Id).ToList();
			newdto.Platbas = entity.Platbas.Select( fref => fref.Id).ToList();
			newdto.Pobyts = entity.Pobyts.Select( fref => fref.Id).ToList();
			return newdto;
		}
		public static RezervaciaDTO toDto(Rezervacia entity)
		{
			RezervaciaDTO newdto = new RezervaciaDTO();

			//Properties
			newdto.Id = entity.Id;
			//Nav. Properties
			newdto.Zakaznik = entity.Zakaznik.Id;
			newdto.Izbas = entity.Izbas.Select( fref => fref.Id).ToList();
			return newdto;
		}
		public static PobytDTO toDto(Pobyt entity)
		{
			PobytDTO newdto = new PobytDTO();

			//Properties
			newdto.Id = entity.Id;
			//Nav. Properties
			newdto.Zakaznik = entity.Zakaznik.Id;
			newdto.Izbas = entity.Izbas.Select( fref => fref.Id).ToList();
			newdto.Sluzbies = entity.Sluzbies.Select( fref => fref.Id).ToList();
			return newdto;
		}
		public static IzbaDTO toDto(Izba entity)
		{
			IzbaDTO newdto = new IzbaDTO();

			//Properties
			newdto.Id = entity.Id;
			//Nav. Properties
			newdto.Rezervacia = entity.Rezervacia.Id;
			newdto.Pobyt = entity.Pobyt.Id;
			return newdto;
		}
		public static PlatbaDTO toDto(Platba entity)
		{
			PlatbaDTO newdto = new PlatbaDTO();

			//Properties
			newdto.Id = entity.Id;
			//Nav. Properties
			newdto.Zakaznik = entity.Zakaznik.Id;
			return newdto;
		}
		public static SluzbyDTO toDto(Sluzby entity)
		{
			SluzbyDTO newdto = new SluzbyDTO();

			//Properties
			newdto.Id = entity.Id;
			newdto.Description = entity.Description;
			//Nav. Properties
			newdto.Pobyt = entity.Pobyt.Id;
			return newdto;
		}


	}
}
