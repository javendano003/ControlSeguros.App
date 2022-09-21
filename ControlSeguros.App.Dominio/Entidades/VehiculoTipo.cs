using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class VehiculoTipo
    {
        public int VehiculoTipoId  { get; set; }
        [MaxLength(30),MinLength(1)]
        public string? Descripcion { get; set; }
    }
}