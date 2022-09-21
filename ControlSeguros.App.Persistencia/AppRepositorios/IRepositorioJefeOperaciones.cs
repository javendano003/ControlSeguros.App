using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioJefeOperaciones
    {

        IEnumerable<JefeOperaciones> GetAllJefeOperaciones();
        JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeOperaciones);
        JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeOperaciones);
        void DeleteJefeOperaciones(int idJefeOperaciones);
        JefeOperaciones GetJefeOperaciones(int idJefeOperaciones);

    }
}