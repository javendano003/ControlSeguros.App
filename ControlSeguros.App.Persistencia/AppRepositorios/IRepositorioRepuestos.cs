using System.Collections.Generic;
using ControlSeguros.App.Dominio.Entidades;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioRepuestos
    {

        IEnumerable<Repuestos> GetAllRepuestos();
        // Seguro AddRepuestos(Repuestos Repuestos);
        // Seguro UpdateRepuestos(Repuestos Repuestos);
        void DeleteRepuestos(int Repuestos);
        // Seguro GetRepuestos(int Repuestos);

    }
}