using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    public class AdesaoProduto
    {
        public Produto Produto { get; set; }
        public Cliente Cliente { get; set; }
        public DateTime Data { get; set; }
    }
}
