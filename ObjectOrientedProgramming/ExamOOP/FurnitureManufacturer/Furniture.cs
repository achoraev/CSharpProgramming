namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;
    using System.Threading;

    public class Furniture : IFurniture
    {
        private string model;
        private string material;
        private decimal price;
        private decimal height;        

        public Furniture(string model, string material, decimal price, decimal height)
        {
            this.Model = model;
            this.Material = material;
            this.Price = price; 
            this.Height = height;
        }

        public string Model             
        {
            get
            {
                return this.model;
            }
            protected set 
            {
                if (string.IsNullOrEmpty(value) || value.Length < 3)
                {
                    throw new ArgumentNullException("Model name cannot be null or less than 3 letters!!!");
                }
                this.model = value;
            }
        }

        public string Material
        {
            get
            {
                return this.material;
            }
            protected set
            {                 
                this.material = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }
            set
            {
                if (value <= 0.00m)
                {
                    throw new ArgumentNullException("Price cannot be null or negative!!!");
                }
                this.price = value;
            }
        }

        public decimal Height
        {
            get
            {
                return this.height;
            }
            protected set
            {
                if (value <= 0)
                {
                    throw new ArgumentNullException("Height cannot be null or negative!!!");
                }
                this.height = value;
            }
        }

        public override string ToString()
        {
            var result = new StringBuilder();
            result.Append(string.Format("Type: {0}, Model: {1}, Material: {2}, Price: {3}, Height: {4}", this.GetType().Name, this.Model, this.Material, this.Price, this.Height));
            return result.ToString().TrimEnd();
        }
    }
}
