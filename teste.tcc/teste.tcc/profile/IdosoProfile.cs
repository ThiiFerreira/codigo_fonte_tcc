using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data.Dtos.Idoso;
using teste.tcc.Models;

namespace teste.tcc.profile
{
    public class IdosoProfile : Profile
    {
        public IdosoProfile()
        {
            CreateMap<CreateIdosoDto, Idoso>();
            CreateMap<Idoso, ReadIdosoDto>();
        }
    }
}
