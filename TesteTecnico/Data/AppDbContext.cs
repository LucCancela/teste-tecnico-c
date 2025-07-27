using Microsoft.EntityFrameworkCore;
using TesteTecnico.Models;

namespace TesteTecnico.Data;
{
    public class AppDbContext : DbContext
{
    public AppDbContext(DbContextOptions<AppDbContext> options)
        : base(options)
    {

    }
        public DbSet<Usuario> Usuarios { get; set; }
        public DbSet<Operacao> Operacoes { get; set; }
        
    }
}