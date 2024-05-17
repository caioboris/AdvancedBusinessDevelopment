using Microsoft.EntityFrameworkCore;

namespace AgroPlus.Models
{
    public class Contexto: DbContext
    {
        public Contexto(DbContextOptions<Contexto> options): base(options) { }

        public DbSet<Cliente> Cliente { get; set;}
        public DbSet<HistoricoVenda> HistoricoVenda { get; set;}
        public DbSet<InfoRegiao> InfoRegiao { get; set;}
        public DbSet<Regiao> Regiao { get; set;}
        public DbSet<TipoCultivo> TipoCultivo { get; set;}
        public DbSet<Usuario> Usuario { get; set;}
        public DbSet<Vendedor> Vendedor { get; set;}

    }
}
