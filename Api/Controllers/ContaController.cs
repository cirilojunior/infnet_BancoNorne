using Domain.Produtos;
using Domain.Usuarios;
using Presentation.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Presentation.Controllers
{
    public class ContaController : ApiController
    {
        private ClienteRepository clienteRepository;
        private AdesaoProdutoRepository adesaoRepository;
        private ContaRepository contaRepository;

        public ContaController()
        {
            clienteRepository = new ClienteRepositoryMYSQL();
            adesaoRepository = new AdesaoProdutoRepositoryMYSQL();
            contaRepository = new ContaRepositoryMYSQL();

            //contas.Add(new ContaBinding { codigoConta = "32123", Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 0 });
            //contas.Add(new ContaBinding { codigoConta = "213123", Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 23 });
            //contas.Add(new ContaBinding { codigoConta = "123123", Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 213 });
            //contas.Add(new ContaBinding { codigoConta = "213123", Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 42 });
        }

        public IEnumerable<ContaBinding> Get()
        {
            List<ContaBinding> cbs = new List<ContaBinding>();
            List<Conta> contas = contaRepository.listar();

            if (contas != null && contas.Count > 0)
            {
                ContaBinding cb = null;
                foreach (Conta c in contas)
                {
                    cb = new ContaBinding(c);
                    cbs.Add(cb);
                }
            }
            
            return cbs;
        }

        public void Post(ContaBinding value)
        {
            if (value != null)
            {
                PessoaFisica pessoa = value.toPessoa();
                ContaService service = new ContaService(contaRepository, clienteRepository, adesaoRepository);
                service.Abrir(value.toConta().Tipo, pessoa);
            }
        }

        public void Put(int id, ContaBinding value)
        {
            if (id > 0 && value != null)
            {
                ContaService service = new ContaService(contaRepository, clienteRepository, adesaoRepository);
                service.Aprovar(value.codigoConta);
            }
        }

        public void Delete(int id)
        {
        }
    }
}
