using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Manager.Models;

namespace WeatherForecastApp.Manager.Contracts
{
    public interface IWeatherForecast
    {
        Task<Result<WeatherResponse>> GetWeather(WeatherRequest request);

    }
}
