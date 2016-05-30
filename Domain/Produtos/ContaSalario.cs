using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class ContaSalario : ContaCorrente
    {
        private PessoaJuridica fontePagadora;

        public PessoaJuridica FontePagadora
        {
            get { return fontePagadora; }
            set { fontePagadora = value; }
        }

    }
}
