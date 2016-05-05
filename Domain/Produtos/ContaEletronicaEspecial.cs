using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class ContaEletronicaEspecial : ContaEletronica
    {
        private double limiteChequeEspecial;

        public double LimiteChequeEspecial
        {
            get { return limiteChequeEspecial; }
            set { limiteChequeEspecial = value; }
        }

    }
}
