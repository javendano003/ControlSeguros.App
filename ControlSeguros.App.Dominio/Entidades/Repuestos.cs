using System;
using System.ComponentModel.DataAnnotations;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class Repuestos
    {
        [Key]
        public int RepuestosId {get;set; }
        public string? Descripcion { get; set; }
    }
}