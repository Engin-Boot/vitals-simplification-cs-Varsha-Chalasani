using System;
using System.Diagnostics;
using static Vitals.IStatusLogger;
using static Vitals.IReporter;
using static Vitals.BugLogger;
using static Vitals.VitalValueTester;

namespace Vitals
{
    /// <summary>
    /// This class tests the logic with varied test cases
    /// </summary>
    public class Test
    {
        static int Main()
        {
            IReporter reporter = new VitalsChecker();

            IStatusLogger logger = new ConsoleLogger();
            VitalValueTester valueTester = new VitalValueTester(logger);
            VitalsChecker checker = new VitalsChecker(logger);
            // All within limits
            ExpectTrue(reporter.CheckVitals(100, 95, 60));

            //Two withhin limits
            ExpectFalse(reporter.CheckVitals(40, 91, 92));
            ExpectFalse(reporter.CheckVitals(150, 89, 72));
            ExpectFalse(reporter.CheckVitals(70, 95, 25));

            //Only one within limits
            ExpectFalse(reporter.CheckVitals(162, 70, 92));
            ExpectFalse(reporter.CheckVitals(63, 99, 97));
            ExpectFalse(reporter.CheckVitals(90, 73, 27));

            //All vitals out of limits
            ExpectFalse(reporter.CheckVitals(170, 60, 100));

            return 0;
        }
    }
}