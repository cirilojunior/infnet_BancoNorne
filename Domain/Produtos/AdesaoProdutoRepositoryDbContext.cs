using System.Data.Entity;

namespace Domain.Produtos
{
    public class AdesaoProdutoRepositoryDbContext : DbContext
    {
        public AdesaoProdutoRepositoryDbContext() : base("AdesaoProduto")
        {
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
        }

        public DbSet<AdesaoProduto> AdesaoProdutos { get; set; }
    }
}