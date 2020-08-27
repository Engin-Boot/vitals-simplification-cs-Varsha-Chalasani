using System;
using System.Diagnostics;

namespace Vitals
{
    public class BreachFlag
    {
        public static void BreachLogger(string vital,string level,float value)
        {
            Console.WriteLine(vital + " is " + level + vital + " = " + value);
        }
    }
}