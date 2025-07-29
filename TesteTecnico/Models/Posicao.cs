namespace TesteTecnico.Models
{
    public class Posicao
    {
        public int Id { get; set; }
        public int UsuarioId { get; set; }
        public int AtivoId { get; set; }
        public int Quantidade { get; set; }
        public decimal PrecoMedio { get; set; }
        public decimal PEL { get; set; } // P&L (lucro/prejuízo)

        public Usuario Usuario { get; set; }
        public Ativo Ativo { get; set; }
    }
}