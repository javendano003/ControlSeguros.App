using System.Collections.Generic;
using System.Linq;
using ControlSeguros.App.Dominio;

namespace ControlSeguros.App.Persistencia.AppRepositorios
{
    public class RepositorioUsuario : IRepositorioUsuario
    {
        ///<summary>
        ///Referencia al contexto de Paciente
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//
        public RepositorioUsuario(AppContext appContext)
        {
            _appContext = appContext;
        }

        Usuario IRepositorioUsuario.AddUsuario(Usuario usuario)
        {
            var usuarioCreado = _appContext.Usuarios.Add(usuario);
            _appContext.SaveChanges();
            return usuarioCreado.Entity;
        }

        void IRepositorioUsuario.DeleteUsuario(int Id)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(u => u.Id == Id);
            if (usuarioEncontrado == null)
            return;
            _appContext.Usuarios.Remove(usuarioEncontrado);
            _appContext.SaveChanges();
        }

        IEnumerable<Usuario> IRepositorioUsuario.GetAllUsuarios()
        {
            return _appContext.Usuarios;
        }

        Usuario IRepositorioUsuario.GetUsuario(int Id)
        {
            return _appContext.Usuarios.FirstOrDefault(p=> p.Id == Id);
        }

        Usuario IRepositorioUsuario.UpdateUsuario(Usuario usuario)
        {
            var usuarioEncontrado = _appContext.Usuarios.FirstOrDefault(p => p.Id == usuario.Id);
            if (usuarioEncontrado!=null)
            {
                usuarioEncontrado.Nombre = usuario.Nombre;
                usuarioEncontrado.Apellido = usuario.Apellido;
                usuarioEncontrado.NumeroTelefono = usuario.NumeroTelefono;
                usuarioEncontrado.email = usuario.email;
                usuarioEncontrado.NombreUsuario = usuario.NombreUsuario;
                usuarioEncontrado.Password = usuario.Password;
                usuarioEncontrado.TipoUsuario = usuario.TipoUsuario;
                usuarioEncontrado.FechaIngreso = usuario.FechaIngreso;

                _appContext.SaveChanges();

            }
            return usuarioEncontrado;
        }
    }
}