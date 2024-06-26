using System.ComponentModel.DataAnnotations;

namespace KieTec.Models
{
    public class Fornecedor
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public string Nome { get; set; }

        [Required(ErrorMessage = "Campo obrigatório")]
        public int Telefone { get; set; }
    }
}
