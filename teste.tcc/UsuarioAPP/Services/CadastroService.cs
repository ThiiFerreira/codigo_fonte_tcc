using AutoMapper;
using FluentResults;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using MySql.Data.MySqlClient;
using System;
using System.Linq;
using System.Threading.Tasks;
using System.Web;
using UsuarioAPP.Services;
using UsuariosApi.Data;
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
        private UserDbContext _usuarioService;

        public CadastroService(IMapper mapper,
            UserManager<IdentityUser<int>> userManager, RoleManager<IdentityRole<int>> roleManager, BdAppTcc bdAppTcc, UserDbContext usuarioService)
        {
            _mapper = mapper;
            _userManager = userManager;
            _roleManager = roleManager;
            _bdAppTcc = bdAppTcc;
            _usuarioService = usuarioService;
        }

        public Result CadastraUsuario(CreateUsuarioDto createDto)
        {
         
            Usuario usuario = _mapper.Map<Usuario>(createDto);
            Task<IdentityResult> resultadoIdentity;

            try
            {              
                var username = _usuarioService.Usuario.FirstOrDefault(usuario => usuario.Username == createDto.Username);
                if (username != null) return Result.Fail("Falha ao cadastra usuario: Username já existe");
                var email = _usuarioService.Usuario.FirstOrDefault(usuario => usuario.Email == createDto.Email);
                if (email != null) return Result.Fail("Falha ao cadastra usuario: Email já existe");
                var cpf = _usuarioService.Usuario.FirstOrDefault(usuario => usuario.Cpf == createDto.Cpf);
                if (cpf != null) return Result.Fail("Falha ao cadastra usuario: CPF já existe"); 

                IdentityUser<int> usuarioIdentity = _mapper.Map<IdentityUser<int>>(usuario);
                resultadoIdentity = _userManager
                    .CreateAsync(usuarioIdentity, createDto.Password);
                _userManager.AddToRoleAsync(usuarioIdentity, "responsavel");
                
                if (resultadoIdentity.Result.Succeeded)
                {  
                    var code = _userManager
                        .GenerateEmailConfirmationTokenAsync(usuarioIdentity).Result;

                    usuario.Id = usuarioIdentity.Id;
                    _usuarioService.Usuario.Add(usuario);
                    _usuarioService.SaveChanges();

                    return Result.Ok().WithSuccess(code);
                }
            }catch (Exception e)
            {
                return Result.Fail(e.Message);
            }

            return Result.Fail("Falha ao cadastrar usuário " + resultadoIdentity.Result.ToString());

        }

    }
}
