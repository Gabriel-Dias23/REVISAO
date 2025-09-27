using System.ComponentModel.DataAnnotations;
using System.Globalization;

namespace EstudoProva.Models
{
    public class LivroViewModel
    {

        [Required(ErrorMessage = "O título é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O titulo deve ter no mínimo 2 caracteres e não pode exceder 100 caracteres.")]
        public string Title { get; set; }

        [Required(ErrorMessage = "O autor é obrigatório.")]
        [StringLength(100, MinimumLength = 2, ErrorMessage = "O autor deve ter no mínimo 2 caracteres e não pode exceder 100 caracteres.")]
        public string Autor { get; set; }

        [Required(ErrorMessage = "A data de publicação é obrigatória.")]
        [Range(1, int.MaxValue, ErrorMessage = "O ano de publicação deve ser um número positivo.")]
        public int AnoPublicacao { get; set; }

        [Required(ErrorMessage = "O ISBN é obrigatório.")]
        [StringLength(maximumLength: 13, ErrorMessage = "O isbn deve conter no Máximo 13 caracteres ")]

        public string Isbn { get; set; }


    }
}
