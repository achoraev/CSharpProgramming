using System;

class DivisionByFive
{
    static void Main()
    {
        Console.WriteLine("First number:");
        int first = int.Parse(Console.ReadLine());
        Console.WriteLine("Second number (larger than first):");
        int second = int.Parse(Console.ReadLine());
        int sum = 0;
        for (int i = first; i <= second; i++)
        {
            if ((i % 5) == 0)
            {
                sum++;           
            }
        }
        Console.WriteLine(sum);
    }
}