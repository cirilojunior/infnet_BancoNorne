using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Operacoes
{
    class Operacao
    {

        public enum Natureza
        {
            CREDITO, DEBITO
        }

        public DateTime Data { get; set; }

        public double Valor { get; set; }

        public Natureza Natureza { get; set; }

    }
}
