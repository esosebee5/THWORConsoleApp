using CSConsoleApp.src.rooms;

namespace CSConsoleApp.src.items
{
    interface IKey
    {
        #region Java Code

        /**
         *
         * @return the room id that this key unlocks
         */
        //int unlocks();

        #endregion

        /// <summary>
        /// Returns the room id that this key unlocks
        /// </summary>
        RoomId Unlocks();
    }
}
