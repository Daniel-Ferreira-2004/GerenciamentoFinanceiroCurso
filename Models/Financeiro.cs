using Microsoft.AspNetCore.Mvc.ModelBinding.Validation;
using System.ComponentModel.DataAnnotations;

namespace GerenciamentoFinanceiroCurso.Models
{
    public class Financeiro
    {
        public int Id { get; set; }
        [Required(ErrorMessage ="Descrição não foi preenchido.")]
        public string Descricao { get; set; }
        [Required(ErrorMessage = "Valor não foi preenchido.")]
        public double Valor { get; set; }
        [Required(ErrorMessage = "Data de Operação não foi preenchido.")]
        public DateTime DataDaOperacao { get; set; }
        public string CategoriaId { get; set; }
        [ValidateNever]
        public Categoria Categoria { get; set; }
        public string TransacaoId { get; set; }
        [ValidateNever]
        public Transacao Transacao { get; set; }
    }
}
