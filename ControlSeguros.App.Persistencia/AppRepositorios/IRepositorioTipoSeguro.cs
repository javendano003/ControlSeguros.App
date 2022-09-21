using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioTipoSeguro
    {

        IEnumerable<TipoSeguro> GetAllTipoSeguros();
        TipoSeguro AddTipoSeguro(TipoSeguro Vtiposeguro);
        TipoSeguro UpdateTipoSeguro(TipoSeguro Vtiposeguro);
        void DeleteTipoSeguro(int TipoSeguroId);
        TipoSeguro GetTipoSeguro(int TipoSeguroId);

    }
}