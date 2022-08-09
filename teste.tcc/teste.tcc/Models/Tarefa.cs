﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace teste.tcc.Models
{
    public class Tarefa
    {
        [Key]
        [Required]
        public int Id { get; set; }

        [Required]

        public string Descricao { get; set; }

        public string DataInicio { get; set; }

        public string DataFinal { get; set; }

        [Required]

        public PrioridadeTarefa Prioridade { get; set; }

        public StatusTarefa Status { get; set; }

        [Required]
        public int ResponsavelId { get; set; }

        [Required]
        public int IdosoId { get; set; }

    }

}
