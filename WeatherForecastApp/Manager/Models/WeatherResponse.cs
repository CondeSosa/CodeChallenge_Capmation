using Android.Net.IpSec.Ike;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastApp.Manager.Models
{
    public class WeatherResponse
    {
        public string LocationName { get; set; } = string.Empty;
        public string Temperature { get; set; } = string.Empty;
        public string Description { get; set; } = string.Empty;
        public double Longitud { get; set; }
        public double Latitud { get; set; }

    }
}
