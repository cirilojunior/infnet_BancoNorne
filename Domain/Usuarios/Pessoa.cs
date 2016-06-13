using Domain.Usuarios.Contatos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class Pessoa
    {
        public long Id { get; set; }
        public Endereco Endereco { get; set; }
        public Contato Contato { get; set; }

        public Pessoa()
        {
        }
    }
}
