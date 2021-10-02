// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Cancha
    {
        public int Id{get;set;}
        public string Nombres{get;set;}
        public string Disciplina{get;set;}
        public string Estado{get;set;}
        public int CapacidadEspacio{get;set;}
        public double Medidas{get;set;}
        // llave foranea con la tabla Equipo
        public int EscenarioId{get;set;}   
        

    }
}