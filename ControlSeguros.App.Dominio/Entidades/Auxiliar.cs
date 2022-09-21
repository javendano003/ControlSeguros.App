using System.ComponentModel.DataAnnotations;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class Auxiliar
    {
        [Key]
        public int AuxiliarId { get; set; }
        public string? Documento { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono {get;set;}
        public DateTime? FechaNacimiento {get;set;}
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public string? Direccion { get; set; }
    }
}