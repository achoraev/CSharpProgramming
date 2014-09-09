namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class VideoCard : IMotherboard
    {
        public VideoCard()
        {
        }

        public VideoCard(bool isMonoChrome)
        {
            this.IsMonoChrome = isMonoChrome;
        }

        public bool IsMonoChrome { get; set; }

        public void DrawOnVideoCard(string data)
        {
            if (this.IsMonoChrome)
            {
                Console.ForegroundColor = ConsoleColor.Gray;
                Console.WriteLine(data);
                Console.ResetColor();
            }
            else
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine(data);
                Console.ResetColor();
            }
        }

        public int LoadRamValue()
        {
            throw new NotImplementedException();
        }

        public void SaveRamValue(int value)
        {
            throw new NotImplementedException();
        }
    }
}
