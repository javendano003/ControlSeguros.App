using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class Conductor
    {
        [Key]
        public int ConductorId { get; set; }
        public string? Documento { get; set; }
        public string? Nombre { get; set; }
        public string? Apellidos { get; set; }
        public string? Telefono {get;set;}
        public DateTime? FechaNacimiento {get;set;}
        public string? Usuario { get; set; }
        public string? Contraseña { get; set; }
        public string? Licencia { get; set; }
        public string? Direccion { get; set; }
        public string? NivelEstudio {get;set;}
    }
}