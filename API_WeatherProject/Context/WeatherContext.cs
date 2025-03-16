using Microsoft.EntityFrameworkCore;
using WebApi_WeatherProject.Entities;

namespace WebApi_WeatherProject.Context
{
    public class WeatherContext: DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-PE94F8E\\SQLEXPRESS; initial catalog=Db2Project20; integrated Security=true; TrustServerCertificate=True");
        }
        public DbSet<City> Cities { get; set; }
    }
}
