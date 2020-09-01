using THWOR.src.items;
using System.Collections.Generic;

namespace THWOR.src.core.services
{
    class InventoryService
    {

        public static string ConvertItemsInListToString(List<IItem> items)
        {
            if (items == null)
            {
                return "";
            }
            string stringOfItems = "";
            int len = items.Count;
            int count = 1;
            foreach (IItem item in items)
            {
                stringOfItems = stringOfItems + item.ToStringShort();
                if (count == len)
                {
                    stringOfItems += ".";
                }
                else if (count == len - 1)
                {
                    stringOfItems += " and ";
                }
                else
                {
                    stringOfItems += ", ";
                }
                count++;
            }
            return stringOfItems;
        }

        public static string AppendDescriptionToItemsString(string description, List<IItem> items)
        {
            string stringOfItems = ConvertItemsInListToString(items);
            string returnValue = description + stringOfItems;
            return returnValue;
        }

        public static IItem SearchForItemInListByName(
            string itemName,
            List<IItem> listOfItems)
        {
            foreach (IItem item in listOfItems)
            {
                if (item != null && item.GetName().ToLower().Equals(itemName))
                {
                    return item;
                }
            }
            return null;
        }
    }
}
