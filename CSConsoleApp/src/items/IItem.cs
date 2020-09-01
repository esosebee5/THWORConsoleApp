namespace CSConsoleApp.src.items
{
    interface IItem
    {
        #region Java Code

        //   /**
        //* Get the item's name
        //* @return item's identifying name
        //*/
        //   String getName();

        //   /**
        //    *
        //    * @return item's unique description
        //    */
        //   String getDescription();

        //   /**
        //    *
        //    * @return get inventory size of the item
        //    */
        //   double getSize();

        //   /**
        //    *
        //    * @return the item's stats
        //    */
        //   //    String getStats();

        //   /**
        //    *
        //    * @return short identifying string
        //    */
        //   String toStringShort();

        #endregion

        /// <summary>
        /// Get the item's name
        /// </summary>
        /// <returns>item's identifying name</returns>
        string GetName();

        /// <summary>
        /// Get item's unique description
        /// </summary>
        /// <returns></returns>
        string GetDescription();

        /// <summary>
        /// Get inventory size of the item
        /// </summary>
        /// <returns></returns>
        int GetSize();

        //   /**
        //    *
        //    * @return the item's stats
        //    */
        //   //    string getStats();

        /// <summary>
        /// Get item's short identifying string
        /// </summary>
        /// <returns></returns>
        string ToStringShort();
    }
}
