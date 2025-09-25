using System.ComponentModel.DataAnnotations;

namespace ExercrioProvaAnoPassado.Model
{
    /// <summary>
    /// Representa uma carta escrita por uma criança.
    /// </summary>
    public class Carta
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "O nome da criança é obrigatório.")]
        [StringLength(255, MinimumLength = 3, ErrorMessage = "O nome deve ter entre 3 e 255 caracteres.")]
        public string NomeCrianca { get; set; }

        [Required(ErrorMessage = "O endereço é obrigatório.")]

        public Endereco Endereco { get; set; } = new Endereco();

        [Range(1, 14, ErrorMessage = "A idade deve estar entre 1 e 14 anos.")]
        public int Idade { get; set; }

        [StringLength(500, MinimumLength = 10, ErrorMessage = "A mensagem deve ter entre 10 e 500 caracteres.")]
        public string Mensagem { get; set; }

        /// <summary>
        /// Retorna uma representação textual da carta.
        /// </summary>
        public override string ToString()
        {
            return $"{NomeCrianca} ({Idade} anos) - {Endereco?.Cidade}, {Endereco?.Estado}";
        }
    }
}