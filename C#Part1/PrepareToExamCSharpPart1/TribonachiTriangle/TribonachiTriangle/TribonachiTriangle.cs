using System;

class TribonachiTriangle
{
    static void Main()
    {
        long firstMember = long.Parse(Console.ReadLine());
        long secondMember = long.Parse(Console.ReadLine());
        long thirdMember = long.Parse(Console.ReadLine());
        long numberRows = long.Parse(Console.ReadLine());
        long currentRow = 3;
        long delitel = 2;
        long[] array = new long[21];
        array [0] = firstMember;
        array [1] = secondMember;
        array [2] = thirdMember;            
        if (numberRows >= 2)
        {
            Console.WriteLine("{0}", firstMember);
            Console.WriteLine("{0} {1}", secondMember, thirdMember);
                
            for (int i = 2; i <= 20; i++)
            {
                array[i] = (firstMember + secondMember + thirdMember);
                firstMember = secondMember;
                secondMember = thirdMember;
                thirdMember = array[i];
            }
           
            for (int j = 0; j < (numberRows-2); j++)
            {
                for (long k = currentRow-1; k < (currentRow + delitel); k++)
                {
                    Console.Write("{0} ", array[k]);
                }
                currentRow++;
                delitel++;
                Console.WriteLine();
            }                               
        }
        else
        {
            Console.WriteLine("Wrong Number!!!");
        }                           
    }
}

