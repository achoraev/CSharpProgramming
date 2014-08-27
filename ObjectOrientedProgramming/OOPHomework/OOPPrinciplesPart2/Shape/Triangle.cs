namespace OopPrinciplesPart2
{
	using System;	
	
	public class Triangle:Shape
	{						
		//construktor		
		public Triangle(double width, double height)
            : base (width, height)
		{
			this.Width = width;
			this.Height = height;		
		}
		
		//method
        public override double CalculateSurface()
		{
			return (this.Width * this.Height) / 2;
		}		
	}
}