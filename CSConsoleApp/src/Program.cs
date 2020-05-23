using CSConsoleApp.src.housewithoneroom;
using CSConsoleApp.src.titles;
using System;

namespace CSConsoleApp
{
    class Program
    {
        static int Main()
        {
            // Initialize the new Game
            Game.NewGame();

            // Greet Player
            Console.WriteLine(GameStrings.GetWelcome());
            Console.WriteLine(GameStrings.GetHouse());

            // Herein lies the major flow of the game:
            while (Game.GetState())
            {
                // Instruct the user
                //outputForInput("> ");
                Console.Write("> ");

                // Collect and filter user commands
                string info = Console.ReadLine();

                if (info == "quit") Game.ExitGame();
                else Console.WriteLine($@"You entered '{info}'.");

                //string[] commands = splitAndSanitizeInput(info);
                //outputLn();

                //// Process user commands
                //parseInput(commands);
                //outputLn();
            }

            return 0;
        }
    }
}
