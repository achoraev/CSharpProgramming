namespace OopPrinciplesPart2
{
	using System;	
	
	public class Circle:Shape
	{		        
		
		//construktor		
		public Circle(double width, double height)
            : base (width, height)
		{
			this.Width = width;
			this.Height = height;		
		}
		
		//method
		public override double CalculateSurface()
		{
            return Math.PI * Width * Width;
		}		
	}
}