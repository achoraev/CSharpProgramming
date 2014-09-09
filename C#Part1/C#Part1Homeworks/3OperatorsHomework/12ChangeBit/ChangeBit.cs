using System;
class ChangeBit
{
    static void Main()    
		{        
			Console.WriteLine("Enter Number:");
			int number = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Bit Position:");			
			int position = int.Parse(Console.ReadLine());
			Console.WriteLine("Enter Value 0 or 1:");			
			int value = int.Parse(Console.ReadLine());
			int mask = 1 << position;
            if (value == 0)
            {
                Console.WriteLine("New number:" + (number - mask));
            }
            else
            {
                Console.WriteLine("New number:" + (number + mask));  
            }        
		}
}