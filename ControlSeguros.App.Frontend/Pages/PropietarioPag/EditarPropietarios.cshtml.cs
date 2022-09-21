using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.PropietarioPag
{
    public class EditarPropietariosModel : PageModel
    {
        private static IRepositorioPropietario _repoPropietario = new RepositorioPropietario(new Persistencia.AppContext());
        [BindProperty]
        public Propietario? EditPropietario { get; set; }

        public IActionResult OnGet(int? PropietarioId)
        {
            if (PropietarioId.HasValue)
            {
                EditPropietario = _repoPropietario.GetPropietario(PropietarioId.Value);
            }
            else
            {
                EditPropietario = new Propietario();
            }
            if (EditPropietario == null)
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

            _repoPropietario.UpdatePropietario(EditPropietario);
            return RedirectToPage("ListaPropietarios");
        }
    }
}