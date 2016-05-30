using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Produtos;
using Domain.Usuarios;

namespace Domain.Produtos
{
    class ContaService
    {
        public Conta Abrir(Conta.TipoConta tipo, Pessoa pessoa)
        {
            return new Conta();
        }

        public AdesaoProduto Aprovar(Produto produto, Cliente cliente)
        {
            return new AdesaoProduto();
        }
    }
}
