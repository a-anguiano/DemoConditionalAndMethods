using System;

namespace DemoConditionalAndMethods
{
    class MainClass
    {
        static void Main()
        {
            
        }

        private static bool IsWithinRange(int num, int target, int range)
        {
            return (num - target) <= range;
        }
    }
}
