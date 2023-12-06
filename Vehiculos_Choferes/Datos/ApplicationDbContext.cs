using Microsoft.EntityFrameworkCore;
using Vehiculos_Choferes.Modelos;

namespace Vehiculos_Choferes.Datos
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        //Ponemos los modelos que creamos
        public DbSet<Chofer> Chofer { get; set; }

        public DbSet<Vehiculo> Vehiculo { get; set; }
    }
}
