using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using ControlSeguros.App.Dominio.Entidades;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using Microsoft.Extensions.Logging;

namespace ControlSeguros.App.Frontend.Pages.JefeOp
{
    public class ListaJefeOpModel : PageModel
    {
        private readonly IRepositorioJefeOperaciones _repoJefeOperaciones= new RepositorioJefeOperaciones(new Persistencia.AppContext());
        public IEnumerable<JefeOperaciones> ListaJefeOp {get; set;}
        [BindProperty(SupportsGet =true)]
        public string FiltroBusqueda {get;set;} = null!;
        public void OnGet(string filtroBusqueda)
        {
            if (filtroBusqueda==null)
            {
                ListaJefeOp =  _repoJefeOperaciones.GetAllJefeOperaciones();
            }
            else
            {
                ListaJefeOp = _repoJefeOperaciones.BuscarJefeOperacion(filtroBusqueda);
            }
        }
        public IActionResult OnPost(int Id)
        {
            //Console.WriteLine("Borrando web: "+ Id);
            _repoJefeOperaciones.DeleteJefeOperaciones(Id);
            return RedirectToAction("Get");
        }
    }
}