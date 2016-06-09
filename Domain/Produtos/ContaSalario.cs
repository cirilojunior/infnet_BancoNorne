using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    public class ContaSalario : ContaCorrente
    {

        public PessoaJuridica FontePagadora{ get; set; }

    }
}
