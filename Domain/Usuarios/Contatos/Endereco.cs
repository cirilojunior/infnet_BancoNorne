using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios.Contatos
{
    class Endereco
    {

        public enum UF
        {
            RJ, SP, ES, MG
        }

        public string Logradouro { get; set; }
        public string Numero { get; set; }
        public string Complemento { get; set; }
        public string Cep { get; set; }
        public string Cidade { get; set; }
        public UF Estado { get; set; } 
    }
}
