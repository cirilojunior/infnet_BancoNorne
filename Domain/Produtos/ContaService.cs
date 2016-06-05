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
        private ClienteRepository clienteRepository;
        private AdesaoProdutoRepository adesaoProdutoRepository;

        public ContaService(ContaRepository contaRepository,
                            ClienteRepository clienteRepository,
                            AdesaoProdutoRepository adesaoProdutoRepository)
        {
            this.contaRepository = contaRepository;
            this.clienteRepository = clienteRepository;
            this.adesaoProdutoRepository = adesaoProdutoRepository;
        }

        public Conta Abrir(Conta.TipoConta tipo, Pessoa pessoa)
        {
            Cliente novoCliente = new Cliente(pessoa);
            clienteRepository.salvar(novoCliente);

            Conta novaConta = new Conta();
            novaConta.Tipo = tipo;
            novaConta.SituacaoCriacao = Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO;
            novaConta.Saldo = 0;
            novaConta.Cliente = novoCliente;
            
            return contaRepository.salvar(novaConta);
        }

        public AdesaoProduto Aprovar(Produto produto, Cliente cliente)
        {
            Conta conta = contaRepository.recuperar(cliente);
            conta.SituacaoCriacao = Conta.SituacaoCriacaoConta.APROVADA;
            contaRepository.salvar(conta);
            
            AdesaoProduto adesao = new AdesaoProduto();
            adesao.Produto = produto;
            adesao.Cliente = cliente;
            adesao.Data = DateTime.Today;
            return adesaoProdutoRepository.salvar(adesao);
        }

        public void Reprovar(Produto produto, Cliente cliente)
        {
            Conta conta = contaRepository.recuperar(cliente);
            conta.SituacaoCriacao = Conta.SituacaoCriacaoConta.REPROVADA;
            contaRepository.salvar(conta);
        }
    }
}
