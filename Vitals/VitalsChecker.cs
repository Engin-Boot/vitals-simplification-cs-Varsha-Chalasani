using System;
using System.Diagnostics;
using static Vitals.VitalValueTester;

namespace Vitals
{
    /// <summary>
    /// This class checks if all vitals are in limits or not
    /// </summary>
    public class VitalsChecker
    {
        public static bool CheckVitals(float bpm, float spo2, float respRate)
        {
            bool vital1 = CheckValueAgainstRange("BPM", bpm, 70, 150);
            bool vital2 = CheckValueAgainstRange("SpO2", spo2, 90, null);
            bool vital3 = CheckValueAgainstRange("Respiration rate", respRate, 30, 95);
            Console.WriteLine("\n"); //To seperate output streams
            bool vitalCheck = vital1 && vital2 && vital3;
            
            return vitalCheck; 
        }  
    }
}