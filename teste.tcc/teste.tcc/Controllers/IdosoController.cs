using FluentResults;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data.Dtos.Idoso;
using teste.tcc.services;

namespace teste.tcc.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class IdosoController : ControllerBase
    {
        private IdosoService _idosoService;
        public IdosoController(IdosoService idosoService)
        {
            _idosoService = idosoService;
        }

        [HttpPost]
        public IActionResult AdicionaIdoso ([FromBody] CreateIdosoDto createIdosoDto)
        {
            ReadIdosoDto readIdosoDto = _idosoService.AdicionaIdoso(createIdosoDto);
            return CreatedAtAction(nameof(RecuperaIdosoPorId), new { id = readIdosoDto.Id}, readIdosoDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaIdosoPorId(int id)
        {
            var idoso = _idosoService.RecuperaIdosoPorId(id);
            if (idoso == null) return NotFound("Idoso não encontrado");
            return Ok(idoso);
        }

        [HttpGet]
        public IActionResult RecuperaIdoso()
        {
            List<ReadIdosoDto> listIdoso = _idosoService.RecuperaIdoso();
            if (listIdoso == null) return NotFound();
            return Ok(listIdoso);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaIdoso(int id, [FromBody] CreateIdosoDto createIdoso)
        {
            Result resultado = _idosoService.AtualizaIdoso(id, createIdoso);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaResponsavel(int id)
        {
            Result resultado = _idosoService.DeletaIdoso(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }


    }
}
