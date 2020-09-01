using CSConsoleApp.src.core.services;
using CSConsoleApp.src.titles;

namespace CSConsoleApp.src.adventures
{
    class LibraryBookshelfAdventure
    {
        #region Java code

        //    private static final String[] bookTitlesInLibrary = {""
        //        + "The Tragic Youth of Ambrose Fogarty: \n"
        //        + "\tYoung Master Fogarty, by KM",
        //        "\nThe Tragic Youth of Ambrose Fogarty: \n"
        //                + "\tFogarty, Esquire, by KM",
        //        "\nThe Tragic Youth of Ambrose Fogarty: \n"
        //                + "\tIn Her Majesty's Service, by KM",
        //        "\nThe Perilous Adventures of Jon Legenn, by KM",
        //        "\nMcEver, by KM",
        //        "\nThe Complete Clocktower Books, by KM and FM"
        //};


        //public static void browseLibrary()
        //    {
        //        output(showBookTitles());

        //        String action = IOService.getNextLine();
        //        String[] actionsArray = action.split(" ");

        //        while (!actionsArray[0].equals("leave"))
        //        {
        //            switch (actionsArray[0])
        //            {
        //                case "read":
        //                    output(readBook(actionsArray));
        //                    break;
        //                default:
        //                    output("enter 'leave' to leave");
        //            }

        //            actionsArray = IOService.getNextLine().split(" ");
        //        }

        //    }

        //    private static String showBookTitles()
        //    {
        //        return Arrays.toString(bookTitlesInLibrary);
        //    }

        //    private static String readBook(String[] commands)
        //    {
        //        if (commands.length > 1)
        //        {
        //            switch (commands[1])
        //            {
        //                case "m":
        //                    return Excerpts.mcEver;
        //                case "l":
        //                    return Excerpts.legenn;
        //                case "f":
        //                    return Excerpts.fogarty;
        //                case "c":
        //                    return Excerpts.clocktower;
        //                default:
        //                    return "Try 'm', 'l', 'f', or 'c'.";
        //            }
        //        }
        //        return "Try including a title after 'read'.";
        //    }

        #endregion

        public static void BrowseLibrary()
        {
            IO.OutputNewLine(ShowBookTitles());
            IO.OutputNewLine();

            string[] actionsArray = IO.SplitAndSanitizeInput(IO.GetInput());

            while (!actionsArray[0].Equals("leave"))
            {
                // Empty line buffer after getting input
                IO.OutputNewLine();

                switch (actionsArray[0])
                {
                    case "read":
                        if (CommandProcessingService.ValidateNoun(actionsArray))
                        {
                            IO.OutputNewLine(ReadBook(actionsArray));
                        }
                        else
                        {
                            IO.OutputNewLine("Try including a title after 'read'.");
                        }
                        break;
                    default:
                        IO.OutputNewLine("enter 'leave' to leave");
                        break;
                }

                // Empty line buffer before getting next input
                IO.OutputNewLine();

                actionsArray = IO.SplitAndSanitizeInput(IO.GetInput());
            }

        }

        private static string ShowBookTitles()
        {
            return Excerpts.bookTitlesInLibrary;
        }

        private static string ReadBook(string[] commands)
        {
            string message;

            switch (commands[1])
            {
                case "m":
                case "mcever":
                    message = Excerpts.mcEver;
                    break;
                case "l":
                case "legenn":
                case "jon":
                    message = Excerpts.legenn;
                    break;
                case "f":
                case "fogarty":
                    message = Excerpts.fogarty;
                    break;
                case "c":
                case "clocktower":
                    message = Excerpts.clocktower;
                    break;
                default:
                    message = "Try 'm', 'l', 'f', or 'c'.";
                    break;
            }

            return message;
        }
    }
}
