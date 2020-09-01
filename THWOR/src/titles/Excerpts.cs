namespace THWOR.src.titles
{
    class Excerpts
    {
        #region Java code

        //private static final String bookDescription = "" +
        //        "You reach out and gingerly grasp the faded leather spine of the book. " +
        //        "A tingle runs up your arm, making your hair stand on end. \n" +
        //        "You pull the book down and brush the dust off its well-worn cover, reading these words: \n";
        //private static final String backOfBook = "" +
        //        "Turning the novel over, you continue to read: \n";

        //private static final String mcEverTitle = "" +
        //        "\tMcEver\n" +
        //        "\tby KM\n";
        //private static final String mcEverExcerpt = "'Who am I?'\n";
        //public static final String mcEver = bookDescription + mcEverTitle +
        //        backOfBook + mcEverExcerpt;

        //private static final String legennTitle = "" +
        //        "\tThe Perilous Adventures of Jon Legenn\n" +
        //        "\tby KM\n";
        //private static final String legennExcerpt = "" +
        //        "'In my experience, there is no problem that can't be solved by a silver bullet. . . .'\n";
        //public static final String legenn = bookDescription + legennTitle +
        //        backOfBook + legennExcerpt;

        //private static final String fogartyTitle = "" +
        //        "\tThe Tragic Youth of Ambrose Fogarty\n" +
        //        "\tby KM\n";
        //private static final String fogartyExcerpt = "" +
        //        "'. . . chemist, physicist, biologist, naturalist, alchemist, mathematician, " +
        //        "and if he's not busy, something of an inventor. . . .'\n";
        //public static final String fogarty = bookDescription + fogartyTitle +
        //        backOfBook + fogartyExcerpt;

        //private static final String clocktowerTitle = "" +
        //        "\tThe Complete Clocktower Books\n" +
        //        "\tby KM and FM\n";
        //private static final String clocktowerExcerpt = "" +
        //        "'Herein lie the tales of a world born in darkness -- " +
        //        "a world which is a copy of a world, in the same way that a sketch " +
        //        "is a copy of the living thing which the artist has tried to reproduce, " +
        //        "and in which the fate of all worlds may hang in the balance. . . .'\n";
        //public static final String clocktower = bookDescription + clocktowerTitle +
        //        backOfBook + clocktowerExcerpt;

        #endregion

        private static readonly string bookDescription = "" +
            "You reach out and gingerly grasp the faded leather spine of the book. " +
            "A tingle runs up your arm, making your hair stand on end. \n" +
            "You pull the book down and brush the dust off its well-worn cover, reading these words: \n";
        private static readonly string backOfBook = "" +
            "Turning the volume over, you continue to read: \n";

        public static string Read(string title, string passage)
        {
            return bookDescription +
                   "\n" +
                   title +
                   "\n" +
                   backOfBook +
                   "\n" +
                   passage;
        }

        /**********
         * McEver *
         **********/
        private static readonly string mcEverFullTitle = "" +
            "\tMcEver, by KM";
        private static readonly string mcEverShortTitle = "" +
            "\tMcEver\n" +
            "\tby KM\n";
        private static readonly string mcEverExcerpt = "\t'Who am I?'";
        public static readonly string mcEver = Read(mcEverShortTitle, mcEverExcerpt);

        /**********
         * Legenn *
         **********/
        private static readonly string legennFullTitle = "" +
            "\tThe Perilous Adventures of Jon Legenn, by KM";
        private static readonly string legennShortTitle = "" +
            "\tThe Perilous Adventures of Jon Legenn\n" +
            "\tby KM\n";
        private static readonly string legennExcerpt = "" +
            "\t'In my experience, there is no problem that can't be solved by a silver bullet. . . .'";
        public static readonly string legenn = Read(legennShortTitle, legennExcerpt);

        /***********
         * Fogarty *
         ***********/
        private static readonly string fogartyFullTitle1 = "" +
            "\tThe Tragic Youth of Ambrose Fogarty: \n" +
                "\t\tYoung Master Fogarty, by KM";
        private static readonly string fogartyFullTitle2 = "" +
            "\tThe Tragic Youth of Ambrose Fogarty: \n" +
                "\t\tFogarty, Esquire, by KM";
        private static readonly string fogartyFullTitle3 = "" +
            "\tThe Tragic Youth of Ambrose Fogarty: \n" +
                "\t\tIn Her Majesty's Service, by KM";
        private static readonly string fogartyShortTitle = "" +
            "\tThe Tragic Youth of Ambrose Fogarty\n" +
            "\tby KM\n";
        private static readonly string fogartyExcerpt = "" +
            "\t'. . . chemist, physicist, biologist, naturalist, alchemist, mathematician, " +
            "and if he's not busy, something of an inventor. . . .'";
        public static readonly string fogarty = Read(fogartyShortTitle, fogartyExcerpt);

        /**************
         * Clocktower *
         **************/
        private static readonly string clocktowerFullTitle = "" +
                "\tThe Complete Clocktower Books, by KM and FM";
        private static readonly string clocktowerShortTitle = "" +
                "\tThe Complete Clocktower Books\n" +
                "\tby KM and FM\n";
        private static readonly string clocktowerExcerpt = "" +
                "\t'Herein lie the tales of a world born in darkness -- " +
                "a world which is a copy of a world, in the same way that a sketch " +
                "is a copy of the living thing which the artist has tried to reproduce, " +
                "and in which the fate of all worlds may hang in the balance. . . .'";
        public static readonly string clocktower = Read(clocktowerShortTitle, clocktowerExcerpt);

        /**********
         * Titles *
         **********/
        public static readonly string bookTitlesInLibrary =
            fogartyFullTitle1 + "\n" +
            fogartyFullTitle2 + "\n" +
            fogartyFullTitle3 + "\n" +
            legennFullTitle + "\n" +
            mcEverFullTitle + "\n" +
            clocktowerFullTitle;
    }
}
