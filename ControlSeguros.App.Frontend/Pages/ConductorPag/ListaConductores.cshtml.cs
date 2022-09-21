using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.ConductorPag
{
    public class ListaConductoresModel : PageModel
    {
        private readonly IRepositorioConductor _repoConductor = new RepositorioConductor(new Persistencia.AppContext());
        public IEnumerable<Conductor> ListaConductor {get; set;}
        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaConductor =  _repoConductor.GetAllConductores();
            }
            else
            {
                ListaConductor = _repoConductor.BuscarConductor(filtroBusqueda);
            }
        }
        public IActionResult OnPost(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoConductor.DeleteConductor(Id);
            return RedirectToAction("Get");
        }
    }
}