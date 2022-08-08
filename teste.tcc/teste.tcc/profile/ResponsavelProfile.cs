using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data.Dtos.Responsavel;
using teste.tcc.Models;

namespace teste.tcc.profile
{
    public class ResponsavelProfile : Profile
    {
        public ResponsavelProfile()
        {
            CreateMap<CreateResponsavelDto, Responsavel>();
            CreateMap<Responsavel, ReadResponsavelDto>();
        }
    }
}
