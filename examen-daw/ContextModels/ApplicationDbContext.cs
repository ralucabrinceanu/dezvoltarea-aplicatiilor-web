using examen_daw.Models;
using Microsoft.EntityFrameworkCore;

namespace examen_daw.ContextModels
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options) { }

        public DbSet<Film> Filme { get; set; }
        public DbSet<Recenzie> Recenzii { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Film>()
                .HasMany(f => f.Recenzii)
                .WithOne(r => r.Film)
                .HasForeignKey(r => r.FilmId);
        }
    }
}
