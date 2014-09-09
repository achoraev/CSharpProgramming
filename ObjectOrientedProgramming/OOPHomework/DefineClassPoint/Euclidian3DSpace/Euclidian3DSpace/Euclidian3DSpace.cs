using System;
namespace Euclidian3DSpace
{
	public struct Point3D
	{
		//fields
		private int xCoord;
		private int yCoord;
		private int zCoord;
		
		private static readonly Point3D xyz = new Point3D(0,0,0);
		//construktor
		public Point3D (int xCoord, int yCoord, int zCoord)
		:this()
		{	
			this.xCoord = xCoord;
			this.yCoord = yCoord;
			this.zCoord = zCoord;
		}
		//properties
		public int XCoord 
		{
			get {return this.xCoord;}
			set {this.xCoord = value;}		
		}
		public int YCoord 
		{
			get {return this.yCoord;}
			set {this.yCoord = value;}		
		}
		public int ZCoord 
		{
			get {return this.zCoord;}
			set {this.zCoord = value;}		
		}
		public static Point3D XYZ 
		{
			get {return xyz;}
				
		}
		//override ToString
		public override string ToString()
		{			
			return String.Format("{0} {1} {2}", this.xCoord, this.yCoord, this.zCoord);
		}
	}
}
	