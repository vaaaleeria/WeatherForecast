using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public static class CalculoTemperaturas
    {
        public static int CalcularTemperaturaPromedio(List<RegistroTemperatura> registros)
        {
            if (registros.Count == 0) return 0;

            return Convert.ToInt32(registros.Average(r => r.TemperaturaRegistada));
        }

        public static int CalcularTemperaturaMaxima(List<RegistroTemperatura> registros)
        {
            if (registros.Count == 0) return 0;

            return registros.Max(r => r.TemperaturaRegistada);
        }

        public static int CalcularTemperaturaMinima(List<RegistroTemperatura> registros)
        {
            if (registros.Count == 0) return 0;

            return registros.Min(r => r.TemperaturaRegistada);
        }
    }
}
