using System;
//Write methods that calculate the surface of a triangle by given:
//Side and an altitude to it; Three sides; Two sides and an angle between them. Use System.Math.

class SurfaceOfTriangle
{
    static void Main()
    {
        Surface();
    }

    private static void Surface()
    {
        Console.WriteLine("Enter your choice: ");
        Console.WriteLine("1. For Side and altitude.");
        Console.WriteLine("2. For Three sides.");
        Console.WriteLine("3. For Two sides and angle between them.");
        int choice = int.Parse(Console.ReadLine());
        switch (choice)
        {
            case 1:
                Console.WriteLine("Enter side: ");
                int side = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter altitude to it: ");
                int altitude = int.Parse(Console.ReadLine());
                SideAndAltitude(side, altitude);
                break;
            case 2:
                Console.WriteLine("Enter first side: ");
                int sideA = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second side: ");
                int sideB = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter third side: ");
                int sideC = int.Parse(Console.ReadLine());
                ThreeSide(sideA, sideB, sideC);
                break;
            case 3: 
                Console.WriteLine("Enter first side: ");
                int firstSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter second side: ");
                int secondSide = int.Parse(Console.ReadLine());
                Console.WriteLine("Enter angle between them: ");
                double angle = double.Parse(Console.ReadLine());
                TwoSidesAndAngle(firstSide,secondSide,angle);
                break;
            default: Console.WriteLine("Wrong choice!!!"); break;
        }
    }

    private static void TwoSidesAndAngle(int firstSide, int secondSide, double angle)
    {
        angle *= Math.PI / 180;
        double result = ((firstSide * secondSide) * Math.Sin(angle))/2;       
        Console.WriteLine("The surface is: {0:F4} m2", result);
    }

    private static void ThreeSide(int sideA, int sideB, int sideC)
    {
        int s = (sideA + sideB + sideC) / 2;
        double result = Math.Sqrt(s * (s - sideA) * (s - sideB) * (s - sideC));
        Console.WriteLine("The surface is: {0:F2} m2", result);
    }

    private static void SideAndAltitude(int side, int altitude)
    {
        int result = (side * altitude)/2; 
        Console.WriteLine("The surface is: {0} m2", result); 
    }
}

 