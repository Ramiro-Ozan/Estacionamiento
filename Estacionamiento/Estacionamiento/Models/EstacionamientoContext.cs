using Estacionamiento.Entidad;
using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.Xml;

namespace Estacionamiento.Models
{
    public class EstacionamientoContext : DbContext
    {
        public DbSet<Usuario> usuarios { get; set; }
        public DbSet<Estacionamiento> estacionamientos { get; set; }
        public DbSet<Cliente> cliente { get; set; }
        public DbSet<Administrador> administradors { get; set; }    
        public DbSet<Plan> Plan { get; set; }
        public DbSet<Ticket> ticket { get; set; }
        
        public DbSet<Vehiculo> vehiculos { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Data Source=., Initial Catalog = EstacionamientoDB;" + "Encryp = ture;" + "TrustServerCertificate = true;" + "Integrated Security = ture");
            base.OnConfiguring(optionsBuilder);
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Estacionamiento>().HasOne(est => est.Clientes).WithMany(c => c.Estacionamiento);
        }

    }
}
