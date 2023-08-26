using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ControleFacil.Api.Contract.Usuario
{
    public class UsuarioLoginResponseContract
    {
        public long Id { get; set; }
        public string Email { get; set; } = string.Empty;
        public string Token { get; set; }  = string.Empty;
    }
}