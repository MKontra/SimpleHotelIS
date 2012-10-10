// Generated with EntitiesToDTOs.v2.2 (entitiestodtos.codeplex.com).
// Timestamp: 23/10/2012 - 22:28:01
using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;
using System.Linq;
using SimpleHotelIS.Models;
using System.Data.Objects.DataClasses;

namespace SimpleHotelIS.DTO
{

    /// <summary>
    /// Assembler for <see cref="Zakaznik"/> and <see cref="ZakaznikDTO"/>.
    /// </summary>
    public static partial class ZakaznikAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="ZakaznikDTO"/> converted from <see cref="Zakaznik"/>.</param>
        static partial void OnDTO(this Zakaznik entity, ZakaznikDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Zakaznik"/> converted from <see cref="ZakaznikDTO"/>.</param>
        static partial void OnEntity(this ZakaznikDTO dto, Zakaznik entity);

        /// <summary>
        /// Converts this instance of <see cref="ZakaznikDTO"/> to an instance of <see cref="Zakaznik"/>.
        /// </summary>
        /// <param name="dto"><see cref="ZakaznikDTO"/> to convert.</param>
        public static Zakaznik ToEntity(this ZakaznikDTO dto)
        {
            if (dto == null) return null;

            Zakaznik entity = null;

            entity = new Zakaznik();

            entity.Id = dto.Id;
            entity.meno = dto.meno;
            entity.priezvisko = dto.priezvisko;
            entity.kontakt = dto.kontakt;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Zakaznik"/> to an instance of <see cref="ZakaznikDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Zakaznik"/> to convert.</param>
        public static ZakaznikDTO ToDTO(this Zakaznik entity)
        {
            if (entity == null) return null;

            ZakaznikDTO dto = null;

            dto = new ZakaznikDTO();

            dto.Id = entity.Id;
            dto.meno = entity.meno;
            dto.priezvisko = entity.priezvisko;
            dto.kontakt = entity.kontakt;
            dto.Rezervacias_Id = entity.Rezervacias.Select(p => p.Id).ToList();
            dto.Platbas_Id = entity.Platbas.Select(p => p.Id).ToList();
            dto.Pobyts_Id = entity.Pobyts.Select(p => p.Id).ToList();

            entity.OnDTO(dto);

            return dto;
        }
    }

    /// <summary>
    /// Assembler for <see cref="Rezervacia"/> and <see cref="RezervaciaDTO"/>.
    /// </summary>
    public static partial class RezervaciaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="RezervaciaDTO"/> converted from <see cref="Rezervacia"/>.</param>
        static partial void OnDTO(this Rezervacia entity, RezervaciaDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Rezervacia"/> converted from <see cref="RezervaciaDTO"/>.</param>
        static partial void OnEntity(this RezervaciaDTO dto, Rezervacia entity);

        /// <summary>
        /// Converts this instance of <see cref="RezervaciaDTO"/> to an instance of <see cref="Rezervacia"/>.
        /// </summary>
        /// <param name="dto"><see cref="RezervaciaDTO"/> to convert.</param>
        public static Rezervacia ToEntity(this RezervaciaDTO dto)
        {
            if (dto == null) return null;

            Rezervacia entity = null;

            entity = new Rezervacia();

            entity.Id = dto.Id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Rezervacia"/> to an instance of <see cref="RezervaciaDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Rezervacia"/> to convert.</param>
        public static RezervaciaDTO ToDTO(this Rezervacia entity)
        {
            if (entity == null) return null;

            RezervaciaDTO dto = null;

            dto = new RezervaciaDTO();

            dto.Id = entity.Id;
            dto.Zakaznik_Id = entity.Zakaznik.Id;
            dto.Izbas_Id = entity.Izbas.Select(p => p.Id).ToList();

            entity.OnDTO(dto);

            return dto;
        }
    }

    /// <summary>
    /// Assembler for <see cref="Pobyt"/> and <see cref="PobytDTO"/>.
    /// </summary>
    public static partial class PobytAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="PobytDTO"/> converted from <see cref="Pobyt"/>.</param>
        static partial void OnDTO(this Pobyt entity, PobytDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Pobyt"/> converted from <see cref="PobytDTO"/>.</param>
        static partial void OnEntity(this PobytDTO dto, Pobyt entity);

        /// <summary>
        /// Converts this instance of <see cref="PobytDTO"/> to an instance of <see cref="Pobyt"/>.
        /// </summary>
        /// <param name="dto"><see cref="PobytDTO"/> to convert.</param>
        public static Pobyt ToEntity(this PobytDTO dto)
        {
            if (dto == null) return null;

            Pobyt entity = null;

            entity = new Pobyt();

            entity.Id = dto.Id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Pobyt"/> to an instance of <see cref="PobytDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Pobyt"/> to convert.</param>
        public static PobytDTO ToDTO(this Pobyt entity)
        {
            if (entity == null) return null;

            PobytDTO dto = null;

            dto = new PobytDTO();

            dto.Id = entity.Id;
            dto.Izbas_Id = entity.Izbas.Select(p => p.Id).ToList();
            dto.Sluzbies_Id = entity.Sluzbies.Select(p => p.Id).ToList();
            dto.Zakaznik_Id = entity.Zakaznik.Id;

            entity.OnDTO(dto);

            return dto;
        }
    }

    /// <summary>
    /// Assembler for <see cref="Izba"/> and <see cref="IzbaDTO"/>.
    /// </summary>
    public static partial class IzbaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="IzbaDTO"/> converted from <see cref="Izba"/>.</param>
        static partial void OnDTO(this Izba entity, IzbaDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Izba"/> converted from <see cref="IzbaDTO"/>.</param>
        static partial void OnEntity(this IzbaDTO dto, Izba entity);

        /// <summary>
        /// Converts this instance of <see cref="IzbaDTO"/> to an instance of <see cref="Izba"/>.
        /// </summary>
        /// <param name="dto"><see cref="IzbaDTO"/> to convert.</param>
        public static Izba ToEntity(this IzbaDTO dto)
        {
            if (dto == null) return null;

            Izba entity = null;

            entity = new Izba();

            entity.Id = dto.Id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Izba"/> to an instance of <see cref="IzbaDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Izba"/> to convert.</param>
        public static IzbaDTO ToDTO(this Izba entity)
        {
            if (entity == null) return null;

            IzbaDTO dto = null;

            dto = new IzbaDTO();

            dto.Id = entity.Id;
            dto.Rezervacia_Id = entity.Rezervacia.Id;
            dto.Pobyt_Id = entity.Pobyt.Id;

            entity.OnDTO(dto);

            return dto;
        }
    }

    /// <summary>
    /// Assembler for <see cref="Platba"/> and <see cref="PlatbaDTO"/>.
    /// </summary>
    public static partial class PlatbaAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="PlatbaDTO"/> converted from <see cref="Platba"/>.</param>
        static partial void OnDTO(this Platba entity, PlatbaDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Platba"/> converted from <see cref="PlatbaDTO"/>.</param>
        static partial void OnEntity(this PlatbaDTO dto, Platba entity);

        /// <summary>
        /// Converts this instance of <see cref="PlatbaDTO"/> to an instance of <see cref="Platba"/>.
        /// </summary>
        /// <param name="dto"><see cref="PlatbaDTO"/> to convert.</param>
        public static Platba ToEntity(this PlatbaDTO dto)
        {
            if (dto == null) return null;

            Platba entity = null;

            entity = new Platba();

            entity.Id = dto.Id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Platba"/> to an instance of <see cref="PlatbaDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Platba"/> to convert.</param>
        public static PlatbaDTO ToDTO(this Platba entity)
        {
            if (entity == null) return null;

            PlatbaDTO dto = null;

            dto = new PlatbaDTO();

            dto.Id = entity.Id;
            dto.Zakaznik_Id = entity.Zakaznik.Id;

            entity.OnDTO(dto);

            return dto;
        }
    }

    /// <summary>
    /// Assembler for <see cref="Sluzby"/> and <see cref="SluzbyDTO"/>.
    /// </summary>
    public static partial class SluzbyAssembler
    {
        /// <summary>
        /// Invoked when <see cref="ToDTO"/> operation is about to return.
        /// </summary>
        /// <param name="dto"><see cref="SluzbyDTO"/> converted from <see cref="Sluzby"/>.</param>
        static partial void OnDTO(this Sluzby entity, SluzbyDTO dto);

        /// <summary>
        /// Invoked when <see cref="ToEntity"/> operation is about to return.
        /// </summary>
        /// <param name="entity"><see cref="Sluzby"/> converted from <see cref="SluzbyDTO"/>.</param>
        static partial void OnEntity(this SluzbyDTO dto, Sluzby entity);

        /// <summary>
        /// Converts this instance of <see cref="SluzbyDTO"/> to an instance of <see cref="Sluzby"/>.
        /// </summary>
        /// <param name="dto"><see cref="SluzbyDTO"/> to convert.</param>
        public static Sluzby ToEntity(this SluzbyDTO dto)
        {
            if (dto == null) return null;

            Sluzby entity = null;

            entity = new Sluzby();

            entity.Id = dto.Id;

            dto.OnEntity(entity);

            return entity;
        }

        /// <summary>
        /// Converts this instance of <see cref="Sluzby"/> to an instance of <see cref="SluzbyDTO"/>.
        /// </summary>
        /// <param name="entity"><see cref="Sluzby"/> to convert.</param>
        public static SluzbyDTO ToDTO(this Sluzby entity)
        {
            if (entity == null) return null;

            SluzbyDTO dto = null;

            dto = new SluzbyDTO();

            dto.Id = entity.Id;
            dto.Pobyt_Id = entity.Pobyt.Id;

            entity.OnDTO(dto);

            return dto;
        }
    }
}
