using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Manager.Data.Models;
using WeatherForecastApp.Manager.Models;

namespace WeatherForecastApp.Manager.Contracts
{
    public interface IMySavedLocationsService
    {
        Task Add(MySavedLocation data);
        Task Update(MySavedLocation data);
        Task Delete(int Id);
    }
}
