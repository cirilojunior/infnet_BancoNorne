using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Domain.Produtos;
using Domain.Usuarios;

namespace Domain.Produtos
{
    class ContaService
    {

        private ContaRepository contaRepository;

        public ContaService(ContaRepository contaRepository)
        {
            this.contaRepository = contaRepository;
        }

        public Conta Abrir(Conta.TipoConta tipo, Pessoa pessoa)
        {
            Conta novaConta = new Conta();
            contaRepository.salvar(novaConta);
            return novaConta;
        }

        public AdesaoProduto Aprovar(Produto produto, Cliente cliente)
        {
            Conta conta = contaRepository.recuperar(cliente);
            conta.SituacaoCriacao = Conta.SituacaoCriacaoConta.APROVADA;
            contaRepository.salvar(conta);
            AdesaoProduto adesao = new AdesaoProduto();
            return adesao;
        }

        public void Reprovar(Produto produto, Cliente cliente)
        {
            Conta conta = contaRepository.recuperar(cliente);
            conta.SituacaoCriacao = Conta.SituacaoCriacaoConta.REPROVADA;
            contaRepository.salvar(conta);
        }
    }
}
