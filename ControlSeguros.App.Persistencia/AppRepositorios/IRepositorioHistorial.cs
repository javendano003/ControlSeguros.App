using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioHistorial
    {

        IEnumerable<Historial> GetAllHistorial();

        Historial AddHistorial(Historial historial);
        Historial UpdateHistorial(Historial historial);
        void DeleteHistorial(int Id);
        Historial GetHistorial(int Id);

    }

}