namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.IO;    

    public class ComputersEntryPoint
    { 
        private const int RAM2 = 2;
        private const int RAM4 = 4;
        private const int RAM8 = 8;
        private const int RAM16 = 16;
        private const int RAM32 = 32;
        private const int RAM64 = 64;

        private const int CORES2 = 2;
        private const int CORES4 = 4;
        private const int CORES8 = 8;

        private const int BIT32 = 32;
        private const int BIT64 = 64;
        private const int BIT128 = 128;
        private const int DRIVECAPACITY500 = 500;
        private const int DRIVECAPACITY1000 = 1000;
        private const int DRIVECAPACITY2000 = 2000;

        private const string TestIn001 = @"Lenovo
Play 5
Play 6
Charge 10
Charge 0
Charge -100
Charge 200
Charge -1
Process -1
Process 2001
Process 2000
Process 1000
Process 500
Process 16
Exit";

        private static PC pc, laptop, server;

        public static void Main()
        {
            Console.SetIn(new StringReader(TestIn001));

            string manufacturer = Console.ReadLine();
            if (manufacturer == "HP")
            {
                var computerRam = new Ram(RAM2);
                var computerVideo = new VideoCard(false); // todo new videocard
                pc = new PC(Type.PC, new Cpu(CORES2, BIT32, computerRam, computerVideo), computerRam, new[] { new HardDrive(DRIVECAPACITY500, false, 0) }, computerVideo, null);
                var serverRam = new Ram(RAM32);
                var serverVideo = new VideoCard();
                server = new PC(
                    Type.SERVER,
                    new Cpu(CORES4, BIT32, serverRam, serverVideo), 
                    serverRam, 
                    new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(DRIVECAPACITY1000, false, 0), new HardDrive(1000, false, 0) }) }, 
                    serverVideo, 
                    null);
                {
                    var laptopCard = new VideoCard(false);
                    var laptopRam = new Ram(RAM4);
                    laptop = new PC(Type.LAPTOP, new Cpu(CORES2, BIT64, laptopRam, laptopCard), laptopRam, new[] { new HardDrive(DRIVECAPACITY500, false, 0) }, laptopCard, new LaptopBattery());
                }
            }
            else if (manufacturer == "Dell")
            {
                var computerRam = new Ram(RAM8);
                var computerVideo = new VideoCard(false);
                pc = new PC(Type.PC, new Cpu(CORES4, BIT64, computerRam, computerVideo), computerRam, new[] { new HardDrive(DRIVECAPACITY1000, false, 0) }, computerVideo, null);
                var serverRam = new Ram(RAM64);
                var serverVideo = new VideoCard();
                server = new PC(
                    Type.SERVER,
                    new Cpu(CORES8, BIT64, serverRam, serverVideo), 
                    serverRam,
                    new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(DRIVECAPACITY2000, false, 0), new HardDrive(DRIVECAPACITY2000, false, 0) }) }, 
                    serverVideo, 
                    null);
                var laptopRam = new Ram(RAM8);
                var laptopVideo = new VideoCard(false);
                laptop = new PC(Type.LAPTOP, new Cpu(CORES4, BIT32, laptopRam, laptopVideo), laptopRam, new[] { new HardDrive(DRIVECAPACITY1000, false, 0) }, laptopVideo, new LaptopBattery());
            }
            else if (manufacturer == "Lenovo")
            {
                var computerRam = new Ram(RAM4);
                var computerVideo = new VideoCard(true);
                pc = new PC(Type.PC, new Cpu(CORES2, BIT64, computerRam, computerVideo), computerRam, new[] { new HardDrive(DRIVECAPACITY2000, false, 0) }, computerVideo, null);
                var serverRam = new Ram(RAM8);
                var serverVideo = new VideoCard();
                server = new PC(
                    Type.SERVER,
                    new Cpu(CORES2, BIT128, serverRam, serverVideo),
                    serverRam,
                    new List<HardDrive> { new HardDrive(0, true, 2, new List<HardDrive> { new HardDrive(DRIVECAPACITY500, false, 0), new HardDrive(DRIVECAPACITY500, false, 0) }) },
                    serverVideo,
                    null);
                var laptopRam = new Ram(RAM16);
                var laptopVideo = new VideoCard(false);
                laptop = new PC(Type.LAPTOP, new Cpu(CORES2, BIT64, laptopRam, laptopVideo), laptopRam, new[] { new HardDrive(DRIVECAPACITY1000, false, 0) }, laptopVideo, new LaptopBattery());
            }
            else
            {
                throw new ArgumentException("Invalid manufacturer!");
            }

            while (true)
            {
                var consoleInput = Console.ReadLine();
                if (consoleInput == null || consoleInput.StartsWith("Exit"))
                {
                    break;
                }

                var inputSplited = consoleInput.Split(new[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
                if (inputSplited.Length != 2)
                {
                    throw new ArgumentException("Invalid command!");
                }

                var command = inputSplited[0];
                var number = int.Parse(inputSplited[1]);

                if (command == "Charge")
                {
                    laptop.ChargeBattery(number);
                }
                else if (command == "Process")
                {
                    server.Process(number);
                }
                else if (command == "Play")
                {
                    pc.Play(number);
                }

                // Console.WriteLine("Invalid command!");
            }
        }        
    }
}