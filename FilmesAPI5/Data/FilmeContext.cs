using FilmesAPI5.Models;
using Microsoft.EntityFrameworkCore;

namespace FilmesAPI5.Data
{
    public class FilmeContext : DbContext
    {
        public FilmeContext(DbContextOptions<FilmeContext> opt) : base(opt)
        {
            
        }

        public DbSet<Filme> Filmes { get; set; }
    }
}
