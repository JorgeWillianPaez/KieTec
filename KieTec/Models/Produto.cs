using System.ComponentModel.DataAnnotations;

namespace KieTec.Models
{
    public class Produto
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        [Display(Name = "Data de Criação")]
        public DateTime DataDeCriacao { get; set; }

        [Display(Name = "Fornecedor")]
        public int? FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
