using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    public interface AdesaoProdutoRepository
    {
        AdesaoProduto salvar(AdesaoProduto adesao);
    }

    public class AdesaoProdutoRepositoryMYSQL : AdesaoProdutoRepository
    {
        public AdesaoProduto salvar(AdesaoProduto adesao)
        {
            var context = new AdesaoProdutoRepositoryDbContext();
            context.AdesaoProdutos.Add(adesao);
            context.SaveChanges();
            return adesao;
        }

    }
}
