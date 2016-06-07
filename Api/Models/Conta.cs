using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Presentation.Models
{
    public class Conta
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

        public int idConta { get; set; }
        public TipoConta Tipo { get; set; }
        public SituacaoCriacaoConta SituacaoCriacao { get; set; }
        public SituacaoConta Situacao { get; set; }
        public decimal Saldo { get; set; }

    }
}
