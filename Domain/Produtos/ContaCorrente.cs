using Domain.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class ContaCorrente : Produto
    {
        private double saldo;
        private List<Operacao> operacoes;

        public double Saldo
        {
            get { return saldo; }
            set { saldo = value; }
        }

        public List<Operacao> Operacoes
        {
            get { return operacoes; }
            set { operacoes = value; }
        }


    }
}
