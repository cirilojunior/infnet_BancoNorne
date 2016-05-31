using Domain.Operacoes;
using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    class Conta
    {

        public enum TipoConta
        {
            POUPANCA, CORRENTE, ELETRONICA, SALARIO, ESPECIAL_ELETRONICA
        }

        public enum SituacaoCriacaoConta
        {
            PENDENTE_APROVACAO, APROVADA, REPROVADA
        }

        public enum SituacaoConta
        {
            VIGENTE, ENCERRADA
        }

        public Cliente Cliente { get; set; }
        public TipoConta Tipo { get; set; }
        public SituacaoCriacaoConta SituacaoCriacao { get; set; }
        public SituacaoConta Situacao { get; set; }
        public decimal Saldo { get; set; }
        public List<Operacao> Operacoes { get; set; }

        public decimal Depositar(decimal valor)
        {
            Saldo += valor;
            return Saldo;
        }

        public virtual decimal Retirar(decimal valor)
        {
            if(valor > Saldo)
            {
                throw new Exception("Saldo insuficiente para realizar uma retirada.");
            }
            Saldo -= valor;
            return Saldo;
        }
    }
}
