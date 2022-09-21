using System.Collections.Generic;
using ControlSeguros.App.Dominio.Entidades;


namespace ControlSeguros.App.Persistencia
{

    public interface IRepositorioPropietario
    {

        IEnumerable<Propietario> GetAllPropietario();
        Propietario AddPropietario(Propietario Propietario);
        Propietario UpdatePropietario(Propietario Propietario);
        void DeletePropietario(int idPropietario);
        Propietario GetPropietario(int idPropietario);
        IEnumerable<Propietario> BuscarPropietario(string filtro);
<<<<<<< HEAD

=======
>>>>>>> 6e833710430053eeda79223dbe23e3b02dc067f5
    }
}