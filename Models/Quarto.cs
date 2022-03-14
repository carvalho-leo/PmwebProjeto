using System.ComponentModel.DataAnnotations;

namespace PmwebProjeto.Models
{
    public class Quarto
    {
        public int Id { get; set; }

        [Required]
        [StringLength(100)]
        public string Nome { get; set; }

        [Required]
        public int NumeroOcupantes { get; set; }

        [Required]
        public int NumeroAdultos { get; set; }

        [Required]
        public int NumeroCriancas { get; set; }

        [Required]
        public decimal Preco { get; set; }

        public int HotelId { get; set; }
        public virtual Hotel Hotel { get; set; }
    }
}
