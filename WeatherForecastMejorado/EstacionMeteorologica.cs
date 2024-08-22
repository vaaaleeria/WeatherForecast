using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WeatherForecastMejorado
{
    public class EstacionMeteorologica
    {
        public List<RegistroTemperatura> registroTemperatura;
        public List<Persona> personaTurno;

        public EstacionMeteorologica()
        {
            registroTemperatura = new List<RegistroTemperatura>();
            personaTurno = new List<Persona>
        {
            new Pasante("Juan", "Pérez", "1"),
            new Profesional("Ana", "Gómez", "1"),
            new Pasante("Luis", "Martínez", "2"),
            new Profesional("Sofía", "Rodríguez", "2"),
            new Pasante("María", "Fernández", "3"),
            new Profesional("Carlos", "García", "3")
        };
        }

        public void RegistrarTemperatura(RegistroTemperatura registro)
        {
            registroTemperatura.Add(registro);
        }

        public void VerTemperaturas()
        {
            foreach (var registro in registroTemperatura)
            {
                Console.WriteLine(registro);
            }
        }

        public void VerTemperaturaPorFecha(DateOnly fecha)
        {
            foreach (var registro in registroTemperatura)
            {
                if (registro.FechaRegistro == fecha)
                {
                    Console.WriteLine(registro);
                }
            }
        }

        public void CargarRegistros()
        {
            
            Console.WriteLine("Ingrese el número de registros que desea cargar:");
            try
            {
                if (int.TryParse(Console.ReadLine(), out int cantidad))
                {
                    for (int i = 0; i < cantidad; i++)
                    {
                        Console.WriteLine("Ingrese la temperatura:");
                        if (int.TryParse(Console.ReadLine(), out int temperatura))
                        {
                            Console.WriteLine("Ingrese la fecha en formato YYYY-MM-DD:");
                            if (DateOnly.TryParse(Console.ReadLine(), out DateOnly fecha))
                            {
                                Console.WriteLine("Ingrese la hora en formato HH:MM:");
                                if (TimeSpan.TryParse(Console.ReadLine(), out TimeSpan hora))
                                {
                                    var persona = personaTurno[i];
                                    RegistrarTemperatura(new RegistroTemperatura(temperatura, persona, fecha, hora));
                                }

                            }

                        }

                    }
                }
            } catch (System.Exception)
            {
                Console.WriteLine("Muchas gracias! Hasta luego :)");
            }

        }
    }
}
