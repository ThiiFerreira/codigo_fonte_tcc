using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace teste.tcc.data.Dtos.Idoso
{
    public class CreateIdosoDto
    {

        [Required]
        public string Nome { get; set; }

        [Required]
        public string Cpf { get; set; }

        [Required]
        public string DataNascimento { get; set; }
        public string Telefone { get; set; }

        [Required]
        public string Endereco { get; set; }

        [Required]
        public string DescricaoDeficiencia { get; set; }

        [Required]
        public int ResponsavelId { get; set; }
    }
}
