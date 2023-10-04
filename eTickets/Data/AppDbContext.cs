using eTickets.Models;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options):base(options) 
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>().HasKey(am => new
            {
                am.ActorId,
                am.MovieId
            });
            modelBuilder.Entity<Actor_Movie>()
                        .HasOne(m => m.Movie)
                        .WithMany(am => am.Actors_Movies)
                        .HasForeignKey(am => am.MovieId);

            modelBuilder.Entity<Actor_Movie>()
                        .HasOne(m => m.Actor)
                        .WithMany(am => am.Actors_Movies)
                        .HasForeignKey(am => am.ActorId);

            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Actor_Movie> Actors_Movies { get;}
        public DbSet<Actor> Actors { get;}
        public DbSet<Movie> Movies { get;}
        public DbSet<Cinema> Cinemas { get;}
        public DbSet<Producer> Producers { get;}

    }
}
