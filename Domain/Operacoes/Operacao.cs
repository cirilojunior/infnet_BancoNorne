using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Operacoes
{
    class Operacao
    {

        public enum Tipo
        {
            CREDITO, DEBITO
        }

        private DateTime data;
        private double valor;
        private Tipo natureza;

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public Tipo Natureza
        {
            get { return natureza; }
            set { natureza = value; }
        }

    }
}
