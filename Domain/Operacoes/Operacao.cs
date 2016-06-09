using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Operacoes
{
    public class Operacao
    {

        public enum NaturezaOperacao
        {
            CREDITO, DEBITO
        }

        public string codigoTransacao { get; set; }

        public DateTime Data { get; set; }

        public decimal Valor { get; set; }

        public NaturezaOperacao Natureza { get; set; }

    }
}
