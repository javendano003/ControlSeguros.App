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
    public class ListaAuxiliaresModel : PageModel
    {
        private readonly IRepositorioAuxiliar _repoAuxiliar= new RepositorioAuxiliar(new Persistencia.AppContext());
        public IEnumerable<Auxiliar> ListaAuxiliar {get; set;}
        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaAuxiliar =  _repoAuxiliar.GetAllAuxiliares();
            }
            else
            {
                ListaAuxiliar = _repoAuxiliar.BuscarAuxiliar(filtroBusqueda);
            }
        }
        public IActionResult OnPost(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoAuxiliar.DeleteAuxiliar(Id);
            return RedirectToAction("Get");
        }
    }
}