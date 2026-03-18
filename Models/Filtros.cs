namespace GerenciamentoFinanceiroCurso.Models
{
    public class Filtros
    {
        public Filtros(string filtrostring)
        {
            FiltroString = filtrostring ?? "todos-todos-todos";
            string[] filtros = FiltroString.Split('-');

            CategoriaId = filtros[0];
            TransacaoId = filtros[1];
            DataOperacao = filtros[2];
        }
        public string FiltroString { get; set; }
        public string CategoriaId { get; set; }
        public string TransacaoId { get; set; }
        public string DataOperacao { get; set; }

        public static Dictionary<string, string> ValoresDataOperacao =>
            new Dictionary<string, string>
        {
            { "passado", "Passado" },
            { "futuro", "Futuro" },
            { "hoje", "Hoje" }
        };

        public bool TemCategoria => CategoriaId != "todos";
        public bool TemTransacao => TransacaoId != "todos";
        public bool TemDataOperacao => DataOperacao != "todos";

        public bool EPassado => DataOperacao.ToLower() == "passado";
        public bool EHoje => DataOperacao.ToLower() == "hoje";
        public bool EFuturo => DataOperacao.ToLower() == "futuro";
    }
}
