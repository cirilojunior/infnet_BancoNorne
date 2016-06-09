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
}
