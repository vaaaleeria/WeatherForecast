using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public class Profesional : Persona
    {
        public string NumeroMatricula { get; set; }

        public Profesional(string nombre, string apellido, string numeroMatricula)
            : base(nombre, apellido)
        {
            NumeroMatricula = numeroMatricula;
        }

    }
}
