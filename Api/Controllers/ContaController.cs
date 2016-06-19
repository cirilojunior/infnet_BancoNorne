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
            clienteRepository = new ClienteRepositorySQLServer();
            adesaoRepository = new AdesaoProdutoRepositorySQLServer();
            contaRepository = new ContaRepositorySQLServer();
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
                Gerente gerente = new Gerente();
                gerente.Nome = "Rodrigo Matos";
                gerente.Matricula = "999666";
                ContaService service = new ContaService(contaRepository, clienteRepository, adesaoRepository);
                service.Aprovar(value.codigoConta, gerente);
            }
        }

        public void Delete(int id)
        {
        }
    }
}
