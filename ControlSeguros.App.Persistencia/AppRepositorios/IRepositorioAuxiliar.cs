using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
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