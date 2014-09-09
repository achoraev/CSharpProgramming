namespace CohesionAndCoupling
{
    using System;

    public class UtilsExamples
    {
        public static void Main()
        {
            Console.WriteLine(Utils.GetFileExtension("example"));
            Console.WriteLine(Utils.GetFileExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileExtension("example.new.pdf"));

            Console.WriteLine(Utils.GetFileNameWithoutExtension("example"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.pdf"));
            Console.WriteLine(Utils.GetFileNameWithoutExtension("example.new.pdf"));

            Console.WriteLine("Distance in the 2D space = {0:f2}", TwoDimension.CalcDistance2D(1, -2, 3, 4));
            Console.WriteLine("Distance in the 3D space = {0:f2}", ThreeDimension.CalcDistance3D(5, 2, -1, 3, -6, 4));

            Console.WriteLine("Volume = {0:f2}", ThreeDimension.CalcVolume(9, 7, 4));
            Console.WriteLine("Diagonal XYZ = {0:f2}", ThreeDimension.CalcDiagonalXYZ(3, 4, 5));
            Console.WriteLine("Diagonal XY = {0:f2}", TwoDimension.CalcDiagonal(3, 4));
            Console.WriteLine("Diagonal XZ = {0:f2}", TwoDimension.CalcDiagonal(3, 5));
            Console.WriteLine("Diagonal YZ = {0:f2}", TwoDimension.CalcDiagonal(4, 5));
        }
    }
}