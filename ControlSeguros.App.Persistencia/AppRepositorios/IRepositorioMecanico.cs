using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioMecanico
    {

        IEnumerable<Mecanico> GetAllMecanicos();
        Mecanico AddMecanico(Mecanico Mecanico);
        Mecanico UpdateMecanico(Mecanico Mecanico);
        void DeleteMecanico(int idMecanico);
        Mecanico GetMecanico(int idMecanico);
        IEnumerable<Mecanico> BuscarMecanico(string filtro);
    }
}