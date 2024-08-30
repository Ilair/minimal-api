using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace minimal_api.Domíno.ModelViews
{
    public class AdministradorLogado
    {
        public int Id {get; set;} = default!;
        public string Email {get; set;} = default!;
        public string Perfil {get; set;} = default!;
        public string Token {get; set;} = default!;
    }
}