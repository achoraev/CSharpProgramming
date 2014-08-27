using System;

class IsInTheCircle
{
    static void Main()
    {
        Console.WriteLine("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        int y = int.Parse(Console.ReadLine());
        int radius = 5;
        if ((x * x) + (y * y) <= (radius * radius))
        {
            Console.WriteLine("Point is in the Circle.");
        }
        else
        {
            Console.WriteLine("Point is out of the Circle.");
        }
    }
}
