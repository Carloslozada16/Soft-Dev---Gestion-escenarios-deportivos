// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Equipo
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public int CantidadDeportistas {get;set;}
        public string Disciplina {get;set;}
        // propiedad navigacional hacia la tabla Entrenador
        public Entrenador Entrenador {get;set;}
        //llave foranea de Patrocinador
        public int PatrocinadorId {get;set;}
        // propiedad navigacional hacia la tabla intermedia TorneoEquipo
        public List<TorneoEquipo> TorneoEquipos {get;set;}
        //propiedad navigacional hacia la tabla deportistas
        public List<Deportista> Deportistas {get;set;}
    }
}