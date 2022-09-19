using Microsoft.EntityFrameworkCore;
using ControlSeguros.App.Dominio;

namespace ControlSeguros.App.Persistencia
{

  public class AppContext : DbContext
  {

    public DbSet<Usuario> Usuarios {get; set;} = null!;
    public DbSet<Vehiculo> Vehiculos {get; set;} = null!;
    public DbSet<Seguro> Seguros {get; set;} = null!;
    public DbSet<Repuesto> Respuestos { get; set; } = null!;
    public DbSet<Historial> Historial {get; set;} = null!;

   
   protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
   {
     if (!optionsBuilder.IsConfigured)
     {
      optionsBuilder
      .UseSqlServer(@"Data Source = DESKTOP-MSCL69Q\SQLEXPRESS; Initial Catalog = ControlSeguros2; Integrated security = true");
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