using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace TP02.Models
{
    public class BL
    {
        [Key]
        public int Id { get; set; }

        [Required(ErrorMessage = "O número do BL é obrigatório.")]
        public string Numero { get; set; } = string.Empty;

        [Required(ErrorMessage = "O nome do navio é obrigatório.")]
        public string Navio { get; set; } = string.Empty;

        [Required(ErrorMessage = "O consignee é obrigatório.")]
        public string Consignee { get; set; } = string.Empty;

        // Relacionamento 1:N
        public ICollection<Container> Containers { get; set; } = new List<Container>();
    }
}