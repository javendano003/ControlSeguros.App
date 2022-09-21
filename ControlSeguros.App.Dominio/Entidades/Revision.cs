using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class Revision
    {
        public int RevisionId { get; set; }
        public DateTime Fecha { get; set; }
        public String? NiveldeAceite { get; set; }
        public String? NivelFrenos { get; set; }
        public String? NiveldeRefrigerante { get; set; }
        public String? NivelDireccion { get; set; }
        public int Repuestos { get; set; }
        public int VehiculoId { get; set; }
        public Vehiculo? Vehiculo { get; set; }
    }
}