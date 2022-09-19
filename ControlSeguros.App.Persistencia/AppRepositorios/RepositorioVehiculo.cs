using System.Collections.Generic;
using System.Linq;
using ControlSeguros.App.Dominio;

namespace ControlSeguros.App.Persistencia
{
    public class RepositorioVehiculo : IRepositorioVehiculo
    {
        ///<summary>
        ///Referencia al contexto de Paciente
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructor 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//
        public RepositorioVehiculo(AppContext appContext)
        {
            _appContext = appContext;
        }

        IEnumerable<Vehiculo> IRepositorioVehiculo.GetAllVehiculos()
        {
            return _appContext.Vehiculos;
        }

        Vehiculo IRepositorioVehiculo.AddVehiculo(Vehiculo vehiculo)
        {
            var VehiculoCreado = _appContext.Vehiculos.Add(vehiculo);
            _appContext.SaveChanges();
            return VehiculoCreado.Entity;
        }

        void IRepositorioVehiculo.DeleteVehiculo(string Id)
        {
            var VehiculoCreado = _appContext.Vehiculos.FirstOrDefault(u => u.Id == Id);
            if (VehiculoCreado == null)
            return;
            _appContext.Vehiculos.Remove(VehiculoCreado);
            _appContext.SaveChanges();
        }

        
        Vehiculo IRepositorioVehiculo.GetVehiculo(string Id)
        {
            return _appContext.Vehiculos.FirstOrDefault(u => u.Id == Id);
        }

        Vehiculo IRepositorioVehiculo.UpdateVehiculo(Vehiculo Vehiculo)
        {
            var VehiculoEncontrado = _appContext.Vehiculos.FirstOrDefault(u => u.Id == Vehiculo.Id);
            if (VehiculoEncontrado!=null)
            {
                VehiculoEncontrado.Modelo = Vehiculo.Modelo;
                VehiculoEncontrado.Año = Vehiculo.Año;
                VehiculoEncontrado.Marca = Vehiculo.Marca;
                

                _appContext.SaveChanges();

            }

            return VehiculoEncontrado;
        }
    }
}