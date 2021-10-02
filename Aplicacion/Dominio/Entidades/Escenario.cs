// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Escenario
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        public string Direccion{get;set;}
        public string Telefono{get;set;}
        public string Horario{get;set;}
        public int CapacidadEspacio{get;set;}
        public double Medidas{get;set;}
        // llave foranea con la tabla Equipo
        public int TorneoId{get;set;}   
        //propiedad Navigacional con canchas
         public List<Cancha> Canchas {get;set;} 

    }
}