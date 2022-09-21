using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;

namespace ControlSeguros.App.Frontend.Pages
{
    public class RegPropietarioModel : PageModel
    {
        private static IRepositorioPropietario _repoPropietario= new RepositorioPropietario(new Persistencia.AppContext());

        [BindProperty]
        public Propietario NewPropietario { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoPropietario.AddPropietario(NewPropietario);
            return Page();
        }
    }
}
