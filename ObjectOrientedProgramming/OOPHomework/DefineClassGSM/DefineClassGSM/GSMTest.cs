namespace DefineClassGSM
{    
    using System;
    using DefineClassGSM;

    public class GSMTest // 7. Create class GSM Test
    {                
        public static void Test()
        {
            GSM LG = new GSM("P920", "LG", 249.99m, "Anjel");
            GSM Samsung = new GSM("Galaxy S4", "Samsung", 949.99m, "Reni");
            Battery MyBattery = new Battery(180m, 5m, 1500m, BatteryType.LiIon);
            Display MyDisplay = new Display(4.7m, "16M");

            GSM[] arrayOfMobilPhones = {LG, Samsung, GSM.IPhone4S}; // 
            foreach (var item in arrayOfMobilPhones)
            {
                Console.WriteLine(item);
            }
            MyBattery.BatteryInfo();
            Console.WriteLine();
            MyDisplay.DisplayInfo();
        }
    }
}

