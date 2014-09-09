using System;

namespace Euclidian3DSpace
{
	static class Distance
	{
        public static double CalcDistance(Point3D p1, Point3D p2)
        {
            return Math.Sqrt(
            (p1.XCoord - p2.XCoord) * (p1.XCoord - p2.XCoord) +
            (p1.YCoord - p2.YCoord) * (p1.YCoord - p2.YCoord) +
            (p1.ZCoord - p2.ZCoord) * (p1.ZCoord - p2.ZCoord));            
        }		
	}
}
	