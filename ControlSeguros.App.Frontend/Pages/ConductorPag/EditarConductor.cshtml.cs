using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.ConductorPag
{
    public class EditarConductorModel : PageModel
    {
        private static IRepositorioConductor _repoConductor = new RepositorioConductor(new Persistencia.AppContext());
        [BindProperty]
        public Conductor? EditConductor { get; set; }

        public IActionResult OnGet(int? ConductorId)
        {
            if (ConductorId.HasValue)
            {
                EditConductor = _repoConductor.GetConductor(ConductorId.Value);
            }
            else
            {
                EditConductor = new Conductor();
            }
            if (EditConductor == null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoConductor.UpdateConductor(EditConductor);
            return RedirectToPage("ListaConductores");
        }
    }
}