using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia.AppRepositorios;
using ControlSeguros.App.Persistencia;

namespace ControlSeguros.App.Frontend.Pages
{
    public class ConsultarVehiculosModel : PageModel
    {
        private readonly IRepositorioVehiculo repositorioVehiculo = new RepositorioVehiculo(new Persistencia.AppContext());
        public IEnumerable<Vehiculo> VehiculoList { get; set; }
        public void OnGet()
        {
            VehiculoList = repositorioVehiculo.GetAllVehiculos();
        }

        public IActionResult OnPost()
        {
            repositorioVehiculo.GetAllVehiculos();
            return RedirectToAction("Get");
        } 
    }
}
