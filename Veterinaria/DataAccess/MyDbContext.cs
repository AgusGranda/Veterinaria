using Microsoft.EntityFrameworkCore;
using Veterinaria.Models;

namespace Veterinaria.DataAccess
{
    public class MyDbContext : DbContext
    {
        public DbSet<Doctor> Doctors { get; set; }
        public DbSet<Animal> Animals { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("");
        }

    }
}
