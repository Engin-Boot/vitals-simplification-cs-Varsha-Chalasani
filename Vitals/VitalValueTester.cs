using System;
using System.Diagnostics;
using static Vitals.VitalBreachLogger;
namespace Vitals
{
    /// <summary>
    /// This class checks every vital level
    /// and triggers warning in case of any breach
    /// </summary>
    class VitalValueTester
    {
        public static bool CheckValueAgainstRange(string vital, float value, int least, int? highest)
        {
            if (value < least)
            {
                BreachLogger(vital, "low", value);
                return false;
            }
            else if (highest!=null)
            {
                if(value > highest)
                {
                    BreachLogger(vital, "high", value);
                    return false;
                } 
            }
            return true;
        }
    }
}