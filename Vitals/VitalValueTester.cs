using System;
using System.Diagnostics;
using static Vitals.VitalStatusLogger;
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
                LogBreach(vital, "low", value);
                return false;
            }
            else if (upperLimitTrigger(value, highest))
            {
                LogBreach(vital, "high", value);
                return false;
            }
            return true;
        }
        
        static bool upperLimitTrigger(float value, int? highest)
        {
            if (highest != null)
            {
               if(value > highest)
                {
                    return true;
                }
            }
            return false;
        }
    }
}