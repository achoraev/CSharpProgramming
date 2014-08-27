namespace ComputerBuildingSystem
{
    using System;

    public class Cpu : IMotherboard
    {
        private static readonly Random Random = new Random();

        private readonly byte numberOfBits;

        private readonly Ram ram;

        private readonly VideoCard videoCard;

        public Cpu(byte numberOfCores, byte numberOfBits, Ram ram, VideoCard videoCard)
        {
            this.NumberOfCores = numberOfCores;
            this.numberOfBits = numberOfBits;
            this.ram = ram;
            this.videoCard = videoCard;
        }

        public byte NumberOfCores { get; set; }

        public void CheckNumberOfBits()
        {
            if (this.numberOfBits == 32)
            {
                int maxValue = 500;
                this.CheckIsInRange(maxValue);
            }

            if (this.numberOfBits == 64)
            {
                int maxValue = 1000;
                this.CheckIsInRange(maxValue);
            }

            if (this.numberOfBits == 128)
            {
                int maxValue = 2000;
                this.CheckIsInRange(maxValue);
            }
        }        

        public void DrawOnVideoCard(string data)
        {
            throw new NotImplementedException();
        }

        public int LoadRamValue()
        {
            throw new NotImplementedException();
        }

        public void SaveRamValue(int value)
        {
            throw new NotImplementedException();
        }

        private void CheckIsInRange(int maxValue)
        {
            var data = this.ram.LoadRamValue();
            if (data < 0)
            {
                this.videoCard.DrawOnVideoCard("Number too low.");
            }
            else if (data > maxValue)
            {
                this.videoCard.DrawOnVideoCard("Number too high.");
            }
            else
            {
                this.CalculateSquare(data);
            }
        }

        private void CalculateSquare(int data)
        {
            int value = 0;
            for (int i = 0; i < data; i++)
            {
                value += data;
            }

            // todo with math sqrt
            this.videoCard.DrawOnVideoCard(string.Format("Square of {0} is {1}.", data, value));            
        }
    }
}