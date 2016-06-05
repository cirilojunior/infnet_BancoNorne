using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    interface AdesaoProdutoRepository
    {
        AdesaoProduto salvar(AdesaoProduto adesao);
    }
}
