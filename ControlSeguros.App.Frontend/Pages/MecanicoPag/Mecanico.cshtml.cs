using ControlSeguros.App.Persistencia;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Frontend.Pages.MecanicoPag
{
    public class MecanicoModel : PageModel
    {
        private readonly IRepositorioMecanico _repoMecanico= new RepositorioMecanico(new Persistencia.AppContext());
        public IEnumerable<Mecanico> ListaMecanicos {get; set;} = null!;

        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda { get; set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaMecanicos =  _repoMecanico.GetAllMecanicos();
            }
            else
            {
                ListaMecanicos = _repoMecanico.BuscarMecanico(filtroBusqueda);
            }
        }
        public IActionResult OnPost(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoMecanico.DeleteMecanico(Id);
            return RedirectToAction("Get");
        }
    }
}