using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Domíno.ModelViews
{
    public struct Home
    {
        public string Doc { get => "/swagger"; }

        public string Mensagem { get => "Bem vindo a API de veículos - Minimal API"; }
    }
}