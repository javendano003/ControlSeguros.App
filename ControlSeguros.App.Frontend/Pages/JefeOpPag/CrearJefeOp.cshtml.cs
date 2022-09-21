using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.JefeOp
{
    public class CrearJefeOpModel : PageModel
    {
        private static IRepositorioJefeOperaciones _repoJefeOperaciones = new RepositorioJefeOperaciones(new Persistencia.AppContext());

        [BindProperty]
        public JefeOperaciones NewJefeOp { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoJefeOperaciones.AddJefeOperaciones(NewJefeOp);
            return Page();
        }
    }
}