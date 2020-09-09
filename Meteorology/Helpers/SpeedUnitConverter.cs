using System;
using System.Collections.Generic;
using System.Text;

namespace Meteorology
{
    static class SpeedUnitConverter
    {
        public static double ConvertMilesPerHourToMeterPerSecond(double windInMilesPerHour)
        {
            return windInMilesPerHour * 0.44704;
        }

        public static double ConvertMeterPerSecondToMilesPerHour(double windInMeterPerSecond)
        {
            // this line is return windInMeterPerSecond * 2.23694 or return windInMeterPerSecond / 0.44704
            return windInMeterPerSecond * 2.23694;
        }
    }
}
