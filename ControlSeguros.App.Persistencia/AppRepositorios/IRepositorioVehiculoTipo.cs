using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioVehiculoTipo
    {

        IEnumerable<VehiculoTipo> GetAllVehiculoTipos();
        VehiculoTipo AddVehiculoTipo(VehiculoTipo vvehiculoTipo);
        VehiculoTipo UpdateVehiculoTipo(VehiculoTipo vvehiculoTipo);
        void DeleteVehiculoTipo(int vvehiculoTipoId);
        VehiculoTipo GetVehiculoTipo(int vvehiculoTipoId);

    }
}