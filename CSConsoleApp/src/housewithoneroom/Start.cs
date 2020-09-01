namespace CSConsoleApp.src.housewithoneroom
{
    class Start
    {
        #region Java code

        ////    public static boolean admin = false;
        //public static boolean admin = true;

        ///**
        // * @param args the command line arguments
        // */
        //public static void main(String[] args)
        //{
        //    // ES TEST: create test file
        //    try
        //    {
        //        if (FileWriterExperimental.createFile())
        //        {
        //            output("Test File Created.");
        //        }
        //        else
        //        {
        //            output("Test File Already Exists");
        //        }
        //    }
        //    catch (IOException e)
        //    {
        //        output("Error creating Test File: " + e);
        //    }

        //    // Initialize a new game
        //    Game.NewGame();

        //    // Print welcome dialogues.
        //    //        output(GameStrings.getTitleInBigWords());
        //    //        outputLn();
        //    output(GameStrings.getHouse());
        //    output(GameStrings.getWelcome());
        //    outputLn();

        //    // Initialize the player.
        //    initializePlayer();

        //    if (admin)
        //    {
        //        // Allow to start in a particular room
        //        int roomNum = getStartingRoom();
        //        if (roomNum >= Game.house.getCorridor().size())
        //        {
        //            roomNum = 0;
        //        }
        //        Game.currentRoom = Game.house.getCorridor().get(roomNum);
        //        output("You are starting in the "
        //                + Game.currentRoom.getName() + ".");
        //        outputLn();
        //    }
        //    else
        //    {
        //        Game.currentRoom = Game.house.getCorridor().getFirst();
        //    }


        //    // Herein lies the major flow of the game
        //    while (Game.state)
        //    {
        //        // Instruct the user
        //        outputForInput("> ");

        //        // Collect and filter user commands
        //        String info = IOService.getNextLine();
        //        String[] commands = splitAndSanitizeInput(info);
        //        outputLn();

        //        // Process user commands
        //        parseInput(commands);
        //        outputLn();
        //    }
        //}

        ///**
        // * Gets the starting room number from the user
        // * @return the player object
        // */
        //private static int getStartingRoom()
        //{
        //    int retVal = -1;
        //    String in;
        //    while (retVal < 0)
        //    {
        //        output("Enter starting room number: ");
        //    in = IOService.getNextLine();
        //        try
        //        {
        //            retVal = Integer.parseInt(in);
        //        }
        //        catch (Exception e)
        //        {
        //            output("You must enter an integer.\n");
        //        }
        //    }

        //    return retVal;
        //}

        ///**
        // * Takes the user input and applies the appropriate method
        // * @param commands - array of inputs from the user
        // */
        //private static void parseInput(String[] commands)
        //{
        //    String verb = commands[0];
        //    switch (verb)
        //    {
        //        //////////
        //        // ROOM //
        //        //////////
        //        case "a":
        //        case "attack":
        //            tryToAttack();
        //            break;
        //        case "c":
        //        case "character":
        //            output(Game.player.showCharacterReport());
        //            break;
        //        //////////
        //        // ROOM //
        //        //////////
        //        case "desc":
        //        case "describe":
        //        case "description":
        //            output(Game.currentRoom.getDescription());
        //            break;
        //        case "d":
        //        case "drop":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try including an item after 'drop'.");
        //            }
        //            else
        //            {
        //                tryDroppingItem(commands[1]);
        //            }
        //            break;
        //        case "e":
        //        case "equip":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try including an item after 'equip'.");
        //            }
        //            else
        //            {
        //                tryEquippingItem(commands[1]);
        //            }
        //            break;
        //        case "exit":
        //        case "x":
        //            Game.exitGame();
        //            break;
        //        //////////?????????????
        //        // ROOM //?????????????
        //        //////////?????????????
        //        case "g":
        //        case "go":
        //        case "move":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try including a direction after 'go'.");
        //            }
        //            else
        //            {
        //                tryGoing(commands[1]);
        //            }
        //            break;
        //        case "h":
        //        case "help":
        //            showHelpDialogue();
        //            break;
        //        case "i":
        //        case "inventory":
        //            output(Game.player.showInventory());
        //            break;
        //        case "load":
        //            tryLoadingPlayer();
        //            break;
        //        case "pocket":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try including an equipped item after 'pocket'.");
        //            }
        //            else
        //            {
        //                tryPocketingItem(commands[1]);
        //            }
        //            break;
        //        //////////
        //        // ROOM //
        //        //////////
        //        //            case "ra":
        //        //                Game.currentRoom.roomActions();
        //        //                break;
        //        //            case "stats":
        //        //                if (!validateNoun(commands)) {
        //        //                    output("Try including an item from your inventory \n"
        //        //                            + "after 'stats'.");
        //        //                } else {
        //        //                    showItemStats(commands[1]);
        //        //                }
        //        //                break;
        //        case "save":
        //            trySavingPlayer();
        //            break;
        //        case "t":
        //        case "get":
        //        case "take":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try including an item after 'take'.");
        //            }
        //            else
        //            {
        //                tryTakingItem(commands[1]);
        //            }
        //            break;
        //        case "view":
        //        case "v":
        //            if (!validateNoun(commands))
        //            {
        //                output("Try adding an item name from your inventory \n"
        //                        + "after 'view'.");
        //            }
        //            else
        //            {
        //                tryViewingItem(commands[1]);
        //            }
        //            break;
        //        //////////
        //        // ROOM //
        //        //////////
        //        default:
        //            passCommandsToCurrentRoom(commands);
        //    }
        //}

        ///**
        // * Passes the user input array and the current player into the room
        // * to perform room-specific actions
        // * @param inputs the commands
        // */
        //private static void passCommandsToCurrentRoom(String[] inputs)
        //{
        //    Game.currentRoom.performCustomMethods(inputs);
        //}

        //private static void tryTakingItem(String itemName)
        //{
        //    ArrayList<iItem> itemsInRoom = Game.currentRoom.getItems();
        //    if (itemsInRoom == null)
        //    {
        //        output("You don't see any items.");
        //    }
        //    else
        //    {
        //        for (iItem item : itemsInRoom)
        //        {
        //            if (item.getName().equals(itemName))
        //            {

        //                // remove the item from the room if taken by player
        //                if (Game.player.takeItem(item))
        //                {
        //                    Game.currentRoom.removeItemFromItems(item);
        //                    return;
        //                }
        //                return;
        //            }
        //        }
        //    }
        //    output("No item of that name is available.");
        //}

        //private static void tryDroppingItem(String itemName)
        //{
        //    // try to drop from inventory
        //    iItem droppedItem = Game.player.dropItem(itemName);
        //    if (droppedItem != null)
        //    {
        //        // print result of action
        //        output("You dropped the " + itemName + ".");

        //        // then add back to current room
        //        Game.currentRoom.addItemToItems(droppedItem);
        //    }
        //    else
        //    {
        //        output(GameStrings.NotInInventory);
        //    }
        //}

        //private static void tryViewingItem(String itemName)
        //{
        //    iItem item = Shared.searchForItemInListByName(
        //            itemName, Game.player.getInventory());
        //    if (item == null)
        //    {
        //        item = Shared.searchForItemInListByName(itemName, Game.player.getItemsInHands());
        //    }
        //    if (item != null)
        //    {
        //        output(item.getDescription());
        //    }
        //    else
        //    {
        //        output(GameStrings.NotInInventory);
        //    }
        //}

        //private static void tryToAttack()
        //{
        //    Game.currentRoom.attack();
        //}

        //private static void tryEquippingItem(String itemName)
        //{
        //    iItem item = Shared.searchForItemInListByName(
        //            itemName, Game.player.getInventory());
        //    if (item != null)
        //    {
        //        output(Game.player.equip(item));
        //    }
        //    else
        //    {
        //        output(GameStrings.NotInInventory);
        //    }
        //}

        //private static void tryPocketingItem(String itemName)
        //{
        //    Game.player.pocket(itemName);
        //}

        ///**
        // * ES TEST: write player object
        // */
        //private static void trySavingPlayer()
        //{
        //    try
        //    {
        //        FileWriterExperimental.writePlayerJson();
        //        output("Save successful (no exceptions thrown).");
        //    }
        //    catch (IOException e)
        //    {
        //        output("Error creating Test File: " + e);
        //    }
        //}

        ///**
        // * ES TEST: read saved player & assign to current player
        // */
        //private static void tryLoadingPlayer()
        //{
        //    try
        //    {
        //        boolean success = FileWriterExperimental.readPlayerJson();

        //        if (success)
        //        {
        //            output("Well, look at that.");
        //        }
        //    }
        //    catch (FileNotFoundException e)
        //    {
        //        output("Error reading/loading saved player data: " + e);
        //    }
        //}






        //// TODO: this method needs some work before implementing
        ////    private static void showItemStats(String command) {
        ////        iItem item = Shared.searchForItemInListByName(
        ////                command, Game.player.getInventory());
        ////        if (item != null) {
        ////            output(item.getStats());
        ////        } else {
        ////            output(GameStrings.NotInInventory);
        ////        }
        ////    }

        #endregion
    }
}
