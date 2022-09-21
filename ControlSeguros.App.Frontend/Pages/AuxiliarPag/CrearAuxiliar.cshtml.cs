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
    public class CrearAuxiliarModel : PageModel
    {
        private static IRepositorioAuxiliar _repoAuxiliar = new RepositorioAuxiliar(new Persistencia.AppContext());

        [BindProperty]
        public Auxiliar NewAuxiliar { get; set; } = new();
        public void OnGet()
        {
        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return Page();
            }

            _repoAuxiliar.AddAuxiliar(NewAuxiliar);
            return Page();
        }
    }
}