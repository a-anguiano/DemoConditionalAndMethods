using System;

namespace DemoConditionalAndMethods
{
    class MainClass
    {
        static void Main()
        {
            //Ask the user for the initial num
            Console.WriteLine("What is the initial number? ");
            int startingNum = int.Parse(Console.ReadLine());

            //Ask the user for the target
            Console.WriteLine("What is the target? ");
            int targetNum = int.Parse(Console.ReadLine());

            //Ask the user for the range
            Console.WriteLine("What is the range?");
            int range = int.Parse(Console.ReadLine());


            string results = IsWithinRange(startingNum, targetNum, range) ? "It is within range." : "It isn't within range.";
            //Write the result by calling IsWithinRange
            //Print an appropriate string based upon the boolean results from IsWithinRange 
            Console.WriteLine($"Given a starting number of {startingNum} and a target number of {targetNum}. " +
                $"{results}");
        }

        private static bool IsWithinRange(int num, int target, int range)
        {
            return (num - target) <= range;
        }
    }
}
