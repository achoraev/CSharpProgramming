using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class Wood : Item
    {
        const int GeneralWoodValue = 2;

        public Wood(string name, Location location = null)
            : base(name, Wood.GeneralWoodValue, ItemType.Wood, location)
        {
        }
		// TODO if dropped decrease with 1 to 0
        static List<ItemType> GetComposingItems()
        {
            return new List<ItemType>() { ItemType.Wood };
        }
    }
}
