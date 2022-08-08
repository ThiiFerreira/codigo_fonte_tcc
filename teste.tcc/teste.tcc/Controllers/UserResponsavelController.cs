using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.Models;
using teste.tcc.services;

namespace teste.tcc.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class UserResponsavelController : ControllerBase
    {
        private UserResponsavelService _userService;

        public UserResponsavelController(UserResponsavelService userService)
        {
            _userService = userService;
        }

        [HttpPost]
        public IActionResult AdicionaResponsavel([FromBody] UserResponsavel user)
        {
            _userService.AdicionaResponsavel(user);
            return CreatedAtAction(nameof(RecuperarUserPorLogin), new { login = user.login }, user);
        }

        [HttpGet("{login}")]
        public IActionResult RecuperarUserPorLogin(string login)
        {
            var user = _userService.RecuperaUserPorLogin(login);
            if (user == null) return NotFound("Usuario não encontrado");
            return Ok(user);
        }
    }
}
