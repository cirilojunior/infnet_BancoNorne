using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Indices
{
    class ValorIndice
    {
        private double valor;
        private DateTime data;

        public double Valor
        {
            get { return valor; }
            set { valor = value; }
        }

        public DateTime Data
        {
            get { return data; }
            set { data = value; }
        }

    }
}
