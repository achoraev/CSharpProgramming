namespace LoopRefactoring
{
    using System;

    public class LoopRefactoring
    {
        public static void Main()
        {
            int[] array = new int[100];
            Random rand = new Random();

            // Generate random numbers to fill array
            for (int i = 0; i < array.Length; i++)
            {
                array[i] = rand.Next(1, 40);
            }

            int expectedValue = 15;
            bool isFoundValue = false;

            for (int number = 0; number < 100; number++)
            {
                if (number % 10 == 0)
                {
                    if (array[number] == expectedValue)
                    {
                        isFoundValue = true;
                    }
                }

                Console.WriteLine(array[number]);
            }

            if (isFoundValue)
            {
                Console.WriteLine("Value found!!!");
            }
            else
            {
                Console.WriteLine("Value Not Found!!!");
            }
        }
    }
}