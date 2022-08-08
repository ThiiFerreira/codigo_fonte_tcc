using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data;
using teste.tcc.data.Dtos.Responsavel;
using teste.tcc.Models;

namespace teste.tcc.services
{
    public class ResponsavelService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public ResponsavelService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadResponsavelDto AdicionaResponsavel(CreateResponsavelDto responsaveldto)
        {
            var responsavel = _mapper.Map<Responsavel>(responsaveldto);
            _context.Responsavel.Add(responsavel);
            _context.SaveChanges();
            return _mapper.Map<ReadResponsavelDto>(responsavel);
        }

        public ReadResponsavelDto RecuperaResponsavelPorId(int id)
        {
            Responsavel responsavel = _context.Responsavel.FirstOrDefault(responsavel => responsavel.Id == id);
            if (responsavel != null)
            {
                return _mapper.Map<ReadResponsavelDto>(responsavel);
            }
            return null;
        }

        public List<ReadResponsavelDto> RecuperaResponsavel()
        {
            List<Responsavel> list = _context.Responsavel.ToList();

            if (list != null)
            {
                return _mapper.Map<List<ReadResponsavelDto>>(list);
            }
            return null;
        }

        public Result AtualizaResponsavel(int id, CreateResponsavelDto responsavelDto)
        {
            Responsavel responsavel = _context.Responsavel.FirstOrDefault(responsavel => responsavel.Id == id);
            if(responsavel == null)
            {
                return Result.Fail("Responsavel não encontrado");
            }

            _mapper.Map(responsavelDto, responsavel);
            _context.SaveChanges();
            return Result.Ok();          
         
        }

        public Result DeletaResponsavel(int id)
        {
            Responsavel responsavel = _context.Responsavel.FirstOrDefault(responsavel => responsavel.Id == id);
            if(responsavel == null)
            {
                return Result.Fail("Responsavel não encontrado");
            }

            _context.Responsavel.Remove(responsavel);
            _context.SaveChanges();
            return Result.Ok();
        }
    }
}
