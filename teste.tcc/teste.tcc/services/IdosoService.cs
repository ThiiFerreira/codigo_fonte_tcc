using AutoMapper;
using FluentResults;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data;
using teste.tcc.data.Dtos.Idoso;
using teste.tcc.Models;

namespace teste.tcc.services
{
    public class IdosoService
    {
        private AppDbContext _context;
        private IMapper _mapper;

        public IdosoService(AppDbContext context, IMapper mapper)
        {
            _context = context;
            _mapper = mapper;
        }

        public ReadIdosoDto AdicionaIdoso(CreateIdosoDto createIdosoDto)
        {
            var idoso = _mapper.Map<Idoso>(createIdosoDto);
            _context.Idoso.Add(idoso);
            _context.SaveChanges();
            return _mapper.Map<ReadIdosoDto>(idoso);
        }

        public ReadIdosoDto RecuperaIdosoPorId(int id)
        {
            var idoso = _context.Idoso.FirstOrDefault(idoso => idoso.Id == id);
            if(idoso != null)
            {
                return _mapper.Map<ReadIdosoDto>(idoso);
            }
            return null;
        }

        public List<ReadIdosoDto> RecuperaIdoso()
        {
            List<Idoso> list = _context.Idoso.ToList();
            if(list != null)
            {
                return _mapper.Map<List<ReadIdosoDto>>(list);
            }
            return null;
        }

        public Result AtualizaIdoso(int id, CreateIdosoDto IdosoDto)
        {
            Idoso idoso = _context.Idoso.FirstOrDefault(idoso => idoso.Id == id);
            if (idoso == null)
            {
                return Result.Fail("Idoso não encontrado");
            }

            _mapper.Map(IdosoDto, idoso);
            _context.SaveChanges();
            return Result.Ok();

        }

        public Result DeletaIdoso(int id)
        {
            Idoso idoso = _context.Idoso.FirstOrDefault(idoso => idoso.Id == id);
            if (idoso == null)
            {
                return Result.Fail("Idoso não encontrado");
            }

            _context.Idoso.Remove(idoso);
            _context.SaveChanges();
            return Result.Ok();
        }


    }
}
