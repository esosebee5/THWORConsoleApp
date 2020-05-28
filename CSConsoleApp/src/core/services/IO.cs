using System;
using System.Collections.Generic;
using System.Text;

namespace CSConsoleApp.src.core.services
{
    /// <summary>
    /// Handles input and output for the application
    /// </summary>
    class IO
    {
        /// <summary>
        /// Displays the message on its own line
        /// </summary>
        /// <param name="message"></param>
        public static void OutputNewLine(string message = null)
        {
            if (message == null || message.Trim().Length == 0) Console.WriteLine();
            else Console.WriteLine(message);
        }

        /// <summary>
        /// Displays the message in the same line
        /// </summary>
        /// <param name="message"></param>
        public static void OutputSameLine(string message)
        {
            Console.Write(message);
        }

        /// <summary>
        /// Read a line of input from the user
        /// </summary>
        /// <returns></returns>
        public static string GetInput()
        {
            return Console.ReadLine();
        }

        public static string PromptAndGetInput()
        {
            OutputSameLine("> ");
            return GetInput();
        }
    }
}
