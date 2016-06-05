﻿using Domain.Usuarios;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Domain.Produtos
{
    interface ContaRepository
    {
        List<Conta> listar();
        Conta salvar(Conta conta);
        Conta recuperar(Cliente cliente);
    }
}