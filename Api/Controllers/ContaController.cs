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
        public List<ContaBinding> contas = new List<ContaBinding>();

        public ContaController()
        {
            contas.Add(new ContaBinding { idConta = 1, Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new ContaBinding { idConta = 2, Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new ContaBinding { idConta = 3, Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new ContaBinding { idConta = 4, Tipo = ContaBinding.TipoConta.CORRENTE, SituacaoCriacao = ContaBinding.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = ContaBinding.SituacaoConta.VIGENTE, Saldo = 0 });
        }

        public IEnumerable<ContaBinding> Get()
        {
            return contas;
        }


        public IHttpActionResult Get(int id)
        {
            var conta = contas.FirstOrDefault((p) => p.idConta == id);
            if (conta == null)
            {
                return NotFound();
            }
            return Ok(conta);
        }

        public void Post(ContaBinding value)
        {
            if (value != null)
            {
                contas.Add(value);
            }
        }

        public void Put(int id, ContaBinding value)
        {
            if (id > 0 && value != null)
            {
                contas.Add(value);
            }
        }

        public void Delete(int id)
        {
        }
    }
}
