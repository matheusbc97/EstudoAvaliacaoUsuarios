using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AvaliacaoUsuarios.Models
{
    public class UserUpdates
    {
        [Required(ErrorMessage = "É necessário passar o Id no corpo da requisição")]
        public int Id { get; set; }
        public string Email { get; set; }
        [MaxLength(100, ErrorMessage = "O nome de curso só pode conter até 100 caracteres")]
        public string Name { get; set; }
        public string Description { get; set; }
        [Range(0, 5, ErrorMessage = "A carga horária deve ser pelo menos 0 e no máximo 5")]
        public bool? Avaliation { get; set; }
    }
}