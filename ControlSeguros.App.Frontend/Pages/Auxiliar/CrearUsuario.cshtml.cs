using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class CrearUsuario : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuario = new RepositorioUsuario(new Persistencia.AppContext());
         
        public Usuario usuario { get; set; }

        public IActionResult OnPost()
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                repositorioUsuario.AddUsuario(usuario);
                return Page();
            }

        }
        
    }
}