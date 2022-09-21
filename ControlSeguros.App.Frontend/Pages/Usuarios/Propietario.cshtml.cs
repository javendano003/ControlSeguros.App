using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Frontend.Pages.Usuarios
{
    public class PropietarioModel : PageModel
    {
        private readonly IRepositorioPropietario _repoPropietario= new RepositorioPropietario(new Persistencia.AppContext());
        public IEnumerable<Propietario> ListaPropietarios {get; set;}

        [BindProperty(SupportsGet =true)]    
        public string FiltroBusqueda { get; set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaPropietarios =  _repoPropietario.GetAllPropietario();
            }
            else
            {
                ListaPropietarios = _repoPropietario.BuscarPropietario(filtroBusqueda);
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