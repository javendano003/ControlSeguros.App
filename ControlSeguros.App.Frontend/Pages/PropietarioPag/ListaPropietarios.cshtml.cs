using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.PropietarioPag
{
    public class ListaPropietariosModel : PageModel
    {
        private readonly IRepositorioPropietario _repoPropietario= new RepositorioPropietario(new Persistencia.AppContext());
        public IEnumerable<Propietario> ListaPropietario {get; set;}
        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaPropietario =  _repoPropietario.GetAllPropietario();
            }
            else
            {
                ListaPropietario = _repoPropietario.BuscarPropietario(filtroBusqueda);
            }
        }
        public IActionResult OnPost(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoPropietario.DeletePropietario(Id);
            return RedirectToAction("Get");
        }
    }
}