namespace TesteTecnico.Models
{
    public class Ativo
    {
        public int Id { get; set; }
        public string Codigo { get; set; }
        public string NomeAtivo { get; set; }

        public ICollection<Operacao> Operacoes { get; set; }
        public ICollection<Posicao> Posicoes { get; set; }
        public ICollection<Cotacao> Cotacoes { get; set; }
    }
}