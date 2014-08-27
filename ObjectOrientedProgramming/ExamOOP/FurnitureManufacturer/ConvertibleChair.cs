namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class ConvertibleChair : Chair, IFurniture, IChair, IConvertibleChair
    {
        private bool isConverted;
        private const decimal convertedHeight = 0.10m;
        private decimal oldValue;

        public ConvertibleChair(string model, string materialType, decimal price, decimal height, int numberOfLegs)
            : base(model, materialType, price, height, numberOfLegs) 
        {
            this.isConverted = !isConverted;
            oldValue = this.Height;
        }

        public bool IsConverted
        {
            get { return isConverted; }            
        }
        
        public void Convert() // check
        {            
            if (isConverted)
            {                
                this.Height = convertedHeight;
                isConverted = false;
            }
            else
            {
                this.Height = oldValue;
                isConverted = true;
            }              
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format(", State: {0}", this.IsConverted ? "Normal" : "Converted"));
            result.AppendLine();
            return result.ToString().TrimEnd();
        }
    }
}
