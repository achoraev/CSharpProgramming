using System;

class BitBall
{
    static void Main()
    {

        int[,] TopTeam = new int[8, 8];
        
        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int bit = (num >> j) & 1;
                if (bit == 1)
                {
                    TopTeam[i, j] = 1;
                }
            }                        
        }
        for (int i = 0; i < 8; i++)
        {
            int num = int.Parse(Console.ReadLine());
            for (int j = 0; j < 8; j++)
            {
                int bit = (num >> j) & 1;
                if (bit == 1)
                {
                    if (TopTeam[i, j] == 1)
                    {
                        TopTeam[i, j] = 0;
                    }
                    else
                    {
                        TopTeam[i, j] = 2;
                    }
                }
            }
        }
        int playerT = 0;
        int playerB = 0;
        for (int col = 0; col < 8; col++)
        {
            for (int row = 0; row < 8; row++)
            {
                if (TopTeam[row, col] == 1)
                {
                    break;
                }
                else if (TopTeam[row, col] == 2)
                {
                    playerB++;
                    break;
                }

            }
        }
        for (int  col= 0; col < 8; col++)
        {
            for (int row = 7; row >= 0; row--)
            {
                if (TopTeam[row, col] == 2)
                {
                    
                    break;
                }
                else if (TopTeam[row, col] == 1)
                {
                    playerT++;
                    break;
                }
            }
        }
        Console.WriteLine("{0}:{1}", playerT, playerB);
    }
}