using System;

    class RectangleArea
    {
        static void Main()
        {
            Console.WriteLine("Enter Width:");
            int width = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter Height:");
            int height = int.Parse(Console.ReadLine());
            int area = width * height;
            Console.WriteLine("Area is: " + area);
        }
    }

