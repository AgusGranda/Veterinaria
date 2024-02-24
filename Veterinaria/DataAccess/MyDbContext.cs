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
            optionsBuilder.UseSqlServer("Data Source=DESKTOP-76KGP02\\SQLEXPRESS;Initial Catalog=Veterinaria_DB;Persist Security Info = True;Trusted_Connection = SSPI;MultipleActiveResultSets=True; Trust Server Certificate= True");
        }

    }
}
