using System;
using System.Diagnostics;
using static Vitals.VitalBreachLogger;

namespace Vitals
{
    /// <summary>
    /// This class checks the beats per minute levels
    /// and triggers logger in case it is out of limits
    /// </summary>
    class BPMChecker
    {
        public static bool Check_BPM(float bpm)
        {
            if (bpm < 70)
            {
                BreachLogger("BPM", "low", bpm);
                return false;
            }
            else if (bpm > 150)
            {
                BreachLogger("BPM", "high", bpm);
                return false;
            }
            return true;
        }
    }
}