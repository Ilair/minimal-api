using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domíno.Entidades;
using minimal_api.DTOs;

namespace minimal_api.Domíno.Interfaces
{
    public interface IAdministradorServico
    {
        Administrador Login(LoginDTO loginDTO);
    }
}