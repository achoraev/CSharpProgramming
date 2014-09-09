namespace OopPrinciplesPart2
{
	using System;	
	
	public class Rectangle:Shape
	{						
		//construktor		
		public Rectangle(double width, double height)
            :base (width, height)
		{
			this.Width = width;
			this.Height = height;		
		}
		
		//method
        public override double CalculateSurface()
		{
			return this.Width * this.Height;
		}		
	}
}