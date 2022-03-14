using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace PmwebProjeto.Models
{
    public class Hotel
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        [MinLength(18)]
        [MaxLength(18)]
        public string Cnpj { get; set; }

        [Required]
        [StringLength(200)]
        public string Endereco { get; set; }

        [Required]
        [StringLength(200)]
        public string Descricao { get; set; }

        public String ImagensUrl { get; set; }
        public List<Quarto> Quartos { get; set; }
    }
}
