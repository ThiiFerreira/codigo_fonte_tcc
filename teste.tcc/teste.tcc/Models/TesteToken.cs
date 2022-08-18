using Microsoft.AspNetCore.Identity;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace teste.tcc.Models
{
    public class TesteToken
    {
        public string teste()
        {
            

            var chave = new SymmetricSecurityKey(
                Encoding.UTF8.GetBytes("0asdjas09djsa09djasdjsadajsd09asjd09sajcnzxn")
                );

            var credenciais = new SigningCredentials(chave, SecurityAlgorithms.HmacSha256);
            var token = new JwtSecurityToken(
                signingCredentials: credenciais
                );
            token = new JwtSecurityToken("eyJhbGciOiJIUzI1NiIsInR5cCI6IkpXVCJ9.eyJ1c2VybmFtZSI6Impvc2UiLCJpZCI6IjEwMDIyIiwiaHR0cDovL3NjaGVtYXMubWljcm9zb2Z0LmNvbS93cy8yMDA4LzA2L2lkZW50aXR5L2NsYWltcy9yb2xlIjoiaWRvc28iLCJleHAiOjE2NjA2NjM3MjF9.BPCcvXAxmpHQGtqGtPutFOqCLam9aUmYUMUdlheiyJ4",
                signingCredentials: credenciais);
            
            var teste = token.EncodedHeader;
            
            return teste;


        }
    }
}
