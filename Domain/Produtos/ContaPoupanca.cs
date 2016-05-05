using Domain.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class ContaPoupanca
    {
        private double saldo;
        private List<Operacao> operacoes;

        public List<Operacao> Operacoes
        {
            get { return operacoes; }
            set { operacoes = value; }
        }

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

    }
}
