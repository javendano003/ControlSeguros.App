using System;

namespace ControlSeguros.App.Dominio
{
    public class Usuario
    {
        public int Id { get; set; }
        public string Nombre { get; set; } = null!;
        public string Apellido { get; set; } = null!;
        public string NumeroTelefono { get; set; } = null!;
        public string email { get; set; } = null!;
        public string NombreUsuario { get; set; } = null!;
        public string Password { get; set; } = null!;
        public string TipoUsuario { get; set; } = null!;
        public DateTime FechaIngreso { get; set; }
    }

}