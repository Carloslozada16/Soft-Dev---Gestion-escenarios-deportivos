using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace Frontend.Pages
{
    public class MIndexModel : PageModel
    {
        //Definir de donde vamos a extraer los municipios
        private readonly IRepositorioMunicipio _repositorioMunicipio;

        //modelo u objeto para transportar hacia MIndex.cshtml
        public IEnumerable<Municipio> Municipios{get;set;}

        //constructor 
        public MIndexModel(IRepositorioMunicipio repomunicipio)
        {
            this._repositorioMunicipio=repomunicipio;
        }
        public void OnGet()
        {

            Municipios=_repositorioMunicipio.ListarMunicipios();
        }
    }
}
