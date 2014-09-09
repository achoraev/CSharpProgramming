using System;

    class MinAndMax
    {
        static void Main()
        {            
            Console.WriteLine("Enter number: ");
            int number = int.Parse(Console.ReadLine());
            int loop = 0;
            int bigNum = 0;
            int minNum = int.MaxValue;
            for (int i = 0; i < number; i++)
            {
                loop = int.Parse(Console.ReadLine());
                if (loop > bigNum)
                {
                    bigNum = loop;
                }
                if (loop < minNum)
                {
                    minNum = loop;
                }
            }                        
            Console.WriteLine("Big num is: " + bigNum);
            Console.WriteLine("Min num is : " + minNum);
        }
    }

