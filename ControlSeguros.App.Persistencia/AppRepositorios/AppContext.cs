using Microsoft.EntityFrameworkCore;
using ControlSeguros.App.Dominio;
using ControlSeguros.App.Dominio.Entidades;

namespace ControlSeguros.App.Persistencia
{

    public class AppContext : DbContext
    {

        public DbSet<Auxiliar>? Auxiliares { get; set; }
        public DbSet<Conductor>? Conductores { get; set; }
        public DbSet<JefeOperaciones>? JefeOperaciones { get; set; }
        public DbSet<Mecanico>? Mecanicos { get; set; }
        public DbSet<Propietario>? Propietarios { get; set; }
        public DbSet<TipoSeguro>? Tiposeguros { get; set; }
        public DbSet<VehiculoTipo>? VehiculoTipos { get; set; }
        public DbSet<Vehiculo>? Vehiculos { get; set; }
        public DbSet<Seguro>? Seguros { get; set; }
        public DbSet<Revision>? Revisiones { get; set; }
        public DbSet<CompraRepuestos>? ComprasRepuestos { get; set; }
        public DbSet<Repuestos>? Repuestos { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder
                .UseSqlServer(@"Data Source = DESKTOP-MSCL69Q\SQLEXPRESS; Initial Catalog = ControlSeguros; Integrated security = true");
            }

            //    protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
            //  {
            //    if (!optionsBuilder.IsConfigured)
            //    {
            //     optionsBuilder
            //     .UseSqlServer(" Data Source = localdb)\\MSSQLLocalDB; Initial Catalog = ControlSeguros.Data");
            //    }


        }

    }

}