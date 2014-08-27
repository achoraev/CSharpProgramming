using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euclidian3DSpace
{
    class Test
    {
        static void Main()
        {
            // print start point
            Console.WriteLine("Starting point: ");
            Console.WriteLine(Point3D.XYZ);
            // test Euclidian
            Point3D somePoint = new Point3D(10, 5, 7);
            Console.WriteLine(somePoint);            

            // test path
            Path pathTest = new Path();
            pathTest.AddPoint(Point3D.XYZ);
            pathTest.AddPoint(somePoint);
            // check method Print
            pathTest.PrintPath();
            // check Path storage
            PathStorage.SaveToFile(pathTest);
            pathTest.ClearPath();
            PathStorage.LoadFromFile();
            
            // check Clear
            pathTest.ClearPath();
            pathTest.PrintPath();
            // check distance
            double result = Distance.CalcDistance(Point3D.XYZ, somePoint);
            Console.WriteLine("Distance is {0:F3} ", result);
        }
    }
}
