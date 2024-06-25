using System.ComponentModel.DataAnnotations;

namespace KieTec.Models
{
    public class Produto
    {
        public int Id { get; set; }

        public string Nome { get; set; }

        [Display(Name = "Descrição")]
        public string Descricao { get; set; }

        [Display(Name = "Preço")]
        public decimal Preco { get; set; }

        [Display(Name = "Data de Criação")]
        public DateTime DataDeCriacao { get; set; }
        public int? FornecedorId { get; set; }
        public Fornecedor? Fornecedor { get; set; }
    }
}
