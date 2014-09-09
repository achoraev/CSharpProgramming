namespace Abstraction
{
    using System;    

    internal class FiguresExample
    {
        private static void Main()
        {
            Circle circle = new Circle(5);
            Rectangle rect = new Rectangle(2, 3);

            double circlePerimeter = circle.CalcPerimeter();
            double circleSurface = circle.CalcSurface();
            double rectanglePerimeter = rect.CalcPerimeter();
            double rectangleSurface = rect.CalcSurface();
            
            Console.WriteLine("I am a circle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", circlePerimeter, circleSurface);            
            Console.WriteLine("I am a rectangle. " + "My perimeter is {0:f2}. My surface is {1:f2}.", rectanglePerimeter, rectangleSurface);
        }
    }
}