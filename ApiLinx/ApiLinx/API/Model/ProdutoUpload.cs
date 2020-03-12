using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace ApiLinx.API.Model
{
    public class ProdutoUpload
    {
        [Key]

        public int Codigo { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [MaxLength(60, ErrorMessage = "Este campo deve conter entre 10 e 60 caracteres")]
        [MinLength(3, ErrorMessage = "Este campo de conter entre 10 e 60 caracteres")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Este campo é obrigatório")]
        [Range(1, int.MaxValue, ErrorMessage = " O preço deve ser maior que zero")]
        public decimal Valor { get; set; }
    }
}
