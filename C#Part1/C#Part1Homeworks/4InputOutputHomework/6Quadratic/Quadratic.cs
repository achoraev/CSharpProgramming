using System;

class Quadratic
{
    static void Main()
    {
        Console.WriteLine("Enter Coeficient a: ");
        double a = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Coeficient b: ");
        double b = double.Parse(Console.ReadLine());
        Console.WriteLine("Enter Coeficient c: ");
        double c = double.Parse(Console.ReadLine());
        double equal = ((-b) + (Math.Sqrt((b*b) - (4 * a * c)))) / (2 * a);
        double equalminus = ((-b) - (Math.Sqrt((b * b) - (4 * a * c)))) / (2 * a);
        double diskrim = ((b * b) - (4 * a * c));       
        if (diskrim < 0)
            {
                Console.WriteLine(diskrim);
                Console.WriteLine("No real roots.");            
            }
            else if (diskrim == 0)
                {
                    Console.WriteLine(diskrim);    
                    Console.WriteLine("Have one real root.");
                    Console.WriteLine(equal);               
                }
                 else if (diskrim > 0)
                    {
                        Console.WriteLine(diskrim);        
                        Console.WriteLine("Have two real roots.");
                        Console.WriteLine(equal);
                        Console.WriteLine(equalminus);
                    }        
    }
}
