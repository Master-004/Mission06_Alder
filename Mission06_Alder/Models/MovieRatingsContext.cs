using Microsoft.EntityFrameworkCore;

namespace Mission06_Alder.Models
{
    public class MovieRatingsContext : DbContext
    {
        public MovieRatingsContext(DbContextOptions<MovieRatingsContext> options) : base(options)  // Constructor
        { 
        
        }
        public DbSet<Movie> Movies { get; set; }

        // Configure the database model - so MovieID is PK and Auto-increments
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            // Define MovieId as the Primary Key
            modelBuilder.Entity<Movie>()
                .HasKey(m => m.MovieId);

            // Ensure MovieId is Auto-Incremented (Identity Column)
            modelBuilder.Entity<Movie>()
                .Property(m => m.MovieId)
                .ValueGeneratedOnAdd();
        }
    }
}
