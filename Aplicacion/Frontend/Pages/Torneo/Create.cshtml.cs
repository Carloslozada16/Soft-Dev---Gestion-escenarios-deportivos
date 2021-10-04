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
    public class CreateModel : PageModel
    {
        private readonly IRepositorioTorneo _repotorneo;

        [BindProperty]
        public Torneo Torneo {get; set;}

        public ActionResult OnGet()
        {
            return Page();
        }
    }
}
