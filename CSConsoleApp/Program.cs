using System;

namespace CSConsoleApp
{
    class Program
    {
        static bool shouldContinue = true;

        static int Main()
        {
            Console.WriteLine("Hello World!");

            while (shouldContinue == true)
            {
                string input = Console.ReadLine();

                if (input == "quit") shouldContinue = false;
                else Console.WriteLine(input);
            }

            return 0;
        }
    }
}
