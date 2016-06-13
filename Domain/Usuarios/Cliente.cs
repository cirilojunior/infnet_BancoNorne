using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class Cliente
    {
        public Cliente()
        {
        }

        public Cliente(Pessoa pessoa)
        {
            Pessoa = pessoa;
        }

        public Pessoa Pessoa { get; private set; }

        public long Id { get; set; }
    }
}
