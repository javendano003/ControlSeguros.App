using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class ListaUsuarios : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuario = new RepositorioUsuario(new Persistencia.AppContext());
        public IEnumerable<Usuario> UsuarioList { get; set; }
        public void OnGet()
        {
            UsuarioList = repositorioUsuario.GetAllUsuarios();
        }

        public IActionResult OnPost(int id)
        {
            repositorioUsuario.DeleteUsuario(id);
            return RedirectToAction("Get");
        } 
    }

    
}