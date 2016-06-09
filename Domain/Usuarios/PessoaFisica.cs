using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class PessoaFisica : Pessoa
    {
        public string Cpf { get; set; }
        public string Identidade { get; set; }
        public string Nome { get; set; }
        public double rendaMensal { get; set; }
    }
}
