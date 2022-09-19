using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioVehiculo
    {

        IEnumerable<Vehiculo> GetAllVehiculos();
        Vehiculo AddVehiculo(Vehiculo Vehiculo);
        Vehiculo UpdateVehiculo(Vehiculo Vehiculo);
        void DeleteVehiculo(string Id);
        Vehiculo GetVehiculo(string Id);

    }

}