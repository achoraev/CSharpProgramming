using System;

class OddOrEven
{
    static void Main()
    {
        for (int i = 0; i < 10; i++)
        {
            Console.WriteLine("Enter odd or even number:");
            int number = int.Parse(Console.ReadLine());
            Console.WriteLine((number % 2 == 0) ? "EVEN" : "ODD");
        }
    }
}
