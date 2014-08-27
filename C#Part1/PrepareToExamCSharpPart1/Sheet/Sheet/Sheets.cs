using System;

class Sheets
{
    static void Main()
    {
        int number = int.Parse(Console.ReadLine());
        int temp = 1024;

        for (int i = 0; i <= 10; i++)
        {
            if (number < temp)
            {
                Console.WriteLine("A{0}", i);
            }
            else if (number > temp)
            {
                number -= temp;
            }
            else 
            {
                number -= temp;
            }

            temp /= 2;
        }
    }
}