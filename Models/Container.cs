using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace TP02.Models
{
    public class Container
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do container é obrigatório.")]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "O tipo do container é obrigatório.")]
        public string Tipo { get; set; } = string.Empty;

        [Required(ErrorMessage = "O tamanho é obrigatório.")]
        public int Tamanho { get; set; }

        // Chave Estrangeira (FK)
        public int BL_ID { get; set; }

        [ForeignKey("BL_ID")]
        public BL? BL { get; set; }
    }
}