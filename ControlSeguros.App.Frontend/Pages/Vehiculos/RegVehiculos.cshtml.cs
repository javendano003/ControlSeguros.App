using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;



namespace ControlSeguros.App.Frontend.Pages.Vehiculos
{
    public class RegVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo _repoVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        private readonly IRepositorioVehiculoTipo _repoVehiculoTipo = new RepositorioVehiculoTipo(new Persistencia.AppContext());
        public dynamic ViewBag { get;set; }

        [BindProperty]
        public Vehiculo NewVehiculo { get; set; } = new();
         public IEnumerable<VehiculoTipo> ListaVehiculoTipo {get; set;}
        public IActionResult OnGet()
        {
            ListaVehiculoTipo = _repoVehiculoTipo.GetAllVehiculoTipos();

            //ViewBag.VehiculoTipo = "VehiculoTi";
            //ViewBag.VehiculoTip = _repoVehiculoTipo.GetAllVehiculoTipos();
            ViewData["TipoVehiculo"] = new SelectList(ListaVehiculoTipo, "VehiculoTipoId", "Descripcion");
            return Page();

        }

        public IActionResult OnPost()
        {
            if (!ModelState.IsValid)
            {
                return RedirectToAction("Get");
            }

            _repoVehiculo.AddVehiculo(NewVehiculo);
            return Page();
        }
    }
}