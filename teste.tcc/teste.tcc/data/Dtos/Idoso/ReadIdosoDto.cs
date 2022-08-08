using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace teste.tcc.data.Dtos.Idoso
{
    public class ReadIdosoDto
    {
        [Key]
        [Required]
        public int Id { get; set; }

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
        public string descricaoDeficiencia { get; set; }

        [Required]
        public int ResponsavelId { get; set; }
    }
}
