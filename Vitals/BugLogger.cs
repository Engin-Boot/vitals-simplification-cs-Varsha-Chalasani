using System;
using System.Diagnostics;

namespace Vitals
{
    /// <summary>
    /// This class is to catch any outliers or bugs
    /// and looks out for false positives/false negatives
    /// </summary>
    public class BugLogger
    {
        //False negatives
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false\n");
                Environment.Exit(1);
            }
        }
        //False positives
        public static void ExpectFalse(bool expression)
        {
            if (expression)
            {
                Console.WriteLine("Expected false, but got true\n");
                Environment.Exit(1);
            }
        }
        
    }
}
