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
            List<Cliente> lstc = context.Clientes.ToList();
            return lstc;
        }

        public Cliente salvar(Cliente cliente)
        {
            var context = new ClienteRepositoryDbContext();

            /*
            cliente.Pessoa.Contato = new Contatos.Contato();
            cliente.Pessoa.Contato.Email = "jose@com.com";
            cliente.Pessoa.Contato.TelefoneAlternativo = "1111-2222";
            cliente.Pessoa.Contato.TelefonePrincipal = "3333-4444";
            cliente.Pessoa.Endereco = new Contatos.Endereco();
            cliente.Pessoa.Endereco.Cep = "22211-200";
            cliente.Pessoa.Endereco.Cidade = "Rio de Janeiro";
            cliente.Pessoa.Endereco.Complemento = "Apt. 802";
            cliente.Pessoa.Endereco.Estado = Contatos.Endereco.UF.RJ;
            cliente.Pessoa.Endereco.Logradouro = "Rua Pedro Américo";
            cliente.Pessoa.Endereco.Numero = "205";
            ((PessoaFisica)(cliente.Pessoa)).Identidade = "08740185-7";
            ((PessoaFisica)(cliente.Pessoa)).rendaMensal = 10000.0;
            */

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
