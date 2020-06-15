using CSConsoleApp.src.rooms;
using System;
using System.Collections.Generic;
using System.Text;

namespace CSConsoleApp.src.core.models.rooms
{
    class Library : IRoom
    {
        #region Java code

        //    //    private final Door[] doors = {new Door(RoomId.STUDY.getId(),
        //    //            "\nStraight ahead in the distance, you see a wooden door.",
        //    //            new String[]{"straight", "ahead", "forward", "forwards"})};

        //    private static final int id = RoomId.LIBRARY.getId();
        //    private static final String name = "Library";
        //private final int neighbor = RoomId.STUDY.getId();
        //    private SimpleMonster monster;
        //    private final String description = RoomDescriptions.library;
        //private final String firstSearchDescription =
        //        RoomDescriptions.libraryFirstSearch;
        //private boolean hasBeenSearched;



        //    public Library()
        //    {
        //        this.hasBeenSearched = false;
        //        this.addItemToItems(new Flashlight());
        //        this.addItemToItems(new Knife());
        //        //        this.items.add(eItem.MATCHES);
        //        this.monster = new SimpleMonster("gremlin", 50, 5, "blade");
        //        if (admin)
        //        {
        //            this.addItemToItems(new Excalibur());
        //        }
        //    }

        //    /***********************
        //     * Getters and setters *
        //     ***********************/

        //    public int getId()
        //    {
        //        return id;
        //    }

        //    public String getName()
        //    {
        //        return name;
        //    }

        //    public String getDescription()
        //    {
        //        String retVal = description;
        //        //        for (Door door : doors) {
        //        //            retVal += door.getDescription();
        //        //        }
        //        if (monster != null)
        //        {
        //            if (monster.isDead())
        //            {
        //                retVal += "\nThere is a dead " + monster.getName() + " here.";
        //            }
        //            else
        //            {
        //                retVal += "\nThere is " + monster.getNameLong() + " here.";
        //            }
        //        }
        //        return retVal;
        //    }

        //    public SimpleMonster getMonster()
        //    {
        //        return this.monster;
        //    }

        //    /******************
        //     * Search methods *
        //     ******************/
        //    private String search()
        //    {
        //        ArrayList<iItem> itemsInRoom = this.getItems();
        //        if (itemsInRoom.isEmpty())
        //        {
        //            return "There are no items to be found here.";
        //        }
        //        if (!this.hasBeenSearched)
        //        {
        //            this.hasBeenSearched = true;
        //            return Shared.appendDescriptionToItemsString(
        //                    this.firstSearchDescription, itemsInRoom);
        //        }

        //        return Shared.appendDescriptionToItemsString(
        //                    RoomDescriptions.defaultSearchDescription, itemsInRoom);
        //    }

        //    /******************
        //     * Custom methods *
        //     ******************/
        //    public void performCustomMethods(
        //            String[] inputs)
        //    {
        //        switch (inputs[0])
        //        {
        //            case "b":
        //            case "browse":
        //                LibraryBookshelfAdventure.browseLibrary();
        //                break;
        //            case "r":
        //            case "read":
        //                break;
        //            case "s":
        //            case "search":
        //                output(this.search());
        //                break;
        //            default:
        //                output(GameStrings.PerformCustomMethodsBadInput);
        //        }
        //    }

        //    /*****************
        //     *    MOVEMENT   *
        //     *****************/
        //    public int go(String direction)
        //    {
        //        switch (direction)
        //        {
        //            case "ahead":
        //            case "forward":
        //            case "forwards":
        //            case "straight":
        //                return this.neighbor;
        //            default:
        //                return -1;
        //        }
        //    }

        //    /******************
        //     *    Attacking   *
        //     ******************/
        //    //    public void attack() {
        //    //        // First, check if there is a monster to fight
        //    //        if (monster == null) {
        //    //            output(GameStrings.NothingToAttackHereString);
        //    //            return;
        //    //        } else if (monster.isDead()) {
        //    //            output("The " + monster.getName() + " is dead.");
        //    //        } else {
        //    //            // If a monster exists, attack it
        //    //            Shared.attack(monster);
        //    //            if (monster.isDead()) {
        //    //                output("You have slain the " + monster.getName() + ".");
        //    //            } else {
        //    //                // If the monster is still alive, defend against its attack:
        //    //                Shared.defend(monster);
        //    //                if (Game.player.isDead()) {
        //    //                    Game.state = false;
        //    //                    output(Game.player.death);
        //    //                }
        //    //            }
        //    //        }
        //    //    }

        #endregion

        #region Properties

        /**************
         * PROPERTIES *
         **************/

        private bool HasBeenSearched = false;
        private List<int> Items;

        #endregion

        /***************
         * CONSTRUCTOR *
         ***************/
        public Library()
        {
            Items = new List<int>();
            Items.Add(1);
            Items.Add(2);
        }

        #region Room Info

        /********
         * INFO *
         ********/

        public RoomId GetId()
        {
            return RoomId.Library;
        }

        public string GetName()
        {
            return "Library";
        }

        public string GetDescription()
        {
            return RoomDescriptions.Library;
        }

        #endregion

        #region Inventory Methods

        /*************
         * INVENTORY * 
         *************/

        public List<int> GetItems()
        {
            // TODO: refactor this to be smooth
            // TODO: refactor this to use items
            List<int> copy = new List<int>();
            foreach (int item in Items)
            {
                copy.Add(item);
            }
            return copy;
        }

        public bool AddItem(int item)
        {
            bool success = false;
            // TODO: validate incoming item
            if (Items == null) Items = new List<int>();
            Items.Add(item);
            success = true;
            return success;
        }

        public bool RemoveItem(int item)
        {
            bool success = false;
            // TODO: validate incoming item
            // search for item to remove
            // remove the item
            Items.Remove(item);
            success = true;
            return success;
        }

        public string Search(string objectName = null)
        {
            string searchResults = "There are no items to be found here."; // TODO: place this in strings class?
            if (Items != null && Items.Count > 0)
            {
                if (HasBeenSearched == true)
                {
                    searchResults = "You have already searched here, dummy."; //TODO: fix this
                }
                else
                {
                    HasBeenSearched = true;
                    searchResults = "";
                    foreach (int item in Items)
                    {
                        searchResults += item.ToString();
                    }
                    searchResults.Trim();
                    searchResults += ".";
                }
            }
            //        ArrayList<iItem> itemsInRoom = this.getItems();
            //        if (itemsInRoom.isEmpty())
            //        {
            //            return "There are no items to be found here.";
            //        }
            //        if (!this.hasBeenSearched)
            //        {
            //            this.hasBeenSearched = true;
            //            return Shared.appendDescriptionToItemsString(
            //                    this.firstSearchDescription, itemsInRoom);
            //        }

            //        return Shared.appendDescriptionToItemsString(
            //                    RoomDescriptions.defaultSearchDescription, itemsInRoom);
            return searchResults;
        }

        #endregion

        #region Navigation

        /**************
         * NAVIGATION *
         **************/

        public bool CanLeave()
        {
            throw new NotImplementedException();
        }

        public int Go(string direction)
        {
            throw new NotImplementedException();
        }

        #endregion

        #region CustomMethods

        public void PerformCustomMethods(string[] inputs)
        {
            throw new NotImplementedException();
        }

        #endregion
    }
}
