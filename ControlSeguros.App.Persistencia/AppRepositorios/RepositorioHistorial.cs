using System.Collections.Generic;
using System.Linq;
using ControlSeguros.App.Dominio;

namespace ControlSeguros.App.Persistencia
{
    public class RepositorioHistorial : IRepositorioHistorial
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

        public RepositorioHistorial(AppContext appContext)
        {
            _appContext = appContext;
        }

        Historial IRepositorioHistorial.AddHistorial(Historial historial)
        {
            var HistorialCreado = _appContext.Historial.Add(historial);
            _appContext.SaveChanges();
            return HistorialCreado.Entity;
        }

        void IRepositorioHistorial.DeleteHistorial(int Id)
        {
            var HistorialCreado = _appContext.Historial.FirstOrDefault(u => u.Id == Id);
            if (HistorialCreado == null)
            return;
            _appContext.Historial.Remove(HistorialCreado);
            _appContext.SaveChanges();
        }

        IEnumerable<Historial> IRepositorioHistorial.GetAllHistorial()
        {
            return _appContext.Historial;
        }

        Historial IRepositorioHistorial.GetHistorial(int Id)
{

    return _appContext.Historial.FirstOrDefault(p=> p.Id == Id);
}

        Historial IRepositorioHistorial.UpdateHistorial(Historial historial)
        {
            var HistorialEncontrado = _appContext.Historial.FirstOrDefault(u => u.Id == historial.Id);
            if (HistorialEncontrado!=null)
            {
                HistorialEncontrado.NivelAceite = historial.NivelAceite;
                HistorialEncontrado.NivelLiquidoFreno = historial.NivelLiquidoFreno;
                HistorialEncontrado.NivelRefrigerante = historial.NivelRefrigerante;
                HistorialEncontrado.FechaRevision = historial.FechaRevision;
                HistorialEncontrado.DescripcionReparacion = historial.DescripcionReparacion;

                _appContext.SaveChanges();

            }
            return HistorialEncontrado;
        }
    }
}