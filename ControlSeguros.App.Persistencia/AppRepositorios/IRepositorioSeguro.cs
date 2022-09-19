using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioSeguro
    {

        IEnumerable<Seguro> GetAllSeguro();

        Seguro AddSeguro(Seguro Seguro);
        Seguro UpdateSeguro(Seguro Seguro);
        void DeleteSeguro(int Id);
        Seguro GetSeguro(int Id);

    }

}