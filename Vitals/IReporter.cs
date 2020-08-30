using System;
using System.Diagnostics;
using static Vitals.VitalValueTester;
using static Vitals.VitalStatusLogger;

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
        static int testCount = 0;
        public bool CheckVitals(float bpm, float spo2, float respRate)
        {
            testCount++;
            Console.WriteLine("Test case : {0}", testCount);
            
            bool vital1 = CheckValueAgainstRange("BPM", bpm, 70, 150);
            bool vital2 = CheckValueAgainstRange("SpO2", spo2, 90, null);
            bool vital3 = CheckValueAgainstRange("Respiration rate", respRate, 30, 95);
            bool vitalCheck = vital1 && vital2 && vital3;
            LogVitalsOk(vitalCheck);
            Console.WriteLine("\n"); //To seperate output streams

            return vitalCheck; 
        }  
    }
}