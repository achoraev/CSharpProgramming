using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

    class JoroTheRabbit
    {
        static void Main()
        {
            //input
            string []terrain = Console.ReadLine().Split(new char [] {' ', ','},StringSplitOptions.RemoveEmptyEntries);
            //solution
            int [] terrainNumbers = new int [terrain.Length];
            for (int i = 0; i < terrain.Length; i++)
            {
                terrainNumbers[i] = int.Parse(terrain[i]);
            }
            int maxPosition = -1111;            
            int stepPosition = 1;
            int currentPosition = 0;
            //int nextPosition = 0;
            for (int i = 0; i < terrainNumbers.Length; i++)
            {
                for (int step = 1; step < terrainNumbers.Length; step++)
                {                                        
                    int index = i;
                    stepPosition = 1;
                    currentPosition = terrainNumbers[step];
                    int next = (step + index) % terrainNumbers.Length;
                    while (terrainNumbers[index] < terrainNumbers[next])
                    {
                        stepPosition++;
                        index = next;
                        next = (index+step) % terrainNumbers.Length;
                    }
                    maxPosition = CheckMaxPosition(maxPosition, stepPosition);
                }
            }
            //result
            Console.WriteLine(maxPosition);
        }

        private static int CheckMaxPosition(int maxPosition, int stepPosition)
        {
            if (stepPosition > maxPosition)
            {
                maxPosition = stepPosition;
            }
            return maxPosition;
        }
    }

