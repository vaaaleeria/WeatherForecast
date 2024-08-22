using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public class Pasante : Persona
    {
        public string NumeroLegajo { get; set; }

        public Pasante(string nombre, string apellido, string numeroLegajo)
            : base(nombre, apellido)
        {
            NumeroLegajo = numeroLegajo;
        }
    }
}
