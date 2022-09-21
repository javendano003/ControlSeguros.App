using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.AuxiliarPag
{
    public class EditarAuxiliarModel : PageModel
    {
        private static IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());
        [BindProperty]
        public Auxiliar? EditAuxiliar { get; set; }

        public IActionResult OnGet(int? AuxiliarId)
        {
            if (AuxiliarId.HasValue)
            {
                EditAuxiliar = _repoAuxiliar.GetAuxiliar(AuxiliarId.Value);
            }
            else
            {
                EditAuxiliar = new Auxiliar();
            }
            if (EditAuxiliar == null)
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

            _repoAuxiliar.UpdateAuxiliar(EditAuxiliar);
            return RedirectToPage("ListaAuxiliares");
        }
    }
}