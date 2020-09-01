using System.Linq;

namespace THWOR.src.items
{
    abstract class ItemBase : IItem
    {
        private readonly string Name;
        private readonly string Description;
        private readonly int Size;

        public ItemBase(string name, string description, int size)
        {
            Name = name;
            Description = description;
            Size = size;
        }

        public string GetName()
        {
            return Name;
        }

        public string GetDescription()
        {
            return Description;
        }

        public int GetSize()
        {
            return Size;
        }

        //    public string GetStats() {
        //        return "Name: " + this.getName() +
        //                "\nDamage: " + this.getDamage() +
        //                "\nSize: " + Double.toString(this.getSize());
        //    }

        public string ToStringShort()
        {
            var isVowel = false;
            if (Name != null)
            {
                switch (Name.First())
                {
                    case 'a':
                    case 'e':
                    case 'i':
                    case 'o':
                    case 'u':
                        isVowel = true;
                        break;
                }
            }
            return (isVowel ? "an " : "a ") + Name;
        }
    }
}
