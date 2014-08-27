namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class Chair : Furniture,IFurniture, IChair
    {
        private int numberOfLegs;

        public Chair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base (model, materialType, price, height)
        {
            this.NumberOfLegs = numberOfLegs;
        }

        public int NumberOfLegs
        {
            get
            {
                return this.numberOfLegs;
            }
            protected set
            {
                this.numberOfLegs = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format(", Legs: {0}", this.NumberOfLegs));
            result.AppendLine();
            return result.ToString().TrimEnd();
        }
    }
}
