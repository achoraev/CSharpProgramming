using System;
class ExchangeBit
{
    static void Main()
    {
        Console.WriteLine("Enter Number:");
        uint number = uint.Parse(Console.ReadLine());
        for (int i = 3, j = 24; i <= 5; i++, j++)
        {
            int mask = 1 << i;
            int numMask = ((int)number & mask); 
            if (numMask != 0)
            {
                int newNumber = 1 << j;
                Console.WriteLine("The bit of position {0} is 1 and a new number is: {1}.", i, Convert.ToString(newNumber, 2));
            }
            else
            {                
                Console.WriteLine("The bit of position {0} is 0.", i);
            }
        }
    }
}
	
			 
	
