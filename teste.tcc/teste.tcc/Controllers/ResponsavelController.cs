using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.Models;
using teste.tcc.services;
using FluentResults;
using teste.tcc.data.Dtos.Responsavel;

namespace teste.tcc.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class ResponsavelController : ControllerBase
    {
        private ResponsavelService _responsavelService;

        public ResponsavelController(ResponsavelService service)
        {
            _responsavelService = service;
        }

        [HttpPost]
        public IActionResult AdicionaResponsavel([FromBody] CreateResponsavelDto createResponsavel)
        {
            ReadResponsavelDto readResponsavel = _responsavelService.AdicionaResponsavel(createResponsavel);
            return CreatedAtAction(nameof(RecuperaResponsavelPorId), new { id = readResponsavel.Id }, readResponsavel);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaResponsavelPorId(int id)
        {
            var responsavel = _responsavelService.RecuperaResponsavelPorId(id);
            if (responsavel == null) return NotFound("Responsavel não encontrado");
            return Ok(responsavel);
        }

        [HttpGet]
        public IActionResult RecuperaResponsavel()
        {
            List<ReadResponsavelDto> listResponsavel = _responsavelService.RecuperaResponsavel();
            if (listResponsavel == null) return NotFound();
            return Ok(listResponsavel);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaResponsavel (int id, [FromBody] CreateResponsavelDto createResponsavel)
        {
            Result resultado = _responsavelService.AtualizaResponsavel(id, createResponsavel);
            if(resultado.IsFailed)  return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaResponsavel (int id)
        {
            Result resultado = _responsavelService.DeletaResponsavel(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
