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

        public Cliente Cliente { get; set; }
        public TipoConta Tipo { get; set; }
        public double Saldo { get; set; }
        public List<Operacao> Operacoes { get; set; }
    }
}
