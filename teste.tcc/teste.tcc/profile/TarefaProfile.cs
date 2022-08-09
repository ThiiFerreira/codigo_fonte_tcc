using AutoMapper;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using teste.tcc.data.Dtos.Tarefa;
using teste.tcc.Models;

namespace teste.tcc.profile
{
    public class TarefaProfile : Profile
    {
        public TarefaProfile()
        {
            CreateMap<CreateTarefaDto, Tarefa>();
            CreateMap<Tarefa, ReadTarefaDto>();
        }
    }
}
