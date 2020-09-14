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
            SpeedUnit speedUnit = SpeedUnit.MeterPerSecond;
            TemperatureScale temperatureScale = TemperatureScale.Celsius;

            WindChillFactor windChillFactor = new WindChillFactor(speedUnit, temperatureScale);
            double result = windChillFactor.Calulate(inputSpeed, inputDegree);

            // Print input values and resulting temperature.
            Console.WriteLine("Temperature: {0} {1}", inputDegree, temperatureScale);
            Console.WriteLine("Wind: {0} {1}", inputSpeed, speedUnit);
            Console.WriteLine("Calculated Chill Factor: {0}", result);
        }
    }
}
