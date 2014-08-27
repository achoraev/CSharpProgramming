using System;

    class FirstTenMembers
    {
        static void Main()
        {
            for (int i = 2, j = -3; i <= 10; i += 2, j -= 2)
            {
                System.Console.WriteLine(i + " ");
                System.Console.WriteLine(j + " ");
            }
        }
    }
