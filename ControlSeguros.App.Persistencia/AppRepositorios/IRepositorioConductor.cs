using System.Collections.Generic;
using ControlSeguros.App.Dominio.Entidades;


namespace ControlSeguros.App.Persistencia.AppRepositorios
{

    public interface IRepositorioConductor
    {

        IEnumerable<Conductor> GetAllConductores();
        Conductor AddConductor(Conductor conductor);
        Conductor UpdateConductor(Conductor conductor);
        void DeleteConductor(int idConductor);
        Conductor GetConductor(int idConductor);

    }
}