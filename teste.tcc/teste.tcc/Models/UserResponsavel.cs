using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace teste.tcc.Models
{
    public class UserResponsavel
    {
        [Key]
        [Required]
        public string login { get; set; }

        [Required]
        public string senha { get; set; }
        public int ResponsavelId { get; set; }

    }
}
