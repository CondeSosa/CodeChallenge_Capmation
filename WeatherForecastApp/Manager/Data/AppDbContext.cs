using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Manager.Data.Models;

namespace WeatherForecastApp.Manager.Data
{
    public class AppDbContext : DbContext
    {

        public DbSet<MySavedLocation> Locations { get; set; }

        public AppDbContext(DbContextOptions options) : base(options)
        {
            Database.Migrate();
        }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string dbPath = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData), "weatherApp.db");
            optionsBuilder.UseSqlite($"Data Source={dbPath}");
        }

    
    }
}
