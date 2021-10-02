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
    public class CrearModel : PageModel
    {
        //Objeto para usar el repositorio
        private readonly IRepositorioMunicipio _repositorioMunicipio;
        //Propiedad para trasnportar al cshtml
        
        [BindProperty]
        public Municipio Municipio{get;set;}

        //constructor
        public CrearModel(IRepositorioMunicipio repomunicipio)
        {
            this._repositorioMunicipio=repomunicipio;
        }

        public ActionResult OnGet()
        {
            return Page();

        }
        public ActionResult OnPost()
        {
            bool creado=_repositorioMunicipio.CrearMunicipio(Municipio);
            if (creado)
            {
                return RedirectToPage("./MIndex");
            }
            else
            {
                return Page();
            }
        }
    }
}
