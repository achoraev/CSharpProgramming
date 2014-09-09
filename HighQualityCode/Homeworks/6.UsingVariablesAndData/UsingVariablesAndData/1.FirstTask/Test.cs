namespace FirstTask
{
    using System;
    
    public class Program
    {
        public static void Main()
        {
            double width = 12.5;
            double height = 15.5;            
           
            Size triangle = new Size(width, height);
            Console.WriteLine(triangle.GetRotatedSize(triangle, 30));
        }
    }
}