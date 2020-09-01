namespace THWOR.src.items
{
    class Flashlight : ItemBase
    {
        #region Java Code

        //public Flashlight() { }


        //public String getName()
        //{
        //    return "flashlight";
        //}


        //public String getDescription()
        //{
        //    return "A large flashlight with a cracked and faded blue plastic casing.";
        //}


        //public double getSize()
        //{
        //    return 2.5;
        //}


        ////    public String getStats() {
        ////        return null;
        ////    }


        //public String toStringShort()
        //{
        //    return "a flashlight";
        //}

        #endregion

        public Flashlight(
            string name = "flashlight",
            string description = "A large flashlight with a cracked and faded blue plastic casing.",
            int size = 2)
            : base(name, description, size) { }
    }
}