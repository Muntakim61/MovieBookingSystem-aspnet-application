using Microsoft.EntityFrameworkCore;
using MovieBookingSystem.Models;

namespace MovieBookingSystem.Data
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Actor_Movie>()
                .HasKey(am => new { am.ActorId, am.MovieId });

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Movie) // Changed 'm' to 'am'
                .WithMany(m => m.Actors_Movies) // Changed 'am' to 'm'
                .HasForeignKey(am => am.MovieId); // Changed 'm' to 'am'

            modelBuilder.Entity<Actor_Movie>()
                .HasOne(am => am.Actor) // Changed 'm' to 'am'
                .WithMany(a => a.Actors_Movies) // Changed 'am' to 'a'
                .HasForeignKey(am => am.ActorId); // Changed 'm' to 'am'
        }

        public DbSet<Actor> Actors { get; set; }

        public DbSet<Cinema> Cinemas { get; set; }

        public DbSet<Movie> Movies { get; set; }

        public DbSet<Producer> Producers { get; set; }

        public DbSet<Actor_Movie> Actors_Movies { get; set; }
    }
}
