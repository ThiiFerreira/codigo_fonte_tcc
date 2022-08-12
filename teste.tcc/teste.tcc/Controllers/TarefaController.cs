using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data.Dtos.Tarefa;
using teste.tcc.services;

namespace teste.tcc.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class TarefaController : ControllerBase
    {
        private TarefaService _tarefaService;
        public TarefaController(TarefaService tarefaService)
        {
            _tarefaService = tarefaService;
        }

        [HttpPost]
        [Authorize(Roles = "admin")]
        public IActionResult AdicionaTarefa([FromBody] CreateTarefaDto createTarefaDto)
        {
            ReadTarefaDto readTarefaDto = _tarefaService.AdicionaTarefa(createTarefaDto);
            return CreatedAtAction(nameof(RecuperaTarefaPorId), new { id = readTarefaDto.Id }, readTarefaDto);
        }

        [HttpGet("{id}")]
        public IActionResult RecuperaTarefaPorId(int id)
        {
            var tarefa = _tarefaService.RecuperaTarefaPorId(id);
            if (tarefa == null) return NotFound("Tarefa não encontrada");
            return Ok(tarefa);
        }

        [HttpGet]
        public IActionResult RecuperaTarefa()
        {
            List<ReadTarefaDto> listTarefa = _tarefaService.RecuperaTarefa();
            if (listTarefa == null) return NotFound();
            return Ok(listTarefa);
        }

        [HttpPut("{id}")]
        public IActionResult AtualizaTarefa(int id, [FromBody] CreateTarefaDto createTarefaDto)
        {
            Result resultado = _tarefaService.AtualizaTarefa(id, createTarefaDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        public IActionResult DeletaTarefa(int id)
        {
            Result resultado = _tarefaService.DeletaTarefa(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
