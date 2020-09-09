using Meteorology;
using System;

namespace WeatherConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            // TODO: Use the Meteorology project to calculate wind chill factor.
            //       Write the result in the console window.
            //       Check the results with the online calculation tool and debug the program if the results do not comply.

            double inputDegree = 5.0;
            double inputSpeed = 9.0;

            WindChillFactor windChillFactor = new WindChillFactor(SpeedUnit.MeterPerSecond, TemperatureScale.Celsius);
            double result = windChillFactor.CalulateChillFactorTemperature(inputDegree, inputSpeed);

            // Print input values and resulting temperature.
            Console.WriteLine("Temperature: {0}", inputDegree);
            Console.WriteLine("Wind: {0}", inputSpeed);
            Console.WriteLine("Chill Factor: {0}", result);
        }
    }
}
