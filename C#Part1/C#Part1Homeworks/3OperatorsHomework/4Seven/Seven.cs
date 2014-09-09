using System;

    class Seven
    {
        static void Main()
        {
            Console.WriteLine("Enter Number from:");
            int inputNumber = int.Parse(Console.ReadLine());
            Console.WriteLine(((inputNumber / 100) % 10) == 7);
        }
    }
