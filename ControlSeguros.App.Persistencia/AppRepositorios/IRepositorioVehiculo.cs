using System.Collections.Generic;
using ControlSeguros.App.Dominio.Entidades;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioVehiculo
    {

        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo vvehiculo);
        Vehiculo UpdateVehiculo(Vehiculo vvehiculo);
        void DeleteVehiculo(int vvehiculoId);
        Vehiculo GetVehiculo(int vvehiculoId);

    }

}