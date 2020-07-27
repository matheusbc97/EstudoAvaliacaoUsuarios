
using System;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace AvaliacaoUsuarios.Models
{
    [Table("Avaliations")]
    public class Avaliation
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "A descrição deve ser preenchida.")]
        public string Description { get; set; }
        [Required(ErrorMessage = "A avaliação deve ter um valor")]
        public bool Value { get; set; }
        public DateTime CreatedAt { get; set; }
        [Required(ErrorMessage = "O user id precisa ser preenchido")]
        public int UserId { get; set; }
        [Required(ErrorMessage = "O avaliator id precisa ser preenchido")]
        public int AvaliatorId { get; set; }
    }
}