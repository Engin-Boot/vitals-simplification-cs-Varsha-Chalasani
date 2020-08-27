using System;
using System.Diagnostics;
using static Vitals.BreachFlag;

namespace Vitals
{
    public class VitalsChecker
    {
        public static bool CheckVitals(float bpm, float spo2, float respRate)
        {
            bool vital1 = Check_BPM(bpm);
            bool vital2 = Check_SPO2(spo2);
            bool vital3 = Check_respRate(respRate);
            bool vitalCheck = vital1 && vital2 && vital3;
            
            return vitalCheck;
            
        }
        public static bool Check_BPM(float bpm)
        {
            if(bpm < 70)
            {
                BreachLogger("BPM", "low", bpm);
                return false;
            }
            else if(bpm > 150)
            {
                BreachLogger("BPM", "high", bpm);
                return false;
            }
            return true;
        }
        public static bool Check_SPO2(float spo2)
        {
            if (spo2 < 90)
            {
                BreachLogger("SpO2", "low", spo2);
                return false;
            }
            return true;
        }
        public static bool Check_respRate(float respRate)
        {
            if(respRate < 30){
                BreachLogger("Respiration rate", "low", respRate);
                return false;
            }
            else if(respRate > 95)
            {
                BreachLogger("Respiration rate", "high", respRate);
                return false;
            }
            return true;
        }
    }
}