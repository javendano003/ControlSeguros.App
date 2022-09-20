using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia.AppRepositorios;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;


namespace ControlSeguros.App.Frontend.Pages.Auxiliar
{
    public class EditUsuario : PageModel
    {
        private readonly IRepositorioUsuario repositorioUsuario = new RepositorioUsuario(new Persistencia.AppContext());

        public Usuario usuario { get; set; }

        public IActionResult OnGet(int usuarioId)
        {
            usuario = repositorioUsuario.GetUsuario(usuarioId);
            if (usuario==null)
            {
                return RedirectToPage("./NotFound");
            }
            else
            {
                return Page();
            }
        }

        public IActionResult OnPost(Usuario usuario)
        { 
            Console.WriteLine($"Usuario ID: {usuario.Id}");
            repositorioUsuario.UpdateUsuario(usuario);
            return RedirectToPage("ListaUsuarios");
        }
    }
}