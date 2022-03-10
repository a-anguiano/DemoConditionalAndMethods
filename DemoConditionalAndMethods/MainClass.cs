using System;

namespace DemoConditionalAndMethods
{
    class MainClass
    {
        static void Main()
        {
            
            Console.Write("Do we have power? (y/n)");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.WriteLine("Do we have paper? (y/n)");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            Console.WriteLine("What's the ink level?");
            int inkLevel = int.Parse(Console.ReadLine());

            PrintDoc(hasPower, hasPaper, inkLevel);

        }

        //Print a document haPower, hasPaper, and inkLevel >= 10
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print";
            Console.Write(result);
        }
    }
}
