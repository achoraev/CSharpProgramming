namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class PC
    {
        private readonly LaptopBattery battery;

        private IEnumerable<HardDrive> hardDrives;

        private Random rnd = new Random();

        public PC(Type type, Cpu cpu, Ram ram, IEnumerable<HardDrive> hardDrives, VideoCard videoCard, LaptopBattery battery)
        {
            Cpu = cpu;
            Ram = ram;
            this.HardDrives = hardDrives;
            this.VideoCard = videoCard;
            if (type != Type.LAPTOP && type != Type.PC)
            {
                VideoCard.IsMonoChrome = true;
            }

            this.battery = battery;
        }

        public IEnumerable<HardDrive> HardDrives
        {
            get
            {
                return this.hardDrives;
            }

            set
            {
                this.hardDrives = value;
            }
        }

        public VideoCard VideoCard { get; set; }

        public Cpu Cpu { get; set; }

        public Ram Ram { get; set; }

        public void ChargeBattery(int percentage)
        {
            this.battery.Charge(percentage);
            this.VideoCard.DrawOnVideoCard(string.Format("Battery status: {0}%", this.battery.Percentage));
        }               

        public void Process(int data)
        {
            Ram.SaveRamValue(data);            
            Cpu.CheckNumberOfBits();
        }

        public void Play(int guessNumber)
        {
            int number = this.RandomGenerator(1, 10);
            if (number != guessNumber)
            {
                VideoCard.DrawOnVideoCard(string.Format("You didn't guess the number {0}.", number));
            }
            else
            {
                this.VideoCard.DrawOnVideoCard("You win!");
            }
        }

        public int RandomGenerator(int firstValue, int secondValue)
        {
            int randomNumber;            
            randomNumber = this.rnd.Next(firstValue, secondValue);
            Ram.SaveRamValue(randomNumber);
            return randomNumber;
        }
    }
}