﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public abstract class Persona
    {
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        protected Persona(string nombre, string apellido)
        {
            Nombre = nombre;
            Apellido = apellido;
        }

    }
}
