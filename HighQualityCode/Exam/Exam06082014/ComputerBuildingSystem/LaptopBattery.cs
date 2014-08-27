namespace ComputerBuildingSystem
{
    public class LaptopBattery : IMotherboard
    {
        public LaptopBattery()
        {            
            this.Percentage = 100 / 2;
        }

        public int Percentage { get; set; }

        public void Charge(int percent)
        {
            this.Percentage += percent;
            if (this.Percentage > 100)
            {
                this.Percentage = 100;
            }

            if (this.Percentage < 0)
            {
                this.Percentage = 0;
            }
        }        

        public void DrawOnVideoCard(string data)
        {
            throw new System.NotImplementedException();
        }

        public int LoadRamValue()
        {
            return this.Percentage;
        }

        public void SaveRamValue(int value)
        {
            throw new System.NotImplementedException();
        }
    }
}