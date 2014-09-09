using System;

    class Carpets
    {
        static void Main()
        {
            Console.WriteLine("Enter number between 6 and 80: ");
            int size = int.Parse(Console.ReadLine());
            int midSize = size / 2;             
            for (int i = 1; i < size; i++)
            {
                string outSize = new string('.', (midSize - i));
                Console.WriteLine(outSize + "" + outSize); 
            }
            
        }
    }

