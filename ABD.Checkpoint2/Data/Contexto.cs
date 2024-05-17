using ABD.Checkpoint2.Models;
using Microsoft.EntityFrameworkCore;

namespace ABD.Checkpoint2.Data;

public class Contexto : DbContext
{
    public Contexto(DbContextOptions<Contexto> options) : base(options) { }

    public DbSet<Musica> Musicas { get; set; }
    public DbSet<Artista> Artistas { get; set; }

}
