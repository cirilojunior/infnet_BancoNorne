using System.Data.Entity;

namespace Domain.Produtos
{
    public class ContaRepositoryDbContext : DbContext
    {
        public ContaRepositoryDbContext() : base("Conta")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<Conta> Contas { get; set; }
    }
}