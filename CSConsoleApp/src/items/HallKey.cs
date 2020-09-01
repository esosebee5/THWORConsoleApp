using CSConsoleApp.src.items.itemBase;
using CSConsoleApp.src.rooms;

namespace CSConsoleApp.src.items
{
    class HallKey : KeyBase
    {
        #region Java Code

        //public HallKey() { }

        //public String getName()
        //{
        //    return "key";
        //}

        //public String getDescription()
        //{
        //    return "A small, black, iron key.";
        //}

        //public double getSize()
        //{
        //    return 0.5;
        //}

        ////    public String getStats() {
        ////        return null;
        ////    }

        //public String toStringShort()
        //{
        //    return "a black key";
        //}

        //public int unlocks()
        //{
        //    return RoomId.HALL.getId();
        //}

        #endregion

        public HallKey(
            string name = "key",
            string description = "A small, black, iron key.",
            int size = 1,
            RoomId roomToUnlock = RoomId.Hall)
            : base(name, description, size, roomToUnlock)
        { }

        //public String toStringShort()
        //{
        //    return "a black key";
        //}
    }
}
