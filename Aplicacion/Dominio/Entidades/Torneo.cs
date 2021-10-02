// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Torneo
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Categoria { get; set; }
        public DateTime FechaInicial {get;set;}
        public DateTime FechaFinal{get;set;}
        public string Tipo{get;set;}
        // propiedad navigacional a la tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneoEquipos {get;set;}
        //llave forane para la relacion con municipio
        public int MunicipioId {get;set;}
        //propiedad navigaciobnal hacia la tabla arbitros
        public List<Arbitro> Arbitros {get;set;}
        //Propiedad navigacional hacia la tabla escenario
        public List<Escenario> Escenarios {get;set;}
    }
}