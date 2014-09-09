using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

class FallRocks
{
    static int left = 0;
    static int right = 1;
    static int center = 2;
    static int PlayerDirection = center;
    static int PlayerColumn = 50;
    static int PlayerRow = 27;

    static void Main()
    {
        SetGameField();
        while (true)
        {
            if (Console.KeyAvailable)
            {
                ConsoleKeyInfo key = Console.ReadKey(false);
                ChangePlayerDirection(key);
            }

            MovePlayer();

            WriteOnPosition(PlayerColumn, PlayerRow, "(0)", ConsoleColor.Yellow);

            Thread.Sleep(150);

        }
    }
    static void ChangePlayerDirection(ConsoleKeyInfo key)
    {
        if (key.Key == ConsoleKey.LeftArrow)
        {
            PlayerDirection = left;
        }
        if (key.Key == ConsoleKey.RightArrow)
        {
            PlayerDirection = right;
        }
    }

    static void SetGameField()
    {
        Console.WindowHeight = 40;
        Console.BufferHeight = 40;

        Console.WindowWidth = 100;
        Console.BufferWidth = 100;
        PlayerColumn = Console.WindowWidth / 2;
        PlayerRow = Console.WindowHeight - 3;
    }

    static void MovePlayer()
    {
        if (PlayerDirection == right)
        {
            PlayerColumn++;
        }
        if (PlayerDirection == left)
        {
            PlayerColumn--;
        }
    }

    static void WriteOnPosition(int x, int y, string ch, ConsoleColor color)
    {
        Console.ForegroundColor = color;
        Console.SetCursorPosition(x, y);
        Console.Write(ch);
    }
}