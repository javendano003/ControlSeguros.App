using System;

namespace ControlSeguros.App.Dominio
{
    public class Repuestos
    {
        public string Id { get; set; } = null!;
        public string NombreRepuesto { get; set; } = null!;
        public int Cantidad { get; set; }
        public DateTime FechaCompra { get; set; }

    }

}