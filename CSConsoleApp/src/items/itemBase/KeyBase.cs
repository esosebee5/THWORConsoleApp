using CSConsoleApp.src.rooms;

namespace CSConsoleApp.src.items.itemBase
{
    class KeyBase : ItemBase, IKey
    {
        private readonly RoomId RoomToUnlock;

        public KeyBase(
            string name,
            string description,
            int size,
            RoomId roomToUnlock)
            : base(name, description, size)
        {
            RoomToUnlock = roomToUnlock;
        }

        public RoomId Unlocks()
        {
            return RoomToUnlock;
        }
    }
}
