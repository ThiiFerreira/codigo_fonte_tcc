using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace teste.tcc.data.Dtos.Responsavel
{
    public class ReadResponsavelDto
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
        public string email { get; set; }
    }
}
