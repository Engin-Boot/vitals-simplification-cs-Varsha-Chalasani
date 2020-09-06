using System;
using System.Diagnostics;
using static Vitals.VitalsChecker;
using static Vitals.BugLogger;
using static Vitals.VitalValueTester;

namespace Vitals
{
    /// <summary>
    /// This class tests the logic with varied test cases
    /// </summary>
    public class Test
    {
        IReporter report;

        Test(IReporter vitalsReport){
            this.report = vitalsReport;
        }
        bool Report(float bpm, float spo2, float respRate)
        {
            return report.CheckVitals(bpm, spo2, respRate);
        }
        static int Main()
        {
            IReporter reporter = new VitalsChecker();
            Test _test = new Test(reporter);

            IStatusLogger logger = new ConsoleLogger();
            VitalValueTester valueTester = new VitalValueTester(logger);
            VitalsChecker checker = new VitalsChecker(logger);
            // All within limits
            ExpectTrue(_test.Report(100, 95, 60));

            //Two withhin limits
            ExpectFalse(_test.Report(40, 91, 92));
            ExpectFalse(_test.Report(150, 89, 72));
            ExpectFalse(_test.Report(70, 95, 25));

            //Only one within limits
            ExpectFalse(_test.Report(162, 70, 92));
            ExpectFalse(_test.Report(63, 99, 97));
            ExpectFalse(_test.Report(90, 73, 27));

            //All vitals out of limits
            ExpectFalse(_test.Report(170, 60, 100));

            return 0;
        }
    }
}