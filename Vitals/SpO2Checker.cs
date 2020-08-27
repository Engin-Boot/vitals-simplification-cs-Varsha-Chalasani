using System;
using System.Diagnostics;
using static Vitals.BreachFlag;

namespace Vitals
{
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