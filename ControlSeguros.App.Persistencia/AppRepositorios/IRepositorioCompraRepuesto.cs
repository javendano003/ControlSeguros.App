using System.Collections.Generic;
using ControlSeguros.App.Dominio;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioCompraRepuestos
    {

        IEnumerable<CompraRepuestos> GetAllComprarRepuestos();
        CompraRepuestos AddComprarRepuestos(CompraRepuestos ComprarRepuestos);
        CompraRepuestos UpdateComprarRepuestos(CompraRepuestos ComprarRepuestos);
        void DeleteComprarRepuestos(int ComprarRepuestosId);
        CompraRepuestos GetComprarRepuestos(int ComprarRepuestosId);

    }
}