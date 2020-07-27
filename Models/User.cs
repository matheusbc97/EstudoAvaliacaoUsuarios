using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace AvaliacaoUsuarios.Models
{
    [Table("Users")]
    public class User
    {
        public int Id { get; set; }
        [Required(ErrorMessage = "O nome deve ser preenchido.")]
        public string Email { get; set; }
        [Required(ErrorMessage = "O nome deve ser preenchido.")]
        [MaxLength(100, ErrorMessage = "O nome de curso só pode conter até 100 caracteres")]
        public string Name { get; set; }
        public string Description { get; set; }
        public bool? Avaliation { get; set; }
        public DateTime CreatedAt { get; set; }
    }
}