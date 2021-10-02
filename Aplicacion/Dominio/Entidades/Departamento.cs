// importacion de librerias y referencias
using System;
using System.Collections.Generic;

namespace Dominio
{
    public class Departamento
    {
        public int Id{get;set;}
        public string Nombre{get;set;}
        // propiedad navigacional con la torneo
        public List<Municipio> Municipios {get;set;}

    }
}