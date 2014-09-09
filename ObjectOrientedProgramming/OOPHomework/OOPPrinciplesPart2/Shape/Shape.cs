namespace OopPrinciplesPart2
{
	using System;	
	
	public abstract class Shape
	{		
		// fields
		private double width;
		private double height;						
		//props
        public double Width
        {
            get { return width; }
            set { width = value; }
        }
        
        public double Height
        {
            get { return height; }
            set { height = value; }
        }
        //construktor
        protected Shape(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }
		//methods
		public abstract double CalculateSurface ();		
	}
}