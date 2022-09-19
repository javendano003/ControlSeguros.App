using System;

namespace ControlSeguros.App.Dominio
{
    public class Seguro
    {
        public int Id { get; set; }
        public string TipoSeguro { get; set; }
        public DateTime FechaCompra { get; set; }
        public DateTime FechaVencimiento { get; set; }

    }

}