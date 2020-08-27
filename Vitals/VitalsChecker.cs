using System;
using System.Diagnostics;

namespace Vitals
{
    public class VitalsChecker
    {
        public static bool CheckVitals(float bpm, float spo2, float respRate)
        {
            bool condition1 = Check_BPM(bpm);
            bool condition2 = condition1 && Check_SPO2(spo2);
            bool condition3 = condition2 && Check_respRate(respRate);

            return condition3;
            
        }
        public static bool Check_BPM(float bpm)
        {
            return (bpm >= 70 && bpm <= 150);
        }
        public static bool Check_SPO2(float spo2)
        {
            return (spo2 >= 90);
        }
        public static bool Check_respRate(float respRate)
        {
            return (respRate >= 30 && respRate <= 95);
        }
    }
}