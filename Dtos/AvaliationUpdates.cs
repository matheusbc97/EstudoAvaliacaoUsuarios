using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace AvaliacaoUsuarios.Dtos
{
    public class AvaliationUpdates
    {
        [Required(ErrorMessage = "É necessário passar o Id no corpo da requisição")]
        public int Id { get; set; }
        public string Description { get; set; }
        [Required(ErrorMessage = "A avaliação deve ter um valor")]
        public bool Value { get; set; }
    }
}