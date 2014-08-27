using System;

class CirclePerimeterAndArea
{
    static void Main()
    {
        Console.WriteLine("Enter radius:");
        byte radius = byte.Parse(Console.ReadLine());
        double perimeter = (Math.PI * radius * 2);
        double area = (Math.PI * radius * radius);
        Console.WriteLine("The perimeter is: {0:F4} and area is:  {1}", perimeter, area);
    }
}
