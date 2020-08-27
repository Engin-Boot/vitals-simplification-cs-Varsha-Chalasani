using System;
using System.Diagnostics;
using static Vitals.BreachFlag;

namespace Vitals
{
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