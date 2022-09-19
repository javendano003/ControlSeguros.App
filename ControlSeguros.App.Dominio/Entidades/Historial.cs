using System;

namespace ControlSeguros.App.Dominio
{
    public class Historial
    {
        public int Id { get; set; }
        public string NivelAceite { get; set; }
        public string NivelLiquidoFreno { get; set; }
        public string NivelRefrigerante { get; set; }
        public DateTime FechaRevision { get; set; }
        public String DescripcionReparacion { get; set; }

    }

}