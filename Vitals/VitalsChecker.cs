using System;
using System.Diagnostics;

namespace Vitals
{
    public class VitalsChecker
    {
        public static bool CheckVitals(float bpm, float spo2, float respRate)
        {
            if (Check_BPM(bpm) && Check_SPO2(spo2) && Check_respRate(respRate))
            {
                return true;
            }
            return false;
        }
        public static bool  Check_BPM(float bpm)
        {
             return (bpm >= 70 && bpm <= 150);
        }
        public static bool Check_SPO2(float spo2)
        {
            return (spo2 >= 90);
        }
        public static bool Check_respRate(float spo2)
        {
            return (respRate >= 30 && respRate <= 95);
        }
    }
}