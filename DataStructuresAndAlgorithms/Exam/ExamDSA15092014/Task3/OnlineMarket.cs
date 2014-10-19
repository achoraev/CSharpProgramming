namespace Task3
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    using Wintellect.PowerCollections;

    public class OnlineMarket
    {
        static MultiDictionary<string, Product> listOfProducts = new MultiDictionary<string, Product>(true);
        static SortedDictionary<string, double> listOfNames = new SortedDictionary<string, double>();
        static StringBuilder result = new StringBuilder();
        static string[] input;
        public static void Main()
        {
            while (true)
            {
                input = Console.ReadLine().Split(' ');

                if (input[0] == "end")
                {
                    break;
                }

                switch (input[0])
                {
                    case "add": AddProduct(input[1], double.Parse(input[2]), input[3]); break;
                    case "filter":
                        string command = input[2];
                        FilterProductBy(command); break;                    
                }                
            }

            Console.WriteLine(result);
                    
        }

        private static void FilterProductBy(string command)
        {
            if(command.Equals("price"))
            {
                if (input[3] == "from")
                {
                    if (input.Length <= 5)
                    {
                        FilterProductByPriceFrom(double.Parse(input[4]));
                    }
                    else
                    {
                        FilterProductByPriceFromTo(double.Parse(input[4]), double.Parse(input[6]));
                    }
                }
                else if(input[3] == "to")
                {
                    FilterProductByPriceTo(double.Parse(input[4]));
                }
            }
            else 
            {
                FilterProductByType(input[3]);
            }
        }

        private static void FilterProductByPriceFromTo(double minPrice, double maxPrice)
        {
            var filtered = listOfNames.Where(p => p.Value >= minPrice && p.Value <= maxPrice).OrderBy(p => p.Value).ThenBy(n => n.Key);
            List<string> sortedProducts = new List<string>();
            int count = 0;
            foreach (var item in filtered)
            {
                sortedProducts.Add(string.Format("{0}({1})", item.Key, item.Value));
                if (count == 11)
                {
                    break;
                }
            }

            result.Append("Ok: ");
            for (int i = 0; i < sortedProducts.Count; i++)
            {
                result.Append(sortedProducts[i]);
                if (i == 9)
                {
                    break;
                }

                if (i != sortedProducts.Count - 1)
                {
                    result.Append(", ");
                }                
            }

            result.AppendLine();
        }

        private static void FilterProductByPriceTo(double maxPrice)
        {
            var filtered = listOfNames.Where(p => p.Value < maxPrice).OrderBy(p => p.Value).ThenBy(n => n.Key);
            List<string> sortedList = new List<string>();
            int count = 0;
            foreach (var item in filtered)
            {
                sortedList.Add(string.Format("{0}({1})", item.Key, item.Value));
                if (count == 11)
                {
                    break;
                }
            }

            result.Append("Ok: ");
            for (int i = 0; i < sortedList.Count; i++)
            {
                result.Append(sortedList[i]);
                if (i == 9)
                {
                    break;
                }

                if (i != sortedList.Count - 1)
                {
                    result.Append(", ");
                }                
            }     
       
            result.AppendLine();
        }

        private static void FilterProductByType(string type)
        {
            if (listOfProducts.ContainsKey(type))
            {
                var types = listOfProducts.FindAll(x => x.Key == type);

                List<string> sortedTypes = new List<string>();
                int count = 0;
                result.Append("Ok: ");

                foreach (var item in types)
                {
                    foreach (var value in item.Value.OrderBy(p => p.Price).ThenBy(n => n.Name).ThenBy(t => t.Type))
                    {
                        sortedTypes.Add(string.Format("{0}({1})", value.Name, value.Price));
                        if (count == 11)
                        {
                            break;
                        }
                    }
                }

                for (int i = 0; i < sortedTypes.Count; i++)
                {
                    result.Append(sortedTypes[i]);
                    if (i == 9)
                    {
                        break;
                    }

                    if (i != sortedTypes.Count - 1)
                    {
                        result.Append(", ");
                    }                    
                }  
   
                result.AppendLine();
            }
            else
            {
                result.AppendLine("Error: Type "+ type + " does not exists");
            }
        }

        private static void FilterProductByPriceFrom(double minPrice)
        {
            var filtered = listOfNames.Where(p => p.Value >= minPrice).OrderBy(p => p.Value).ThenBy(n => n.Key);
            List<string> sortedProducts = new List<string>();
            int count = 0;
            foreach (var item in filtered)
            {
                sortedProducts.Add(string.Format("{0}({1})", item.Key, item.Value));
                if (count == 11)
                {
                    break;
                }
            }

            result.Append("Ok: ");
            for (int i = 0; i < sortedProducts.Count; i++)
            {
                result.Append(sortedProducts[i]);
                if (i == 9)
                {
                    break;
                }

                if (i != sortedProducts.Count -1)
                {
                    result.Append(", ");
                }                
            }

            result.AppendLine();
        }

        private static void AddProduct(string name, double price, string type)
        {           
            var product = new Product(name, price, type)
            {
                Name = name,
                Price = price,
                Type = type
            };
            if (listOfNames.ContainsKey(product.Name))
            {
                result.AppendLine("Error: Product " + product.Name + " already exists");
            }
            else
            {
                listOfProducts.Add(product.Type, product);
                listOfNames.Add(product.Name, product.Price);
                result.AppendLine("Ok: Product " + product.Name + " added successfully");
            }
        }

        public class Product
        {
            public Product(string name, double price, string type)
            {
                this.Name = name;
                this.Price = price;
                this.Type = type;
            }

            public string Name { get; set; }

            public double Price { get; set; }

            public string Type { get; set; }
            
        }
    }
}