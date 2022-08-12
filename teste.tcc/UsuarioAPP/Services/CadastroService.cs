using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UsuarioAPP.Services;
using UsuariosApi.Data.Dtos.Usuario;
using UsuariosApi.Data.Requests;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class CadastroService
    {

        private IMapper _mapper;
        private UserManager<IdentityUser<int>> _userManager;
        private RoleManager<IdentityRole<int>> _roleManager;
        private BdAppTcc _bdAppTcc;

        public CadastroService(IMapper mapper,
            UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager, BdAppTcc bdAppTcc)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _bdAppTcc = bdAppTcc;
        }

        public Result CadastraUsuario(CreateUsuarioDto createDto)
        {

            //var resultado = _bdAppTcc.verificaResposnavel(createDto.ResonsavelId);
            //if(!resultado) return Result.Fail("Falha ao cadastrar usuário, responsavel não existe");

            Usuario usuario = _mapper.Map<Usuario>(createDto);
            IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
            Task<IdentityResult> resultadoIdentity = _userManager
                .CreateAsync(usuarioIdentity, createDto.Password);
            _userManager.AddToRoleAsync(usuarioIdentity, "regular");
            //var createRoleResult = _roleManager
            //    .CreateAsync(new IdentityRole<int>("admin")).Result;
            //var usuarioRoleResult = _userManager
            //    .AddToRoleAsync(usuarioIdentity, "admin").Result;
            
            if (resultadoIdentity.Result.Succeeded)
            {
                var code = _userManager
                    .GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;

                return Result.Ok().WithSuccess(code);
            }
            return Result.Fail("Falha ao cadastrar usuário");

        }

    }
}
