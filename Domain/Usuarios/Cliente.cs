using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class Cliente
    {
        private int numero;
        private Pessoa pessoa;

        public Cliente(Pessoa pessoa)
        {
            this.pessoa = pessoa;
        }

        public Pessoa Pessoa { get; private set; }

        public long Numero { get; private set; }

    }
}
