using THWOR.src.core.services;
using THWOR.src.housewithoneroom;

namespace THWOR
{
    class Program
    {
        static void Main()
        {
            // Initialize and start the game
            Game.Start();

            // Herein lies the major flow of the game:
            while (Game.GetState())
            {
                // Collect and filter user commands
                string info = IO.PromptAndGetInput();

                // Empty line buffer after getting input
                IO.OutputNewLine();

                // Process user commands
                string[] commands = IO.SplitAndSanitizeInput(info);
                CommandProcessingService.ParseInput(commands);

                // Empty line buffer before getting next input
                IO.OutputNewLine();
            }

            IO.GetInput();
        }
    }
}
