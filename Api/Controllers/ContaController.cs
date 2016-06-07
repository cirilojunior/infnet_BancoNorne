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
        public List<Conta> contas = new List<Conta>();

        public ContaController()
        {
            contas.Add(new Conta { idConta = 1, Tipo = Conta.TipoConta.CORRENTE, SituacaoCriacao = Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = Conta.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new Conta { idConta = 2, Tipo = Conta.TipoConta.CORRENTE, SituacaoCriacao = Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = Conta.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new Conta { idConta = 3, Tipo = Conta.TipoConta.CORRENTE, SituacaoCriacao = Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = Conta.SituacaoConta.VIGENTE, Saldo = 0 });
            contas.Add(new Conta { idConta = 4, Tipo = Conta.TipoConta.CORRENTE, SituacaoCriacao = Conta.SituacaoCriacaoConta.PENDENTE_APROVACAO, Situacao = Conta.SituacaoConta.VIGENTE, Saldo = 0 });
        }

        public IEnumerable<Conta> Get()
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

        // POST: api/Default
        public void Post(Conta value)
        {
            if (value != null)
            {
                contas.Add(value);
            }
        }

        public void Put(int id, Conta value)
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
