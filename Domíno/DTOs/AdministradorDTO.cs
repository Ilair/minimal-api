using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using minimal_api.Domíno.Enums;

namespace minimal_api.Domíno.DTOs
{
    public class AdministradorDTO
    {
        public string Email {get; set;} = default!;
        public string Senha {get; set;} = default!;
        public Perfil? Perfil {get; set;} = default!;
    }
}