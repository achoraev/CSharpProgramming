namespace DefineClassGSM
{
    using System;

    public class Display
    {
        private decimal displaySize;
        private string numberOfColours;

        public Display() //define constructor
        {             
        }

        public Display(decimal displaySize, string numberOfColours) //define constructor
        {
            this.displaySize = displaySize;
            this.numberOfColours = numberOfColours;
        }

        //properties
        public decimal DisplaySize
        {
            get { return displaySize; }
            set { this.displaySize = value; } 
        }
        public string NumberOfColours
        {
            get { return numberOfColours; }
            set { this.numberOfColours = value; }
        }

        public void DisplayInfo()
        {
            if (DisplaySize != 0)
            {
                Console.WriteLine("Display size is: {0} inch.", DisplaySize);
            }
            if (NumberOfColours != null)
            {
                Console.WriteLine("Colours is: " + NumberOfColours);
            }            
        }
    }
}
