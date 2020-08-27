using System;
using System.Diagnostics;

namespace Vitals
{
    public class BugLogger
    {
        public static void ExpectTrue(bool expression)
        {
            if (!expression)
            {
                Console.WriteLine("Expected true, but got false\n");
                Environment.Exit(1);
            }
        }
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
