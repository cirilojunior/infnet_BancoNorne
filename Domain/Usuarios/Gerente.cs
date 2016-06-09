using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Usuarios
{
    public class Gerente : Funcionario
    {
        private List<Funcionario> subordinados;

        public List<Funcionario> Subordinados
        {
            get { return subordinados; }
            set { subordinados = value; }
        }

    }
}
