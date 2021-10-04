using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Dominio;
using Persistencia;

namespace  Frontend.Pages
{
    public class CIndexModel : PageModel
    {
        private readonly IRepositorioTorneo _repotorneo;


        public IEnumerable<Torneo> Torneos {get; set;}

        public CIndexModel(IRepositorioTorneo repotorneo)
        {
            this._repotorneo = repotorneo;
        }

        public void OnGet()
        {
            Torneos= _repotorneo.GetAllTorneo();
        }
    }
}
