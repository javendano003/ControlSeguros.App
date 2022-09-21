using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Persistencia.AppRepositorios
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