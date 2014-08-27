using System;
//Write a program that finds all prime numbers in the range [1...10 000 000]. 
//Use the sieve of Eratosthenes algorithm (find it in Wikipedia).

class PrimeNumbers
{
    static void Main()
    {
        //long sum = 0;
        long n = 10000000;
        bool[] e = new bool[n];//by default they're all false
        for (int i = 2; i < n; i++)
        {
            e[i] = true;//set all numbers to true
        }
        //weed out the non primes by finding mutiples 
        for (int j = 2; j < n; j++)
        {
            if (e[j])
            {
                for (long p = 2; (p * j) < n; p++)
                {
                    e[p * j] = false;
                }
            }
        }
        // print
        for (int i = 0; i < n; i++)
        {
            if (e[i])
            {
                Console.WriteLine("{0} -> {1}", i, e[i]);
            }
        }

    }
}

