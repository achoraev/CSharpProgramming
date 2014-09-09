using System;

class TrapezoidArea
{
    static void Main()
		{
            Console.WriteLine("Enter Side A:");
            int sideA = int.Parse(Console.ReadLine());
            Console.WriteLine("Emter Side B:");
			int sideB = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height:");
			int heightH = int.Parse(Console.ReadLine());
			int area = ((sideA + sideB)/2)* heightH;
            Console.WriteLine("The Area of Trapezoid is:" + area);
		}
}
