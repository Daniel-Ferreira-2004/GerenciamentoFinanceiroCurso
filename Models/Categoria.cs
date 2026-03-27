using System.ComponentModel.DataAnnotations;

namespace GerenciamentoFinanceiroCurso.Models
{
    public class Categoria
    {
        public string CategoriaId { get; set; }
        [Required(ErrorMessage="Categoria não Preenchida")]
        public string Nome { get; set; }
    }
}
