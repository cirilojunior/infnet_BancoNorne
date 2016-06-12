using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    public interface ContaRepository
    {
        List<Conta> listar();
        Conta salvar(Conta conta);
        Conta recuperar(String codigoConta);
    }

    public class ContaRepositoryMYSQL : ContaRepository
    {
        public List<Conta> listar()
        {
            var context = new ContaRepositoryDbContext();
            List<Conta> lstc = context.Contas.ToList();
            return lstc;
        }

        public Conta salvar(Conta conta)
        {
            var context = new ContaRepositoryDbContext();
            context.Contas.Add(conta);
            context.SaveChanges();
            return conta;
        }

        public Conta recuperar(String codigoConta)
        {
            Conta conta = new Conta();
            var context = new ContaRepositoryDbContext();
            var allLines = context.Contas.ToList();
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
