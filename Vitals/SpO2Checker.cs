using System;
using System.Diagnostics;
using static Vitals.VitalBreachLogger;

namespace Vitals
{
    /// <summary>
    /// This class checks the SpO2 levels
    /// and triggers logger in case it is out of limits
    /// </summary>
    class SpO2Checker
    {
        public static bool Check_SPO2(float spo2)
        {
            if (spo2 < 90)
            {
                BreachLogger("SpO2", "low", spo2);
                return false;
            }
            return true;
        }
    }
}