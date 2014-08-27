using System;

    class DivisibleTo3And7
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            long number = long.Parse(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (i % 3 != 0&& i % 7 != 0)
                {
                    Console.WriteLine(i);
                }                
            }
        }
    }

