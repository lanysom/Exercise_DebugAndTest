using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    public class SpeedUnitConverter
    {
        public double ConvertMilesPerHourToMeterPerSecond(double windInMilesPerHour)
        {
            return Math.Round(windInMilesPerHour * 0.44704, 5);
        }

        public double ConvertMeterPerSecondToMilesPerHour(double windInMeterPerSecond)
        {
            // this line is return windInMeterPerSecond * 2.23694 or return windInMeterPerSecond / 0.44704
            return Math.Round(windInMeterPerSecond * 2.23694, 5);
        }
    }
}
