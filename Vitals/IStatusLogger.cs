using System;
using System.Diagnostics;


namespace Vitals
{
    /// <summary>
    /// This class prints a warning to the console 
    /// incase of any breach in vitals
    /// </summary>
    public interface IStatusLogger
    {
        void LogBreach(string vital, string level, float value);
        void LogVitalsOk(bool vitalCheck);
    }
    public class ConsoleLogger : IStatusLogger
    {
        public void LogBreach(string vital,string level,float value)
        {
            Console.WriteLine(vital + " is " + level +"; "+ vital + " = " + value);
        }
        public void LogVitalsOk(bool vitalCheck)
        {
            if (vitalCheck)
            {
                Console.WriteLine("All vitals within limits");
            } 
        }
    }
}