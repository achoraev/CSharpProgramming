using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TradeAndTravel
{
    public class ForestLocation : Location
    {
        public ForestLocation(string name)
            : base(name, LocationType.Forest)
        {
        }
    }
}
