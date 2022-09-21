using System.Collections.Generic;
using System.Linq;
using ControlSeguros.App.Dominio;

namespace ControlSeguros.App.Persistencia.AppRepositorios
{
    public class RepositorioCompraRepuestos : IRepositorioCompraRepuestos
    {

        ///<summary>
        ///Referencia al contexto de CompraRepuestos
        ///</summary>

        private readonly AppContext _appContext;
        ///<summary>
        ///Metodo Constructos 
        /// Inyeccion de dependencias para indicar el contexto a utilizar
        ///</summary>
        ///<param name="appContext"></param>//

        public RepositorioCompraRepuestos(AppContext appContext)
        {
            _appContext = appContext;
        }


        CompraRepuestos IRepositorioCompraRepuestos.AddComprarRepuestos(CompraRepuestos CompraRepuestos)
        {
            var CompraRepuestosCreado = _appContext.ComprasRepuestos.Add(CompraRepuestos);
            _appContext.SaveChanges();
            return CompraRepuestosCreado.Entity;
        }

        void IRepositorioCompraRepuestos.DeleteComprarRepuestos(int IdCompraRepuestos)
        {

            var CompraRepuestosEncontrado = _appContext.ComprasRepuestos.FirstOrDefault(p => p.CompraRepuestosId == IdCompraRepuestos);
            if (CompraRepuestosEncontrado == null)
                return;
            _appContext.ComprasRepuestos.Remove(CompraRepuestosEncontrado);
            _appContext.SaveChanges();
        }


        IEnumerable<CompraRepuestos> IRepositorioCompraRepuestos.GetAllComprarRepuestos()
        {

            return _appContext.ComprasRepuestos;
        }


        CompraRepuestos IRepositorioCompraRepuestos.GetComprarRepuestos(int IdCompraRepuestos)
        {
            return _appContext.ComprasRepuestos.FirstOrDefault(p => p.CompraRepuestosId == IdCompraRepuestos);
        }

        CompraRepuestos IRepositorioCompraRepuestos.UpdateComprarRepuestos(CompraRepuestos CompraRepuestos)
        {
            var CompraRepuestosEncontrado = _appContext.ComprasRepuestos.FirstOrDefault(p => p.CompraRepuestosId == CompraRepuestos.CompraRepuestosId);
            if (CompraRepuestosEncontrado != null)
            {
                CompraRepuestosEncontrado.Valor = CompraRepuestos.Valor;
                CompraRepuestosEncontrado.FechaCompra = CompraRepuestos.FechaCompra;
                CompraRepuestosEncontrado.Justificacion = CompraRepuestos.Justificacion;
                CompraRepuestosEncontrado.RepuestosId = CompraRepuestos.RepuestosId;
                CompraRepuestosEncontrado.Repuestos = CompraRepuestos.Repuestos;                
                CompraRepuestosEncontrado.RevisionId = CompraRepuestos.RevisionId;
                CompraRepuestosEncontrado.revision = CompraRepuestos.revision; 
                
                
                _appContext.SaveChanges();

            }
            return CompraRepuestosEncontrado;

        }

    }

}