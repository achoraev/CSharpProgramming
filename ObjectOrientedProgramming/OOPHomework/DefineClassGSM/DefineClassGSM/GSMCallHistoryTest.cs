using System;
namespace DefineClassGSM
{
    class GSMCallHistoryTest
    {
        public static void CallTest()
        {
            GSM LG = new GSM("P920", "LG", 249.99m, "Anjel");

            LG.AddCall(DateTime.Today, "0887561251", 20);
            LG.AddCall(DateTime.Today, "0897556644", 90);
            LG.AddCall(DateTime.Today, "0887441100", 65);
            LG.AddCall(DateTime.Today, "0885001122", 125);
            LG.AddCall(DateTime.Today, "0896559988", 45);
            
            Console.WriteLine(LG);
            PrintCalls(LG);
            Console.WriteLine("Total cost: {0:F2} lv.", LG.CalculatePriceOfCall());
            
            LG.DeleteLongestCall();

            PrintCalls(LG);

            Console.WriteLine("Total cost: {0:F2} lv.", LG.CalculatePriceOfCall());

            LG.RemoveCalls();

            PrintCalls(LG);

            LG.ClearCallHistory();

            if (LG.CallHistory.Count != 0)
            {
                PrintCalls(LG);        
            }
            else
            {
                Console.WriteLine("Call History is Empty!!!");
            }
        }

        private static void PrintCalls(GSM LG)
        {
            foreach (var Call in LG.CallHistory)
            {
                Console.WriteLine(Call);
            }
        }
    }
}
