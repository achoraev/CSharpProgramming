namespace Bussinesmen
{
    using System;

    public class Bussinesmen
    {
        static long[] solutions = new long[71];
        public static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            solutions[0] = 1;
            for (int i = 2; i <= N; i+=2)
            {
                for (int j = i - 2; j >= 0; j-= 2)
                {
                    solutions[i] += solutions[j] * solutions[i - j - 2];
                }
            }

            Console.WriteLine(solutions[N]);
        }
    }
}