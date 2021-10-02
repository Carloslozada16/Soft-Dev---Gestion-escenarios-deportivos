// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class TorneoEquipo
    {
        // llave principa compuesta por los dos campos ID
        public int TorneoId{get;set;}
        public int EquipoId{get;set;}
        // propiedad navigacional a Torneo
        public Torneo Torneo {get;set;} 
        // propiedad navigacional a Equipo
        public Equipo Equipo {get;set;} 
    }
}