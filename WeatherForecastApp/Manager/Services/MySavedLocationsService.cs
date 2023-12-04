using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Manager.Contracts;
using WeatherForecastApp.Manager.Data;
using WeatherForecastApp.Manager.Data.Models;

namespace WeatherForecastApp.Manager.Services
{
    public class MySavedLocationsService : IMySavedLocationsService
    {
        private readonly AppDbContext _context;

        public MySavedLocationsService(AppDbContext context)
        {
            _context = context;
        }
        public async Task Add(MySavedLocation data)
        {
            await _context.Locations.AddAsync(data);
            await _context.SaveChangesAsync();
        }

        public async Task Delete(int Id)
        {
            var data = await _context.Locations.FindAsync(Id);
            _context.Locations.Remove(data);
            await _context.SaveChangesAsync();
        }

        public async Task Update(MySavedLocation data)
        {
            _context.Locations.Update(data);
            await _context.SaveChangesAsync();
        }
    }
}
