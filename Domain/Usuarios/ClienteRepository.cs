using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public interface ClienteRepository
    {
        Cliente salvar(Cliente cliente);
        Cliente recuperar(int numero);
        List<Cliente> listar();
    }



    public class ClienteRepositorySQLServer : ClienteRepository
    {
        public List<Cliente> listar()
        {
            var context = new ClienteRepositoryDbContext();
            List<Cliente> lstc = context.Clientes.Include("Pessoa").ToList();
            return lstc;
        }

        public Cliente salvar(Cliente cliente)
        {
            var context = new ClienteRepositoryDbContext();
            context.Clientes.Add(cliente);
            context.SaveChanges();
            return cliente;
        }

        public Cliente recuperar(int numero)
        {
            Pessoa p = new Pessoa();
            Cliente cliente = new Cliente(p);
            var context = new ClienteRepositoryDbContext();
            var allLines = context.Clientes.Include("Pessoa").ToList();
            foreach (Cliente c in allLines)
            {
                if (c.Id == numero)
                {
                    cliente = c;
                }
                break;
            }
            return cliente;
        }


    }
}
