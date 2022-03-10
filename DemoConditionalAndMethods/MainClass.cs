using System;

namespace DemoConditionalAndMethods
{
    class MainClass
    {
        static void Main()
        {
            
            Console.Write("Do we have power? (y/n) ");
            bool hasPower = Console.ReadLine().ToLower() == "y";

            Console.Write("Do we have paper? (y/n) ");
            bool hasPaper = Console.ReadLine().ToLower() == "y";

            int inkLevel = PromptUser4Int("What's the ink level? ");
            PrintDoc(hasPower, hasPaper, inkLevel);

        }

        //Print a document haPower, hasPaper, and inkLevel >= 10
        private static void PrintDoc(bool hasPower, bool hasPaper, int inkLevel)
        {
            string result = hasPaper && hasPower && inkLevel >= 10 ? "Printing" : "Unable to print";
            Console.Write(result);
        }

        //common method to use
        private static string PromptUser(string message)
        {
            Console.Write(message);
            return Console.ReadLine();  //could include a variable to sub for Read
        }

        private static int PromptUser4Int(string message)
        {
            int result;
            // TODO: while the user's input is not parse-able as an int, continue to ask them to comply 
            while (!int.TryParse(PromptUser(message), out result))
            {
                PromptUser("Invalid Input: Press any key to continue ");
            }
            return result;
        }
    }
}
