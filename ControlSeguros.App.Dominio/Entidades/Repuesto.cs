using System;

namespace ControlSeguros.App.Dominio
{
    public class Repuesto
    {
        public string Id { get; set; }
        public string NombreRepuesto { get; set; }
        public int Cantidad { get; set; }
        public DateTime FechaCompra { get; set; }

    }

}