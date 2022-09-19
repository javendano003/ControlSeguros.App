using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia.AppRepositorios
{

    public interface IRepositorioUsuario
    {

        IEnumerable<Usuario> GetAllUsuarios();

        Usuario AddUsuario(Usuario usuario);
        Usuario UpdateUsuario(Usuario usuario);
        void DeleteUsuario(int Id);
        Usuario GetUsuario(int Id);

    }

}