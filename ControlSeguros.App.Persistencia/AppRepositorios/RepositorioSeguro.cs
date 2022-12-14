using System.Collections.Generic;
using System.Linq;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Persistencia
{
    public class RepositorioSeguro : IRepositorioSeguro
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
        public RepositorioSeguro(AppContext appContext)
        {
            _appContext = appContext;
        }

        Seguro IRepositorioSeguro.AddSeguro(Seguro Seguro)
        {
            var SeguroCreado = _appContext.Seguros.Add(Seguro);
            _appContext.SaveChanges();
            return SeguroCreado.Entity;
        }

        void IRepositorioSeguro.DeleteSeguro(int Id)
        {
            var SeguroCreado = _appContext.Seguros.FirstOrDefault(u => u.SeguroId == Id);
            if (SeguroCreado == null)
            return;
            _appContext.Seguros.Remove(SeguroCreado);
            _appContext.SaveChanges();
        }

        IEnumerable<Seguro> IRepositorioSeguro.GetAllSeguro()
        {
            return _appContext.Seguros;
        }

        
        Seguro IRepositorioSeguro.GetSeguro(int Id)
        {
            return _appContext.Seguros.FirstOrDefault(u => u.SeguroId == Id);
        }

        Seguro IRepositorioSeguro.UpdateSeguro(Seguro vseguro)
        {
            var vseguroEncontrado = _appContext.Seguros.FirstOrDefault(p => p.SeguroId == vseguro.SeguroId);
            if (vseguroEncontrado != null)
            {
                vseguroEncontrado.CodigoSeguro = vseguro.CodigoSeguro;
                vseguroEncontrado.FechaCompra = vseguro.FechaCompra;
                vseguroEncontrado.FechaVencimiento = vseguro.FechaVencimiento;
                vseguroEncontrado.TipoSeguroId = vseguro.TipoSeguroId;
                vseguroEncontrado.VehiculoId = vseguro.VehiculoId;
                                
                _appContext.SaveChanges();

            }
            return vseguroEncontrado;
        }
    }
}