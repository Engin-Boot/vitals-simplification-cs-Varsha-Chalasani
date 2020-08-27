using System;
using System.Diagnostics;

namespace Vitals
{
    /// <summary>
    /// This class prints a warning to the console 
    /// incase of any breach in vitals
    /// </summary>
    public class VitalBreachLogger
    {
        public static void BreachLogger(string vital,string level,float value)
        {
            Console.WriteLine(vital + " is " + level +"; "+ vital + " = " + value);
        }
    }
}