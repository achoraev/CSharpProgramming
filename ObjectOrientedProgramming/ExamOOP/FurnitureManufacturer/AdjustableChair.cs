namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class AdjustableChair : Chair, IFurniture, IChair, IAdjustableChair
    {
        public AdjustableChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model,materialType, price, height , numberOfLegs)
        {
            
        }

        public void SetHeight(decimal height)
        {
            this.Height = height;
        }
    }
}
