using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class MineLocation : Location
    {
        public MineLocation(string name)
            : base(name, LocationType.Mine)
        {
        }
    }
}
