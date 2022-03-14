using Microsoft.EntityFrameworkCore;
using PmwebProjeto.Models;

namespace PmwebProjeto.Context
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }

        public DbSet<Hotel> Hoteis { get; set; }
        public DbSet<Quarto> Quartos { get; set; }
    }
}
