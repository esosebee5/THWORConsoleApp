using CSConsoleApp.src.core.models.rooms;
using CSConsoleApp.src.core.services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CSConsoleApp.src.rooms
{
    class House
    {
        #region Java code

        //private LinkedList<iRoom> corridor = new LinkedList<>();

        //public House()
        //{
        //    this.corridor.add(new Library());
        //    this.corridor.add(new Study());
        //    this.corridor.add(new Hall());
        //    this.corridor.add(new DiningRoom());
        //    this.corridor.add(new ComputerRoom());
        //    this.corridor.add(new Kitchen());
        //    this.corridor.add(new Pantry());
        //    this.corridor.add(new UpstairsHallway());
        //}

        //public LinkedList<iRoom> getCorridor()
        //{
        //    return this.corridor;
        //}

        #endregion

        private List<IRoom> Corridor;
        
        /// <summary>
        /// Constructor for the House
        /// </summary>
        public House()
        {
            BuildCorridor();
        }

        /// <summary>
        /// Initialize the Corridor
        /// </summary>
        private void BuildCorridor()
        {
            Corridor = new List<IRoom>();
            Corridor.Add(new Library());

            // Test corridor structure:
            foreach (IRoom room in Corridor)
            {
                IO.OutputNewLine(room.GetName());
            }
        }

        /// <summary>
        /// Returns the first room of the corridor
        /// </summary>
        /// <returns></returns>
        public IRoom GetFirstRoom()
        {
            return Corridor.FirstOrDefault();
        }


    }
}
