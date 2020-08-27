using System;
using System.Diagnostics;
using static Vitals.BreachFlag;

namespace Vitals
{
    class RespRateChecker
    {
        public static bool Check_respRate(float respRate)
        {
            if (respRate < 30)
            {
                BreachLogger("Respiration rate", "low", respRate);
                return false;
            }
            else if (respRate > 95)
            {
                BreachLogger("Respiration rate", "high", respRate);
                return false;
            }
            return true;
        }
    }
}