using APP.Models;
using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using UsuariosApi.Data;
using UsuariosApi.Data.Dtos.Tarefa;
using UsuariosApi.Helpers;
using UsuariosApi.Models;

namespace UsuariosApi.Services
{
    public class TarefaService
    {
        private UserDbContext _context;
        private IMapper _mapper;
        private int _idUsuario;
        private UsuarioAssistido _assistido;
        private HelpersUsuario _helper = new HelpersUsuario();
        private LoginService _loginService;
        
        public TarefaService(UserDbContext context, IMapper mapper, LoginService loginService)
        {
            _context = context;
            _mapper = mapper;
            _loginService = loginService;
            _idUsuario = _loginService.Retorna();
            _assistido = _context.UsuarioAssistido.FirstOrDefault(assistido => assistido.ResponsavelId == _idUsuario);
        }

        public ReadTarefaDto AdicionaTarefa(CreateTarefaDto createTarefaDto)
        {
            var tarefa = _mapper.Map<Tarefa>(createTarefaDto);
            tarefa.ResponsavelId = _idUsuario;
            tarefa.IdosoId = _assistido.Id;
            _context.Tarefa.Add(tarefa);
            _context.SaveChanges();
            return _mapper.Map<ReadTarefaDto>(tarefa);
        }

        public ReadTarefaDto RecuperaTarefaPorId(int id)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id && (tarefa.IdosoId == _idUsuario || tarefa.ResponsavelId == _idUsuario));
            if (tarefa != null)
            {
                return _mapper.Map<ReadTarefaDto>(tarefa);
            }
            return null;
        }

        public List<ReadTarefaDto> RecuperaTarefa()
        {
            List<Tarefa> list = _context.Tarefa.Where(tarefa => (tarefa.IdosoId == _idUsuario || tarefa.ResponsavelId == _idUsuario)).ToList();

            if (list != null)
            {
                return _mapper.Map<List<ReadTarefaDto>>(list);
            }
            return null;
        }

        public Result AtualizaTarefa(int id, CreateTarefaDto createTarefaDto)
        {
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id && (tarefa.IdosoId == _idUsuario || tarefa.ResponsavelId == _idUsuario));
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
            Tarefa tarefa = _context.Tarefa.FirstOrDefault(tarefa => tarefa.Id == id && (tarefa.IdosoId == _idUsuario || tarefa.ResponsavelId == _idUsuario));
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
