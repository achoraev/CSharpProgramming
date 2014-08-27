namespace Minesweaper
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Minesweaper
    {
        public static void Main()
        {
            string commands = string.Empty;
            char[,] field = CreateField();
            char[,] bombs = SetBomb();
            int counter = 0;
            bool boom = false;
            List<CheckPoints> champions = new List<CheckPoints>(6);
            int row = 0;
            int col = 0;
            bool flagFirst = true;
            const int MaxPoints = 35;
            bool flagSecond = false;

            do
            {
                if (flagFirst)
                {
                    Console.WriteLine("Let's play Minesweaper. Try your luck to find fields without mines. Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    WriteField(field);
                    flagFirst = false;
                }

                Console.Write("Enter command or row(0-4) and col(0-9) with space between: "); 
                commands = Console.ReadLine().Trim();

                if (commands.Length >= 3)
                {
                    if (int.TryParse(commands[0].ToString(), out row) &&
                        int.TryParse(commands[2].ToString(), out col) &&
                        row <= field.GetLength(0) && col <= field.GetLength(1))
                    {
                        commands = "turn";
                    }
                }

                switch (commands)
                {
                    case "top":
                        HighScore(champions);
                        break;
                    case "restart":
                        field = CreateField();
                        bombs = SetBomb();
                        WriteField(field);
                        boom = false;
                        flagFirst = false;
                        break;
                    case "exit":
                        Console.WriteLine("Bye, Bye, Bye!");
                        break;
                    case "turn":
                        if (bombs[row, col] != '*')
                        {
                            if (bombs[row, col] == '-')
                            {
                                NextMove(field, bombs, row, col);
                                counter++;
                            }

                            if (MaxPoints == counter)
                            {
                                flagSecond = true;
                            }
                            else
                            {
                                WriteField(field);
                            }
                        }
                        else
                        {
                            boom = true;
                        }

                        break;
                    default:
                        Console.WriteLine("Wrong command!!!");
                        break;
                }

                if (boom)
                {
                    WriteField(bombs);
                    Console.Write("Game over!!! {0} points. Enter username: ", counter);
                    string userName = Console.ReadLine();
                    CheckPoints playerOnePoints = new CheckPoints(userName, counter);
                    if (champions.Count < 5)
                    {
                        champions.Add(playerOnePoints);
                    }
                    else
                    {
                        for (int i = 0; i < champions.Count; i++)
                        {
                            if (champions[i].Points < playerOnePoints.Points)
                            {
                                champions.Insert(i, playerOnePoints);
                                champions.RemoveAt(champions.Count - 1);
                                break;
                            }
                        }
                    }

                    champions.Sort((CheckPoints resultFirstPlayer, CheckPoints resultSecondPlayer) => resultSecondPlayer.Name.CompareTo(resultFirstPlayer.Name));
                    champions.Sort((CheckPoints resultFirstPlayer, CheckPoints resultSecondPlayer) => resultSecondPlayer.Points.CompareTo(resultFirstPlayer.Points));
                    HighScore(champions);

                    field = CreateField();
                    bombs = SetBomb();
                    counter = 0;
                    boom = false;
                    flagFirst = true;
                }

                if (flagSecond)
                {
                    Console.WriteLine("Bravo! Found all 35 cells.");
                    WriteField(bombs);
                    Console.WriteLine("Enter nickname: ");
                    string nickName = Console.ReadLine();
                    CheckPoints playersPoint = new CheckPoints(nickName, counter);
                    champions.Add(playersPoint);
                    HighScore(champions);
                    field = CreateField();
                    bombs = SetBomb();
                    counter = 0;
                    flagSecond = false;
                    flagFirst = true;
                }
            }
            while (commands != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void HighScore(List<CheckPoints> playersPoint)
        {
            Console.WriteLine("Points:");
            if (playersPoint.Count > 0)
            {
                for (int i = 0; i < playersPoint.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} cells", i + 1, playersPoint[i].Name, playersPoint[i].Points);
                }

                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("Leaderboard is empty!!!");
            }
        }

        private static void NextMove(char[,] field, char[,] bombs, int row, int col)
        {
            char allBombs = SetNumberOfBombs(bombs, row, col);
            bombs[row, col] = allBombs;
            field[row, col] = allBombs;
        }

        private static void WriteField(char[,] board)
        {
            int rows = board.GetLength(0);
            int cols = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < cols; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }

                Console.Write("|");
                Console.WriteLine();
            }

            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateField()
        {
            int boardRows = 5;
            int boardColumns = 10;
            char[,] board = new char[boardRows, boardColumns];

            for (int i = 0; i < boardRows; i++)
            {
                for (int j = 0; j < boardColumns; j++)
                {
                    board[i, j] = '?';
                }
            }

            return board;
        }

        private static char[,] SetBomb()
        {
            int rows = 5;
            int cols = 10;
            char[,] fieldBomb = new char[rows, cols];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < cols; j++)
                {
                    fieldBomb[i, j] = '-';
                }
            }

            List<int> listOfBombs = new List<int>();
            while (listOfBombs.Count < 15)
            {
                Random random = new Random();
                int randomNumber = random.Next(50);
                if (!listOfBombs.Contains(randomNumber))
                {
                    listOfBombs.Add(randomNumber);
                }
            }

            foreach (int bombs in listOfBombs)
            {
                int colBomb = bombs / cols;
                int rowBomb = bombs % cols;

                if (rowBomb == 0 && bombs != 0)
                {
                    colBomb--;
                    rowBomb = cols;
                }
                else
                {
                    rowBomb++;
                }

                fieldBomb[colBomb, rowBomb - 1] = '*';
            }

            return fieldBomb;
        }

        // private static void smetki(char[,] field)
        // {
        // int row = field.GetLength(0);
        // int col = field.GetLength(1);

        // for (int i = 0; i < row; i++)
        // {
        // for (int j = 0; j < row; j++)
        // {
        // if (field[i, j] != '*')
        // {
        // char numberOfBombs = setNumberOfBombs(field, i, j);
        // field[i, j] = numberOfBombs;
        // }
        // }
        // }
        // }
        private static char SetNumberOfBombs(char[,] field, int row, int col)
        {
            int numberOfBombs = 0;
            int rows = field.GetLength(0);
            int cols = field.GetLength(1);

            if (row - 1 >= 0)
            {
                if (field[row - 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (row + 1 < rows)
            {
                if (field[row + 1, col] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (col - 1 >= 0)
            {
                if (field[row, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if (col + 1 < cols)
            {
                if (field[row, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (col - 1 >= 0))
            {
                if (field[row - 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row - 1 >= 0) && (col + 1 < cols))
            {
                if (field[row - 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (col - 1 >= 0))
            {
                if (field[row + 1, col - 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            if ((row + 1 < rows) && (col + 1 < cols))
            {
                if (field[row + 1, col + 1] == '*')
                {
                    numberOfBombs++;
                }
            }

            return char.Parse(numberOfBombs.ToString());
        }

        public class CheckPoints
        {
            private string name;
            private int points;

            public CheckPoints()
            {
            }

            public CheckPoints(string name, int points)
            {
                this.Name = name;
                this.Points = points;
            }

            public string Name
            {
                get { return this.name; }
                set { this.name = value; }
            }

            public int Points
            {
                get { return this.points; }
                set { this.points = value; }
            }            
        }
    }
}
