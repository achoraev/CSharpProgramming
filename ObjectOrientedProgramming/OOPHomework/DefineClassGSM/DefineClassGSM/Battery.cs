namespace DefineClassGSM
{
    using System;

    public enum BatteryType // add enumeration
    {
        LiIon, LiPolymer, NiMH, NiCd
    }
    
    public class Battery
    {
        private decimal hoursIdle;
        private decimal hoursTalk;
        private decimal capacity;
        private BatteryType batteryType;
        // several construktors
        public Battery()
        {             
        }

        public Battery(decimal hoursIdle, decimal hoursTalk, decimal capacity, BatteryType batteryType)
        {
            this.hoursIdle = hoursIdle;
            this.hoursTalk = hoursTalk;
            this.capacity = capacity;
            this.batteryType = batteryType;
        }
        
        // properties 
        public BatteryType BatteryType
        {
            get { return batteryType; }
            set { this.batteryType = value; }
        }
        
        public decimal HoursIdle 
        { 
            get {return hoursIdle;}
            set { this.hoursIdle = value; } 
        }
        
        public decimal HoursTalk 
        {
            get { return hoursTalk; }
            set { this.hoursTalk = value; } 
        }

        public decimal Capacity
        {
            get { return capacity; }
            set { this.capacity = value; } 
        }

        public void BatteryInfo()
        {
            if (HoursIdle != 0)
            {
                Console.WriteLine("Stand By: {0} h.", HoursIdle);
            }
            if (HoursTalk != 0)
            {
                Console.WriteLine("Hours to talk: " + HoursTalk);
            }
            if (Capacity != 0)
            {
                Console.WriteLine("Capacity is: {0} mAh", Capacity);
            }            
            Console.WriteLine("Battery Type is: " + BatteryType);            
        }
    }    
}
