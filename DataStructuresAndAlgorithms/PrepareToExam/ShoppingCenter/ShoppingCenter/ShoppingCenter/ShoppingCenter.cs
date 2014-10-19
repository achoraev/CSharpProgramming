namespace ShoppingCenter
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class ShoppingCenter
    {
        static IDictionary<Product, decimal> dictOfProduct = new Dictionary<Product, decimal>();
        static IDictionary<string, int> listOfProducts = new Dictionary<string, int>();
        static StringBuilder result = new StringBuilder();
        static string[] stringAfterCommand;        

        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            
            for (int i = 0; i < N; i++)
			{			 
                string[] input = Console.ReadLine().Split(';');

                stringAfterCommand = input[0].Split(' ');

                switch (stringAfterCommand[0])
                {
                    case "AddProduct":
                        string name = ExtractNameFromInput(input);
                        AddProduct(new Product(name, decimal.Parse(input[1]), input[2])); break;
                    case "FindProductsByName":
                        string nameToFind = string.Join("", stringAfterCommand, 1, stringAfterCommand.Length-1);
                        FindProductsByName(nameToFind); break;
                    //case "DeleteProducts": break;
                    //case "FindProductsByPriceRange": break;
                    //case "FindProductsByProducer": break;                       
                }
                
            }

            Console.WriteLine(result);           
        }

        private static string ExtractNameFromInput(string[] input)
        {
            string name = stringAfterCommand[1];

            for (int j = 2; j < stringAfterCommand.Length; j++)
            {
                if (j < stringAfterCommand.Length)
                {
                    name += stringAfterCommand[j];
                }                        
            }
            return name;
        }

        private static void InsertPeople(int position, string name)
        {
            
        }

        private static void FindProductsByName(string name)
        {
            if (listOfProducts.ContainsKey(name))
            {
                foreach (var item in listOfProducts)
                {
                    result.AppendLine(item.Key);
                }
            }
            else
            {
                result.AppendLine("No products found");
            }
        }

        private static void FindProductsByPriceRange(int count)
        {
            
        }

        private static void AddProduct(Product  product)
        {
            dictOfProduct.Add(product, product.Price);
            listOfProducts.Add(product.Name, 1);
            result.AppendLine("Product added");
        }
    }

    public class Product: IComparable
    {
        public Product (string name, decimal price, string producer)
	{
            this.Name = name;
            this.Price = price;
            this.Producer = producer;
	}

        public string Name { get; set; }

        public decimal Price { get; set; }

        public string Producer { get; set; }

        public int CompareTo(object obj)
        {
            throw new NotImplementedException();
        }

        //public override string ToString()
        //{
        //    return string.Format("{0};{1};{2}", product.Name, product.Producer, product.Price);
        //}
    }
}