using System;

    class CalculateDouble
    {
        static void Main()
        {
            double sum = 1;
            double total = 0;
			for (double del = 2; del <= 1010; del ++)
			{
				if(del % 2 == 0)
				{
					sum = sum +(1/del);
				}
				else
				{
					sum = sum -(1/del);
				}
                Console.WriteLine(sum);
                total += sum;
			}
            Console.WriteLine("The sum is: {0:F4}", total);
        }
    }

