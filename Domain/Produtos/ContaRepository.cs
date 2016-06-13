using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.Data.Entity.Core.Objects.DataClasses;

namespace Domain.Produtos
{
    public interface ContaRepository
    {
        List<Conta> listar();
        Conta salvar(Conta conta, bool update);
        Conta recuperar(String codigoConta);
    }

    public class ContaRepositorySQLServer : ContaRepository
    {
        public List<Conta> listar()
        {
            
            var context = new ContaRepositoryDbContext();
            List<Conta> lstc = context.Contas.Include("Cliente").Include("Cliente.Pessoa").ToList();
            return lstc;
        }

        public Conta salvar(Conta conta, bool update)
        {
            var context = new ContaRepositoryDbContext();
            if (conta.codigoConta == null)
            {
                conta.codigoConta = conta.Id.ToString();
            }
            if (update == false)
            {
                context.Contas.Add(conta);
            }
            else
            {
                context.Entry(conta).State = System.Data.Entity.EntityState.Modified;
            }
            context.SaveChanges();
            return conta;
        }

        public Conta recuperar(String codigoConta)
        {
            Conta conta = new Conta();
            var context = new ContaRepositoryDbContext();
            var allLines = context.Contas.Include("Cliente").Include("Cliente.Pessoa").ToList();
            foreach (Conta c in allLines)
            {
                if (c.codigoConta == codigoConta)
                {
                    conta = c;
                }
                break;
            }
            return conta;
        }
    }
}
