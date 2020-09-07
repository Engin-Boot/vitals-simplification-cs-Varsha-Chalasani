using System;
using System.Diagnostics;
using static Vitals.VitalValueTester;
using static Vitals.IStatusLogger;


namespace Vitals
{
    /// <summary>
    /// This interface reports vital checks
    /// </summary>
    interface IReporter
    {
        bool CheckVitals(float bpm, float spo2, float respRate);
    }
    public class VitalsChecker : IReporter
    {
        private static int testCount = 0;
        public IStatusLogger allOkLogger;
        public VitalsChecker(IStatusLogger target)
        {
            this.allOkLogger = target;
        }
        public VitalsChecker()
        {
            this.allOkLogger = null;
        }
        public void LogVitalsOk(bool vitalCheck)
        {
            this.allOkLogger.LogVitalsOk(vitalCheck);
        }
        public bool CheckVitals(float bpm, float spo2, float respRate)
        {
            testCount++;
            Console.WriteLine("Test case : {0}", testCount);

            VitalValueTester valueTester = new VitalValueTester();

            bool vital1 = valueTester.CheckValueAgainstRange("BPM", bpm, 70, 150);
            bool vital2 = valueTester.CheckValueAgainstRange("SpO2", spo2, 90, null);
            bool vital3 = valueTester.CheckValueAgainstRange("Respiration rate", respRate, 30, 95);
            bool vitalCheck = vital1 && vital2 && vital3;
            this.LogVitalsOk(vitalCheck);
            Console.WriteLine("\n"); //To seperate output streams

            return vitalCheck; 
        }
    }
}