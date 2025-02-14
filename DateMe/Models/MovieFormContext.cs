using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class MovieFormContext : DbContext
    {
        public MovieFormContext(DbContextOptions<MovieFormContext> options) : base (options) // Contructor
        {
        } 

        public DbSet<Application> Applications { get; set; }
    }
}
