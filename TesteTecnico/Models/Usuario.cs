namespace TesteTecnico.Models
{
    public class Usuario
    {
        public int Id { get; set; }
        public string NomeUsuario { get; set; }
        public string Email { get; set; }
        public decimal Corretagem { get; set; }

        public ICollection<Operacao> Operacoes { get; set; }
        public ICollection<Posicao> Posicoes { get; set; }

    }
}
    