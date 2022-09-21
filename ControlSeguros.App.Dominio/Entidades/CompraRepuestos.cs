using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ControlSeguros.App.Dominio.Entidades
{
    public class CompraRepuestos
    {
        [Key]
        public int CompraRepuestosId  { get; set; }
        public string? Valor { get; set; }
        public DateTime FechaCompra { get; set; }
        public string? Justificacion { get; set; }              
        public int RepuestosId{ get; set; }
        public Repuestos? Repuestos {get;set;}
        public int RevisionId{get;set;}
        public Revision? revision{get;set;}
    }
}