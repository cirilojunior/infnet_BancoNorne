using Domain.Usuarios;
using System;

namespace Domain.Produtos
{
    public class AdesaoProduto
    {
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
        public Funcionario aprovador { get; set; }
    }
}
