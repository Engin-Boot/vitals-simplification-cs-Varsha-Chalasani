using System;
using System.Diagnostics;
using static Vitals.VitalsChecker;
using static Vitals.BugLogger;

namespace Vitals
{
    public class Test
    {
        static int Main()
        {
            // All within limits
            ExpectTrue(CheckVitals(100, 95, 60));

            //Two withhin limits
            ExpectFalse(CheckVitals(40, 91, 92));
            ExpectFalse(CheckVitals(150, 89, 72));
            ExpectFalse(CheckVitals(70, 95, 25));

            //Only one within limits
            ExpectFalse(CheckVitals(162, 70, 92));
            ExpectFalse(CheckVitals(63, 99, 97));
            ExpectFalse(CheckVitals(90, 73, 27));

            //All vitals out of limits
            ExpectFalse(CheckVitals(170, 60, 100));

            Console.WriteLine("All ok");
            return 0;
        }
    }
}