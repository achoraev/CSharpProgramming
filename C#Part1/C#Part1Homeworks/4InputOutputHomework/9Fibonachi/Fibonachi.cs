using System;

    class Fibonachi
    {
        static void Main()
        {
            ulong first = 0;
            ulong second = 1;
            ulong third = first + second;
            Console.WriteLine(first);
            Console.WriteLine(second);
            Console.WriteLine(third);           
            for (int i = 3; i <= 98; i++)
            {
                first = second;
                second = third;
                third = first + second;
                Console.WriteLine(third);
            }
        }
    }

