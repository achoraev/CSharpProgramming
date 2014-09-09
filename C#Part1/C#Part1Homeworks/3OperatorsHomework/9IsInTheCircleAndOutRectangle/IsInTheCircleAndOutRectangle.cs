using System;

class IsInTheCircleAndOutRectangle
{
    static void Main()
    {
        Console.WriteLine("Enter X: ");
        int x = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter Y: ");
        int y = int.Parse(Console.ReadLine());
        int radius = 5;
        int circleCenterX = x - 1;
        int circleCenterY = y - 1;
        int recTopLeftX = 1;
        int recTopLeftY = -1;
        int recWidth = 6;
        int recHeight = 2;
        if (((circleCenterX * circleCenterX) + (circleCenterY * circleCenterY)) <= (radius * radius)) 
        {
            Console.WriteLine("Point is in the Circle.");
        }
        else
        {
            Console.WriteLine("Point is out of the Circle.");
        }
        if ((x >= (recTopLeftX + recWidth)) && (x <= recTopLeftX) && (y <= (recTopLeftY - recHeight)) && (y >= (recTopLeftY)))
            {
                Console.WriteLine("Point is out of the Rectangle.");
            }
            else
            {
                Console.WriteLine("Point is in Rectangle.");
            }
    }
}