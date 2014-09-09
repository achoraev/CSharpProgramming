namespace FirstTask
{
    using System;    

    public class Size
    {
        private double width;
        private double height;

        public Size(double width, double height)
        {
            this.width = width;
            this.height = height;
        }
        
        public double Width
        {
            get { return this.width; }
            set { this.width = value; }
        }

        public double Height
        {
            get { return this.height; }
            set { this.height = value; }
        }

        internal Size GetRotatedSize(Size figure, double angleOfTheFigure)
        {
            double cosinus = Math.Abs(Math.Cos(angleOfTheFigure));
            double sinus = Math.Abs(Math.Sin(angleOfTheFigure));
            double resultWidth = (cosinus * figure.Width) + (sinus * figure.Height);
            double resultHeight = (cosinus * figure.Width) + (sinus * figure.Height);
            return new Size(resultWidth, resultHeight); 
        }
    }
}