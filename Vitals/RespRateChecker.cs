using System;
using System.Diagnostics;
using static Vitals.VitalBreachLogger;

namespace Vitals
{
    /// <summary>
    /// This class checks the respiration rate levels
    /// and triggers logger in case it is out of limits
    /// </summary>
    class RespRateChecker
    {
        public static bool Check_respRate(float respRate)
        {
            if (respRate < 30)
            {
                BreachLogger("Respiration rate", "low", respRate);
                Console.WriteLine("\n"); //Line break for each test case
                return false;
            }
            else if (respRate > 95)
            {
                BreachLogger("Respiration rate", "high", respRate);
                Console.WriteLine("\n"); //Line break for each test case
                return false;
            }
            Console.WriteLine("\n"); //Line break for each test case
            return true;
        }
    }
}
