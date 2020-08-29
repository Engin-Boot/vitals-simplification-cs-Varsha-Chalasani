using System;
using System.Diagnostics;

namespace Vitals
{
    /// <summary>
    /// This class prints a warning to the console 
    /// incase of any breach in vitals
    /// </summary>
    public class VitalStatusLogger
    {
        public static void LogBreach(string vital,string level,float value)
        {
            Console.WriteLine(vital + " is " + level +"; "+ vital + " = " + value);
        }
        public static void LogVitalsOk(bool VitalCheck)
        {
            if (VitalCheck)
            {
                Console.WriteLine("All vitals within limits");
            }
        }
    }
}