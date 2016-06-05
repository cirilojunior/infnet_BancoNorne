using Domain.Operacoes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class ContaEletronicaEspecial : ContaEletronica
    {
        public decimal LimiteChequeEspecial { get; set; }
        public decimal LimiteUtilizado { get; set; }

        public override decimal Retirar(decimal valor)
        {
            if (valor > Saldo)
            {
                decimal saldoNegativo = valor - Saldo;
                decimal limiteDisponivel = LimiteChequeEspecial - LimiteUtilizado;

                if (saldoNegativo > limiteDisponivel)
                {
                    throw new Exception("Saldo insuficiente para realizar uma retirada.");
                }

                Saldo = 0;
                LimiteUtilizado -= saldoNegativo;
                registrarOperacao(Operacao.NaturezaOperacao.DEBITO, valor);
                return Saldo;
            }
            else
            {
                return base.Retirar(valor);
            }           
        }

    }
}
