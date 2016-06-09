using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class PessoaJuridica : Pessoa
    {
        public string Cnpj { get; set; }
        public string razaoSocial { get; set; }
        public double faturamentoAnual { get; set; }
    }
}
