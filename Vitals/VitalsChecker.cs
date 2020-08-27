using System;
using System.Diagnostics;
using static Vitals.RespRateChecker;
using static Vitals.BPMChecker;
using static Vitals.SpO2Checker;

namespace Vitals
{
    /// <summary>
    /// This class checks if all vitals are in limits or not
    /// </summary>
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
    }
}