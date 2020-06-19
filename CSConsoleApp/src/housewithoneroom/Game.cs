using CSConsoleApp.src.core.models;
using CSConsoleApp.src.core.models.rooms;
using CSConsoleApp.src.core.services;
using CSConsoleApp.src.rooms;
using CSConsoleApp.src.titles;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSConsoleApp.src.housewithoneroom
{
    class Game
    {
        #region Java code

        //public static Player player;
        //public static iRoom currentRoom;
        //public static House house = new House();
        //public static LinkedList<iRoom> visitedRooms = new LinkedList<>();
        //public int numberOfVisitedRooms = 0;
        //public static boolean state = true;

        //public static void NewGame()
        //{
        //    house = new House();
        //    currentRoom = house.getCorridor().getFirst();
        //}

        //public Game(int roomId)
        //{
        //    house = new House();
        //    currentRoom = house.getCorridor().get(roomId);
        //}

        //public static void exitGame()
        //{
        //    output("Are you sure you want to exit? [y/n] ");
        //    if (IOService.getNextLine().equals("y"))
        //    {
        //        state = false;
        //        outputLn();
        //        output(GameStrings.getEOGUser());
        //    }
        //    else
        //    {
        //        outputLn();
        //        output("Good.");
        //    }
        //}

        //public static int endGame()
        //{
        //    state = false;
        //    output(GameStrings.endGameWin);
        //    return -99;
        //}

        #endregion

        //public static Player player;
        public static IRoom CurrentRoom
        {
            get;
            set;
        }

        public static House House
        {
            get;
            set;
        }

        public static List<IRoom> visitedRooms = new List<IRoom>();
        /// <summary>
        /// this should be unnecessary (just take a count of the visitedRooms list)
        /// </summary>
        public int numberOfVisitedRooms = 0;
        private static bool state;

        /// <summary>
        /// Initializes a new blank game with default settings
        /// </summary>
        private static void NewGame()
        {
            state = true;

            House = new House();
            CurrentRoom = House.GetFirstRoom();
            
            // Verify...
            IO.OutputNewLine($"Current Room: {CurrentRoom.GetName()}");
        }

        /// <summary>
        /// Initializes a new blank game starting in the specified room
        /// </summary>
        /// <param name="roomId"></param>
        public Game(int roomId)
        {
            state = true;

            // TODO: implement
            //house = new House();
            //currentRoom = house.getCorridor().get(roomId);
        }

        public static void Start(bool isNew = true)
        {
            // Reset properties if this is a new game
            if (isNew == true) NewGame();

            // Start game process
            GreetPlayer();
        }

        public static void GreetPlayer()
        {
            // Greet Player
            IO.OutputNewLine(GameStrings.GetWelcome());
            IO.OutputNewLine(GameStrings.GetHouse());
        }

        /// <summary>
        /// Returns the boolean state of the game
        /// </summary>
        /// <returns></returns>
        public static bool GetState()
        {
            return state;
        }

        /// <summary>
        /// Initiates the "Would you like to end the game?" sequence
        /// </summary>
        public static void ExitGame()
        {
            IO.OutputSameLine("Are you sure you want to exit? [y/n] ");
            if (IO.GetInput() == "y")
            {
                state = false;
                IO.OutputNewLine();
                IO.OutputNewLine(GameStrings.EOGUser);
            }
            else
            {
                IO.OutputNewLine();

                IO.OutputNewLine("Good.");
            }
        }

        /// <summary>
        /// Generates an end-game sequence for a win???
        /// </summary>
        /// <returns></returns>
        public static void EndGame(bool win = false)
        {
            state = false;
            if (win == true) IO.OutputNewLine(GameStrings.EndGameWin);
        }
    }
}
