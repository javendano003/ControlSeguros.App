using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia.AppRepositorios;

namespace ControlSeguros.App.Frontend.Pages
{
    public class RegistroMecanicoModel : PageModel
    {
        private readonly IRepositorioUsuario RepositorioUsuario;
        [BindProperty]

        public Usuario Usuario {get; set;}

        // public RegistroMecanicoModel (IRepositorioUsuario RepositorioUsuario)
        // {
        //     this.RepositorioUsuario = RepositorioUsuario;
        // }

        public IActionResult OnGet(int? Id)
        {
            if (Id.HasValue)
            {
                Usuario=RepositorioUsuario.GetUsuario(Id.Value);
            }
            else
            {
                Usuario = new Usuario();
            }

            if (Usuario==null)
            {
                return RedirectToPage ("./NotFound");
            }
            else
            return Page();

        }

        public IActionResult OnPost()
        {
            if (Usuario.Id>0)
            {
                Usuario = RepositorioUsuario.UpdateUsuario(Usuario);
            }
            else
            {
                RepositorioUsuario.AddUsuario(Usuario);
            }
            return Page();
        }


    }
}
