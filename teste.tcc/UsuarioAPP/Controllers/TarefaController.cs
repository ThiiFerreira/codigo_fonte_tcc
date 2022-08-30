using FluentResults;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Claims;
using System.Threading.Tasks;
using UsuariosApi.Data.Dtos.Tarefa;
using UsuariosApi.Services;

namespace UsuariosApi.Controllers
{
    [ApiController]
    [Route("{controller}")]
    public class TarefaController : ControllerBase
    {
        private TarefaService _tarefaService;
        private TarefaServiceArray  _tarefaServiceArray;
        public TarefaController(TarefaService tarefaService, TarefaServiceArray tarefaServiceArray)
        {
            _tarefaService = tarefaService;
            _tarefaServiceArray = tarefaServiceArray;
        }

        [HttpPost]
        [Authorize(Roles = "responsavel")]
        public IActionResult AdicionaTarefa([FromBody] CreateTarefaDto createTarefaDto)
        {
            ReadTarefaDto readTarefaDto = _tarefaService.AdicionaTarefa(createTarefaDto);
            return CreatedAtAction(nameof(RecuperaTarefaPorId), new { id = readTarefaDto.Id }, readTarefaDto);
        }

        [HttpGet("{id}")]
        [Authorize(Roles = "responsavel, idoso")]
        public IActionResult RecuperaTarefaPorId(int id)
        {
            //var tarefa = _tarefaServiceArray.RecuperaTarefaPorId(id);
            var tarefa = _tarefaService.RecuperaTarefaPorId(id);
            if (tarefa == null) return NotFound("Tarefa não encontrada");
            return Ok(tarefa);
        }

        [HttpGet]
        [Authorize(Roles = "responsavel, idoso")]
        public IActionResult RecuperaTarefa()
        {
            //List<ReadTarefaDto> listTarefa = _tarefaServiceArray.RecuperaTarefa();
            List<ReadTarefaDto> listTarefa = _tarefaService.RecuperaTarefa();
            if (listTarefa == null) return NotFound();
            return Ok(listTarefa);
        }
        [HttpPut("{id}")]
        [Authorize(Roles = "responsavel")]
        public IActionResult AtualizaTarefa(int id, [FromBody] CreateTarefaDto createTarefaDto)
        {
            Result resultado = _tarefaService.AtualizaTarefa(id, createTarefaDto);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "responsavel")]
        public IActionResult DeletaTarefa(int id)
        {
            Result resultado = _tarefaService.DeletaTarefa(id);
            if (resultado.IsFailed) return NotFound();
            return NoContent();
        }
    }
}
