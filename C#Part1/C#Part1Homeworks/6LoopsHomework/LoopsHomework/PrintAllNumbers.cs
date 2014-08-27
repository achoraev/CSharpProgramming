using System;

    class PrintAllNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter number: ");
            long number = long.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                Console.WriteLine(i);
            }
        }
    }

