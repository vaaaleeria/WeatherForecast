namespace WeatherForecastMejorado
{
    internal class Program
    {
        static void Main()
        {
            var estacionMeteorologica = new EstacionMeteorologica();

            try
            {
                bool nextSteps = true;
                Console.WriteLine("Hola, Bienvenid@ a nuestro sistema!");
                do
                {
                    Console.WriteLine("Por favor seleccione una opción:");
                    Console.WriteLine("1. Quiere registrar temperaturas");
                    Console.WriteLine("2. Quiere ver las temperaturas cargadas");
                    Console.WriteLine("3. Quiere ver la temperatura de un dia");
                    Console.WriteLine("4. Quiere saber el promedio de temperaturas.");
                    Console.WriteLine("5. Quiere saber la temperatura más alta.");
                    Console.WriteLine("6. Quiere saber la temperatura más baja.");
                    Console.WriteLine("7. Salir");
                    int nextStep = int.Parse(Console.ReadLine());
                    switch (nextStep)
                    {
                        case 1:
                            Console.WriteLine("Cargar registros:");
                            estacionMeteorologica.CargarRegistros();
                            break;
                        case 2:
                            Console.WriteLine("Temperaturas cargadas:");
                            estacionMeteorologica.VerTemperaturas();
                            break;
                        case 3:
                            Console.WriteLine("Temperatura del 2024-08-21:");
                            estacionMeteorologica.VerTemperaturaPorFecha(new DateOnly(2024, 8, 21));
                            break;
                        case 4:
                            Console.WriteLine("Temperatura promedio: " + CalculoTemperaturas.CalcularTemperaturaPromedio(estacionMeteorologica.registroTemperatura));
                            break;
                        case 5:
                            Console.WriteLine("Temperatura máxima: " + CalculoTemperaturas.CalcularTemperaturaMaxima(estacionMeteorologica.registroTemperatura));
                            break;
                        case 6:
                            Console.WriteLine("Temperatura mínima: " + CalculoTemperaturas.CalcularTemperaturaMinima(estacionMeteorologica.registroTemperatura));
                            break;
                        default:
                            nextSteps = false;
                            break;
                    }

                } while (nextSteps);
                Console.WriteLine("Muchas gracias! Hasta luego :)");
            }
            catch (System.Exception)
            {
                Console.WriteLine("Muchas gracias! Hasta luego :)");
            }
          
        }
    }
}
