using System;
//Write a program that compares two char arrays lexicographically (letter by letter).

    class CharArray
    {
        static void Main()
        {
             
            int sum = 0;
            int sumTwo = 0;
            Console.WriteLine("Enter string: ");
            char[] firstArray = Console.ReadLine().ToCharArray();
            Console.WriteLine("Enter string: ");
            char[] secondArray = Console.ReadLine().ToCharArray();
            for (int i = 0; i < firstArray.Length; i++)
            {
                sum += firstArray[i];                
            }
            
            for (int j = 0; j < secondArray.Length; j++)
            {                
                sumTwo += secondArray[j];               
            }
            if (sum > sumTwo)
            {
                Console.WriteLine("First arrays sum {0} is greater than seconds {1}", sum, sumTwo);
            }
            else
            {
                Console.WriteLine("First arrays sum {0} is smaller than seconds {1}", sum, sumTwo);
            }
        }
    }

