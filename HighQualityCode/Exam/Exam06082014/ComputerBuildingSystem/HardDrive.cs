namespace ComputerBuildingSystem
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class HardDrive
    {
        private bool isInRaid;

        private int hardDrivesInRaid;

        private List<HardDrive> hardDrivesList;

        private int capacity;

        private Dictionary<int, string> data;

        // SortedDictionary<int, string> info;
        public HardDrive()
        {
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid)
        {
            this.capacity = capacity;
            this.isInRaid = isInRaid;
            this.hardDrivesInRaid = hardDrivesInRaid;
            this.data = new Dictionary<int, string>(capacity);
            this.hardDrivesList = new List<HardDrive>();
        }

        public HardDrive(int capacity, bool isInRaid, int hardDrivesInRaid, List<HardDrive> hardDrives)
            : base()
        {
            this.hardDrivesList = new List<HardDrive>(hardDrives);

            // this.hardDrivesList = hardDrives;
        }        

        public int Capacity
        {
            get
            {
                if (this.isInRaid)
                {
                    if (!this.hardDrivesList.Any())
                    {
                        return 0;
                    }

                    return this.hardDrivesList.First().Capacity;
                }
                else
                {
                    return this.capacity;
                }
            }
        }

        public void SaveData(int addr, string newData)
        {
            if (this.isInRaid)
            {
                foreach (var hardDrive in this.hardDrivesList)
                {
                    hardDrive.SaveData(addr, newData);
                }
            }
            else
            {
                this.data[addr] = newData;
            }
        }

        public string LoadData(int address)
        {
            if (this.isInRaid)
            {
                if (!this.hardDrivesList.Any())
                {
                    throw new OutOfMemoryException("No hard drive in the RAID array!");
                }

                return this.hardDrivesList.First().LoadData(address);
            }
            else if (true)
            {
                return this.data[address];
            }
        }

        //public void DrawOnVideoCard(string data)
        //{
        //    if (this.IsMonochrome)
        //    {
        //        Console.ForegroundColor = ConsoleColor.Gray;
        //        Console.WriteLine(data);
        //        Console.ResetColor();
        //    }
        //    else
        //    {
        //        Console.ForegroundColor = ConsoleColor.Green;
        //        Console.WriteLine(data);
        //        Console.ResetColor();
        //    }
        //}

        public int LoadRamValue()
        {
            throw new System.NotImplementedException();
        }

        public void SaveRamValue(int value)
        {
            throw new System.NotImplementedException();
        }
    }
}