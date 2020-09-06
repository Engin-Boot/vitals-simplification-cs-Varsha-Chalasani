using System;
using System.Diagnostics;
using static Vitals.IStatusLogger;
namespace Vitals
{
    /// <summary>
    /// This class checks every vital level
    /// and triggers warning in case of any breach
    /// </summary>
    public class VitalValueTester
    {
        public IStatusLogger logger;
        public VitalValueTester(IStatusLogger target)
        {
            this.logger = target;
        }
        public VitalValueTester()
        {
         
        }
        public void LogBreach(string vital, string level, float value)
        {
            this.logger.LogBreach(vital, level, value);
        }
        public bool CheckValueAgainstRange(string vital, float value, int least, int? highest)
        {
            if (value < least)
            {
                this.LogBreach(vital, "low", value);
                return false;
            }
            else if (upperLimitTrigger(value, highest))
            {
                this.LogBreach(vital, "high", value);
                return false;
            }
            
            return true;
        }
        
        static bool upperLimitTrigger(float value, int? highest)
        {
            if (highest != null)
            {
               if(value > highest)
                {
                    return true;
                }
            }
            return false;
        }
    }
}