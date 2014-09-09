using System;
using System.Collections.Generic;

namespace Euclidian3DSpace
{
	public class Path
	{
		//field
        private readonly List<Point3D> points = new List<Point3D>();
        //construktor
        public Path()		    
		{            	
		}

        //property
        public List<Point3D> Points
        {
            get { return this.points; }            
        }
        //methods
		public void AddPoint (Point3D point)
		{
			this.Points.Add(point);		
		}
		
		public void ClearPath ()
		{
			this.Points.Clear();		
		}
		
		public void PrintPath()
		{
            if (Points.Count > 0)
            {
                foreach (var point in Points)
                {
                    Console.WriteLine("({0}, {1}, {2})", point.XCoord, point.YCoord, point.ZCoord);
                } 
            }
            else
            {
                Console.WriteLine("Path is empty.");
            }
		}		
	}
}
	