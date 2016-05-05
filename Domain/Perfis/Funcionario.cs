using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Perfis
{
    class Funcionario
    {
        private string matricula;
        private string nome;

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Matricula
        {
            get { return matricula; }
            set { matricula = value; }
        }
            
    }
}
