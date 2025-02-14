using System.ComponentModel.DataAnnotations;
using Microsoft.EntityFrameworkCore;

namespace DateMe.Models
{
    public class DatingApplicationContext : DbContext
    {
        public DatingApplicationContext(DbContextOptions<DatingApplicationContext> options) : base (options) // Contructor
        {
        } 

        public DbSet<Application> Applications { get; set; }
    }
}
