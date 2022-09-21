using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.JefeOp
{
    public class EditarJefeOpModel : PageModel
    {
        private static IRepositorioJefeOperaciones _repoJefeOperaciones = new RepositorioJefeOperaciones(new Persistencia.AppContext());
        [BindProperty]
        public JefeOperaciones? EditJefeOp { get; set; }

        public IActionResult OnGet(int? JefeOpId)
        {
            if (JefeOpId.HasValue)
            {
                EditJefeOp = _repoJefeOperaciones.GetJefeOperaciones(JefeOpId.Value);
            }
            else
            {
                EditJefeOp = new JefeOperaciones();
            }
            if (EditJefeOp == null)
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

            _repoJefeOperaciones.UpdateJefeOperaciones(EditJefeOp);
            return RedirectToPage("ListaJefeOp");
        }
    }
}