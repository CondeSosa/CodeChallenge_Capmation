using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using WeatherForecastApp.Manager.Contracts;
using WeatherForecastApp.Manager.Models;

namespace WeatherForecastApp.Manager.Services
{
    public class WeatherForecast : IWeatherForecast
    {
        public WeatherForecast()
        {
            
        }
        public async Task<Result<WeatherResponse>> GetWeather(WeatherRequest request)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    var response = await client.GetAsync($"https://api.openweathermap.org/data/3.0/onecall?lat={request.Latitud}&lon={request.Longitud}&appid={ApiSettings.ApiKey}");
                    if (response.IsSuccessStatusCode)
                    {
                        var result = await response.Content.ReadAsStringAsync();

                        //TODO Get the weather info ...

                        WeatherResponse data = new WeatherResponse();


                        return new Result<WeatherResponse> { Success = true, ErrorMessage = string.Empty,Data = data };
                    }
                }
            }
            catch(Exception ex)
            {
                return new Result<WeatherResponse> { Success = false,ErrorMessage = ex.Message };
            }

            return new Result<WeatherResponse> {Success = false};
        }
    }
}
