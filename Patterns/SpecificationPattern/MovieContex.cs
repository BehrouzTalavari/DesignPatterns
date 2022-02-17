using Microsoft.EntityFrameworkCore;

namespace SpecificationPattern
{
    public class MovieContex : DbContext
    {
        public DbSet<Movie> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }
    }
}