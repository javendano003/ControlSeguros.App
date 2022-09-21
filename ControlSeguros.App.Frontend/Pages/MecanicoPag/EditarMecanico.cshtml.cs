using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.MecanicoPag
{
    public class EditarMecanicoModel : PageModel
    {
        private static IRepositorioMecanico _repoMecanico = new RepositorioMecanico(new Persistencia.AppContext());
        [BindProperty]
        public Mecanico? EditMecanico { get; set; }

        public IActionResult OnGet(int? MecanicoId)
        {
            if (MecanicoId.HasValue)
            {
                EditMecanico = _repoMecanico.GetMecanico(MecanicoId.Value);
            }
            else
            {
                EditMecanico = new Mecanico();
            }
            if (EditMecanico == null)
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

            _repoMecanico.UpdateMecanico(EditMecanico);
            return RedirectToPage("Mecanico");
        }
    }
}