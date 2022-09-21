using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.ConductorPag
{
    public class CrearConductor : PageModel
    {
        private static IRepositorioConductor _repoConductor = new RepositorioConductor(new Persistencia.AppContext());

        [BindProperty]
        public Conductor NewConductor { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoConductor.AddConductor(NewConductor);
            return Page();
        }
    }
}