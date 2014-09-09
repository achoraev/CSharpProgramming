namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class Table : Furniture, IFurniture, ITable
    {
        private decimal length;
        private decimal width;        

        public Table(string model, string material, decimal price, decimal height, decimal length, decimal width)   
            : base (model, material, price, height)
        {
            this.Length = length;
            this.Width = width;            
        }

        public decimal Length
        {
            get
            {
                return this.length;
            }
            protected set
            {
                this.length = value;
            }
        }

        public decimal Width
        {
            get 
            {
                return this.width;
            }
            protected set
            {
                this.width = value;
            }
        }

        public decimal Area
        {
            get { return ((decimal)this.Length * this.Width); }            
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(base.ToString());
            result.Append(string.Format(", Length: {0}, Width: {1}, Area: {2:F4}", this.Length, this.Width, this.Area));
            result.AppendLine();
            return result.ToString().TrimEnd();
        }
    }
}
