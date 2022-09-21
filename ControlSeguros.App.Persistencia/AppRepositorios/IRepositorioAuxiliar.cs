using System.Collections.Generic;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Persistencia.AppRepositorios
{
    public interface IRepositorioAuxiliar
    {

        IEnumerable<Auxiliar> GetAllAuxiliares();
        Auxiliar AddAuxiliar(Auxiliar auxiliar);
        Auxiliar UpdateAuxiliar(Auxiliar auxiliar);
        void DeleteAuxiliar(int idAuxiliar);
        Auxiliar GetAuxiliar(int idAuxiliar);

    }
}