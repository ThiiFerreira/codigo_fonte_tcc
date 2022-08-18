using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi.Helpers
{
    public class HelpersUsuario
    {
        public int RetornarIdUsuario (string token)
        {
            int tam = token.Length - 5;
            int id = int.Parse(token.Substring(tam, 5));
            return id;
        }
    }
}
