using System.Collections.Generic;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Persistencia.AppRepositorios
{
    public interface IRepositorioJefeOperaciones
    {
        IEnumerable<JefeOperaciones> GetAllJefeOperaciones();
        JefeOperaciones AddJefeOperaciones(JefeOperaciones jefeOperaciones);
        JefeOperaciones UpdateJefeOperaciones(JefeOperaciones jefeOperaciones);
        void DeleteJefeOperaciones(int idJefeOperaciones);
        JefeOperaciones GetJefeOperaciones(int idJefeOperaciones);
        IEnumerable<JefeOperaciones> BuscarJefeOperacion(string filtro);
    }
}