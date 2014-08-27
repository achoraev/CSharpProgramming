using System; 
  
class CoffeMachine 
{ 
    static void Main() 
    { 
       double firstTray = double.Parse (Console.ReadLine());
	   double secondTray = double.Parse (Console.ReadLine());
	   double thirdTray = double.Parse (Console.ReadLine());
	   double fourthTray = double.Parse (Console.ReadLine());
	   double fifthTray = double.Parse (Console.ReadLine());
	   double amountPut = double.Parse (Console.ReadLine());
	   double price = double.Parse (Console.ReadLine());
	   double totalFirstTray = (firstTray * 0.05d);
	   double totalSecondTray = (secondTray * 0.10d);
	   double totalThirdTray = (thirdTray * 0.20d);
	   double totalFourthTray = (fourthTray * 0.50d);
	   double totalFifthTray = (fifthTray * 1.00d);	   
	   double machineTray = (totalFirstTray + totalSecondTray + totalThirdTray + totalFourthTray + totalFifthTray);
	   double change = (amountPut - price);
		if ((amountPut >= price) && (change <= machineTray))
		{
			Console.WriteLine("Yes {0:F2}", (machineTray - change));
		}
		else if(amountPut < price)		
		{
			Console.WriteLine("More {0:F2}", (-change));
		}	   
		else 
		{
			Console.WriteLine("No {0:F2}", (change - machineTray));
		}
    } 
} 

