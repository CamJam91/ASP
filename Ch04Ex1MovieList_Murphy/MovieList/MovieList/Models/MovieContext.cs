using Microsoft.EntityFrameworkCore;

namespace MovieList.Models
{
    public class MovieContext : DbContext //inherits DBContext class
    {
            //constructors
                //pass options object to constructor then call base constructor (passing options object)
        public MovieContext(DbContextOptions<MovieContext> options) : base(options) { }

            //Context must work with collections of our Entity class
            //These dbSet properties enable EFCore to generate database tables
        public DbSet<Movie> Movies { get; set; } = null!; //references can't contain nullable values unless you use the ! (null forgiving operator)

            //seed data using hte OnModelCreating method that we overide and pass our data to
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Movie>().HasData(
                new Movie
                {
                    MovieID = 1,
                    name = "Raging Bull",
                    Year = 1980,
                    Rating = 5
                },
                new Movie
                {
                    MovieID = 2,
                    name = "Spawn",
                    Year = 1997,
                    Rating = 3
                },
                new Movie
                {
                    MovieID = 3,
                    name = "Blue Valentine",
                    Year = 2010,
                    Rating = 4
                });
        }
    }
}
