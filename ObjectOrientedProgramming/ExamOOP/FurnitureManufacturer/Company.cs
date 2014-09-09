namespace FurnitureManufacturer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using FurnitureManufacturer.Interfaces;

    public class Company : ICompany
    {
        private string name;
        private string registrationNumber;
        private ICollection<IFurniture> furnitures;

        public Company(string name, string registrationNumber)
        {
            this.Name = name;
            this.RegistrationNumber = registrationNumber;
            this.furnitures = new List<IFurniture>();
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (string.IsNullOrEmpty(value) || value.Length < 5)
                {
                    throw new ArgumentNullException("Company name cannot be null or less than 5 letters!!!");
                }
                this.name = value;
            }
        }

        public string RegistrationNumber
        {
            get 
            {
                return this.registrationNumber;
            }
            private set
            {
                if (value.Length == 10)
                {                    
                    this.registrationNumber = value;
                }
                else
                {
                    throw new ArgumentException("Registration number must contain only digits!!!");
                }                
            }
        }

        public ICollection<IFurniture> Furnitures
        {
            get
            {
                return new List<IFurniture>();
            }           
        }

        public void Add(IFurniture furniture)
        {
            this.furnitures.Add(furniture);
        }

        public void Remove(IFurniture furniture)
        {
            furnitures = furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model).ToList();
            this.furnitures.Remove(furniture);      
        }
        
        public IFurniture Find(string model) 
        {
            IFurniture result = furnitures.FirstOrDefault((f => f.Model == model));            
            return result;            
        }

        public string Catalog()
        {
            var catalog = new StringBuilder();
            catalog.AppendLine(string.Format("{0} - {1} - {2} {3}", 
                this.Name,
                this.RegistrationNumber,
                this.furnitures.Count != 0 ? this.furnitures.Count.ToString() : "no",
                this.furnitures.Count != 1 ? "furnitures" : "furniture"));
            var sorted = furnitures.OrderBy(f => f.Price).ThenBy(f => f.Model);
            foreach (var furniture in sorted)
            {
                catalog.AppendLine(furniture.ToString());
            }
            return catalog.ToString().TrimEnd();
        }
    }
}
