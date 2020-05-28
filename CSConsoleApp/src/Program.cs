using CSConsoleApp.src.core.services;
using CSConsoleApp.src.housewithoneroom;
using CSConsoleApp.src.titles;
using System;

namespace CSConsoleApp
{
    class Program
    {
        static int Main()
        {
            // Initialize and start the game
            Game.Start();

            // Herein lies the major flow of the game:
            while (Game.GetState())
            {
                // Collect and filter user commands
                string info = IO.PromptAndGetInput();

                if (info == "quit") Game.ExitGame();
                else IO.OutputNewLine($@"You entered '{info}'.");

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
