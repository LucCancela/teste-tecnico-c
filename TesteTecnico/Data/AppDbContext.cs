using Microsoft.EntityFrameworkCore;
using TesteTecnico.Models;

namespace TesteTecnico.Data
{
    public class AppDbContext : DbContext
    {
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Ativo> Ativos { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        public DbSet<Cotacao> Cotacoes { get; set; }
        public DbSet<Posicao> Posicoes { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseMySql("server=localhost;database=teste_tecnico;user=root;password=#Gf518",
            new MySqlServerVersion(new Version(8, 0, 21)));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Ativo>()
                .HasIndex(a => a.Codigo)
                .IsUnique();

            // Relacionamentos
            modelBuilder.Entity<Operacao>()
                .HasOne(o => o.Usuario)
                .WithMany(u => u.Operacoes)
                .HasForeignKey(o => o.UsuarioId);

            modelBuilder.Entity<Operacao>()
                .HasOne(o => o.Ativo)
                .WithMany(a => a.Operacoes)
                .HasForeignKey(o => o.AtivoId);

            modelBuilder.Entity<Posicao>()
                .HasOne(p => p.Usuario)
                .WithMany(u => u.Posicoes)
                .HasForeignKey(p => p.UsuarioId);

            modelBuilder.Entity<Posicao>()
                .HasOne(p => p.Ativo)
                .WithMany(a => a.Posicoes)
                .HasForeignKey(p => p.AtivoId);

            modelBuilder.Entity<Cotacao>()
                .HasOne(c => c.Ativo)
                .WithMany(a => a.Cotacoes)
                .HasForeignKey(c => c.AtivoId);
        }

    }
}