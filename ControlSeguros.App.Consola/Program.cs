using System;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Persistencia;

namespace ControlSeguros.App.Consola
{
    class program
    {
        private static IRepositorioUsuario _repoUsuario = new RepositorioUsuario(new Persistencia.AppContext());
        static void Main (String[] args)
        {
            Console.WriteLine("Hello Control Seguros");
            //AddUsuario();
            BuscarUsuario(1);
        }

        private static void AddUsuario()
        {
            var usuario = new Usuario
            {
                Nombre = "Juan",
                Apellido = "Perez",
                NumeroTelefono = "6053326565",
                email = "juan123@gmail.com",
                NombreUsuario = "juaper001",
                Password = "abcd1234",
                TipoUsuario = "Auxiliar",
                FechaIngreso = new DateTime(2022, 09, 01)
            };
            _repoUsuario.AddUsuario(usuario);
        }

        private static void BuscarUsuario(int Id)
        {
            var usuario = _repoUsuario.GetUsuario(Id);
            Console.WriteLine(usuario.Nombre+" "+usuario.Apellido);
        }

        

    
    }
}