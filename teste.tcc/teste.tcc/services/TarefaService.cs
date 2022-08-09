using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data;
using teste.tcc.data.Dtos.Tarefa;
using teste.tcc.Models;

namespace teste.tcc.services
{
    public class TarefaService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public TarefaService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadTarefaDto AdicionaTarefa(CreateTarefaDto createTarefaDto)
        {
            var tarefa = _mapper.Map<Tarefa>(createTarefaDto);
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
            return _mapper.Map<ReadTarefaDto>(tarefa);
        }

        public ReadTarefaDto RecuperaTarefaPorId(int id)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id);
            if (tarefa != null)
            {
                return _mapper.Map<ReadTarefaDto>(tarefa);
            }
            return null;
        }

        public List<ReadTarefaDto> RecuperaTarefa()
        {
            List<Tarefa> list = _context.Tarefa.ToList();

            if (list != null)
            {
                return _mapper.Map<List<ReadTarefaDto>>(list);
            }
            return null;
        }

        public Result AtualizaTarefa(int id, CreateTarefaDto createTarefaDto)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id);
            if (tarefa == null)
            {
                return Result.Fail("Tarefa não encontrada");
            }

            _mapper.Map(createTarefaDto, tarefa);
            _context.SaveChanges();
            return Result.Ok();

        }

        public Result DeletaTarefa(int id)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id);
            if (tarefa == null)
            {
                return Result.Fail("Tarefa não encontrado");
            }

            _context.Tarefa.Remove(tarefa);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
