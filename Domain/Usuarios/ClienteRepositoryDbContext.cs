using System.Data.Entity;

namespace Domain.Usuarios
{
    public class ClienteRepositoryDbContext : DbContext
    {
        public ClienteRepositoryDbContext() : base("Cliente")
        {

        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Cliente> Clientes { get; set; }
    }
}
