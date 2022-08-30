﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace UsuariosApi.Data.Dtos.Tarefa
{
    public class ReadTarefaDto
    {
        public int Id { get; set; }

        public string Descricao { get; set; }

        public string DataInicio { get; set; }

        public string DataFinal { get; set; }

        public int ResponsavelId { get; set; }

        public int IdosoId { get; set; }
    }
}
