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
    }

    public class ClienteRepositoryMYSQL : ClienteRepository
    {
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
            var allLines = context.Clientes.ToList();
            foreach (Cliente c in allLines)
            {
                if (c.Numero == numero)
                {
                    cliente = c;
                }
                break;
            }
            return cliente;
        }


    }
}
