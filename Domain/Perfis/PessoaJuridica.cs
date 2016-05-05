using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Perfis
{
    class PessoaJuridica : Pessoa
    {
        private string cnpj;
        private string razaoSocial;

        public string Cnpj
        {
            get { return cnpj; }
            set { cnpj = value; }
        }

        public string RazaoSocial
        {
            get { return razaoSocial; }
            set { razaoSocial = value; }
        }

    }
}
