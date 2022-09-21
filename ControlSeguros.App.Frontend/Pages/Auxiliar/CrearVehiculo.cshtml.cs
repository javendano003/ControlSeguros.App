using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class CrearVehiculo : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
         
        public Vehiculo vehiculo { get; set; }

        public IActionResult OnPost(Vehiculo vehiculo)
        {
            if(!ModelState.IsValid)
            {
                return Page();
            }
            else
            {
                repositorioVehiculo.AddVehiculo(vehiculo);
                return Page();
            }

        }
    }
}