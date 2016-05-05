using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Perfis
{
    class PessoaFisica : Pessoa
    {
        private string cpf;
        private string identidade;
        private string nome;

        public string Identidade
        {
            get { return identidade; }
            set { identidade = value; }
        }

        public string Cpf
        {
            get { return cpf; }
            set { cpf = value; }
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

    }
}
