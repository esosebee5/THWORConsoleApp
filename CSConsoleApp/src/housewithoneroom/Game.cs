using CSConsoleApp.src.core.models;
using System;
using System.Collections.Generic;
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
        //public static iRoom currentRoom;
        //public static House house = new House();
        //public static LinkedList<iRoom> visitedRooms = new LinkedList<>();
        public int numberOfVisitedRooms = 0;
        private static bool state;

        /// <summary>
        /// Initializes a new blank game with default settings
        /// </summary>
        public static void NewGame()
        {
            state = true;

            // TODO: implement
            //house = new House();
            //currentRoom = house.getCorridor().getFirst();
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
            Console.Write("Are you sure you want to exit? [y/n] ");
            if (Console.ReadLine() == "y")
            {
                state = false;
                Console.WriteLine("Ending Game.");
                //outputLn();
                //output(GameStrings.getEOGUser());
            }
            else
            {
                //outputLn();
                Console.WriteLine("Good.");
            }
        }

        /// <summary>
        /// Generates an end-game sequence for a win???
        /// </summary>
        /// <returns></returns>
        public static int EndGame()
        {
            state = false;
            //output(GameStrings.endGameWin);
            return -99; //why?
        }
    }
}
