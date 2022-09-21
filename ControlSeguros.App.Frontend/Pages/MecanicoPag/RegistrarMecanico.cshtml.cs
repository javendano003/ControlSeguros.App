using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.MecanicoPag
{
    public class RegistrarMecanicoModel : PageModel
    {
        private static IRepositorioMecanico _repoMecanico= new RepositorioMecanico(new Persistencia.AppContext());

        [BindProperty]
        public Mecanico NewMecanico { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoMecanico.AddMecanico(NewMecanico);
            return RedirectToPage("Mecanico");
        }
    }
}