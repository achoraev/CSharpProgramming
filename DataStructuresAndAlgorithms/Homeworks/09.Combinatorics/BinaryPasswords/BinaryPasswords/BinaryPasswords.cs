using System;
using System.Linq;

public class BinaryPasswords
{
    public static void Main()
    {
        // one row solution 
        // Console.WriteLine(1L << Console.ReadLine().Count(x => x == '*'));                
        int input = Console.ReadLine().Count(x => x == '*');

        long result = (long)(Math.Pow((double)2, (double)input));
       
        Console.WriteLine(input != 0 ? result : 1);
    }
}