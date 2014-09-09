using System;

    class CalculateNNumbers
    {
        static void Main()
        {
            Console.WriteLine("Enter Number between 0 and 20: ");
            int num = int.Parse(Console.ReadLine());
            ulong sum = 0;
            for (int i = 0; i < num; i++)
            {
                Console.WriteLine("Enter Number: ");
                ulong numbers = ulong.Parse(Console.ReadLine());
                sum += numbers;                
            }
            Console.WriteLine("The sum of the {0} numbers is: {1} ", num, sum);
        }
    }

