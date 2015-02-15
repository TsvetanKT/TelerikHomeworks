using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace MinesGame
{
    public class Mines
    {
        public class Player
        {
            string name;
            int points;

            public string Name
            {
                get { return name; }
                set { name = value; }
            }

            public int Points
            {
                get { return points; }
                set { points = value; }
            }

            public Player() { }

            public Player(string name, int points)
            {
                this.name = name;
                this.points = points;
            }
        }

        static void Main()
        {
            string command = string.Empty;
            char[,] field = CreateGameField();
            char[,] bombs = PlaceBombs();
            int counter = 0;
            bool explosion = false;
            List<Player> PlayersRanks = new List<Player>(6);
            int row = 0;
            int column = 0;
            bool isBegining = true;
            const int EMPTY_FIELDS = 35;
            bool isWinning = false;

            do
            {
                if (isBegining)
                {
                    Console.WriteLine("Hajde da igraem na “Mini4KI”. Probvaj si kasmeta da otkriesh poleteta bez mini4ki." +
                    " Komanda 'top' pokazva klasiraneto, 'restart' po4va nova igra, 'exit' izliza i hajde 4ao!");
                    DisplayGameField(field);
                    isBegining = false;
                }
                Console.Write("Daj red i kolona : ");
                command = Console.ReadLine().Trim();
                if (command.Length >= 3)
                {
                    if (int.TryParse(command[0].ToString(), out row) &&
                        int.TryParse(command[2].ToString(), out column) &&
                        row <= field.GetLength(0) && column <= field.GetLength(1))
                    {
                        command = "turn";
                    }
                }
                switch (command)
                {
                    case "top":
                        Rank(PlayersRanks);
                        break;
                    case "restart":
                        field = CreateGameField();
                        bombs = PlaceBombs();
                        DisplayGameField(field);
                        explosion = false;
                        isBegining = false;
                        break;
                    case "exit":
                        Console.WriteLine("4a0, 4a0, 4a0!");
                        break;
                    case "turn":
                        if (bombs[row, column] != '*')
                        {
                            if (bombs[row, column] == '-')
                            {
                                GameMove(field, bombs, row, column);
                                counter++;
                            }
                            if (EMPTY_FIELDS == counter)
                            {
                                isWinning = true;
                            }
                            else
                            {
                                DisplayGameField(field);
                            }
                        }
                        else
                        {
                            explosion = true;
                        }
                        break;
                    default:
                        Console.WriteLine("\nGreshka! nevalidna Komanda\n");
                        break;
                }
                if (explosion)
                {
                    DisplayGameField(bombs);
                    Console.Write("\nHrrrrrr! Umria gerojski s {0} to4ki. " +
                        "Daj si niknejm: ", counter);
                    string nickname = Console.ReadLine();
                    Player currentPlayer = new Player(nickname, counter);
                    if (PlayersRanks.Count < 5)
                    {
                        PlayersRanks.Add(currentPlayer);
                    }
                    else
                    {
                        for (int i = 0; i < PlayersRanks.Count; i++)
                        {
                            if (PlayersRanks[i].Points < currentPlayer.Points)
                            {
                                PlayersRanks.Insert(i, currentPlayer);
                                PlayersRanks.RemoveAt(PlayersRanks.Count - 1);
                                break;
                            }
                        }
                    }
                    PlayersRanks.Sort((Player r1, Player r2) => r2.Name.CompareTo(r1.Name));
                    PlayersRanks.Sort((Player r1, Player r2) => r2.Points.CompareTo(r1.Points));
                    Rank(PlayersRanks);

                    field = CreateGameField();
                    bombs = PlaceBombs();
                    counter = 0;
                    explosion = false;
                    isBegining = true;
                }
                if (isWinning)
                {
                    Console.WriteLine("\nBRAVOOOS! Otvri 35 kletki bez kapka kryv.");
                    DisplayGameField(bombs);
                    Console.WriteLine("Daj si imeto, batka: ");
                    string playerName = Console.ReadLine();
                    Player currentPlayer = new Player(playerName, counter);
                    PlayersRanks.Add(currentPlayer);
                    Rank(PlayersRanks);
                    field = CreateGameField();
                    bombs = PlaceBombs();
                    counter = 0;
                    isWinning = false;
                    isBegining = true;
                }
            }
            while (command != "exit");
            Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
            Console.WriteLine("AREEEEEEeeeeeee.");
            Console.Read();
        }

        private static void Rank(List<Player> Champions)
        {
            Console.WriteLine("\nTo4KI:");
            if (Champions.Count > 0)
            {
                for (int i = 0; i < Champions.Count; i++)
                {
                    Console.WriteLine("{0}. {1} --> {2} kutii",
                        i + 1, Champions[i].Name, Champions[i].Points);
                }
                Console.WriteLine();
            }
            else
            {
                Console.WriteLine("prazna klasaciq!\n");
            }
        }

        private static void GameMove(char[,] field,
            char[,] bombs, int row, int column)
        {
            char nearBombs = ProximityMinesCalculator(bombs, row, column);
            bombs[row, column] = nearBombs;
            field[row, column] = nearBombs;
        }

        private static void DisplayGameField(char[,] board)
        {
            int rows = board.GetLength(0);
            int collumns = board.GetLength(1);
            Console.WriteLine("\n    0 1 2 3 4 5 6 7 8 9");
            Console.WriteLine("   ---------------------");
            for (int i = 0; i < rows; i++)
            {
                Console.Write("{0} | ", i);
                for (int j = 0; j < collumns; j++)
                {
                    Console.Write(string.Format("{0} ", board[i, j]));
                }
                Console.Write("|");
                Console.WriteLine();
            }
            Console.WriteLine("   ---------------------\n");
        }

        private static char[,] CreateGameField()
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

        private static char[,] PlaceBombs()
        {
            int rows = 5;
            int columns = 10;
            char[,] gameField = new char[rows, columns];

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    gameField[i, j] = '-';
                }
            }

            List<int> randomNumbers = new List<int>();
            while (randomNumbers.Count < 15)
            {
                Random randomGenerator = new Random();
                int asfd = randomGenerator.Next(50);
                if (!randomNumbers.Contains(asfd))
                {
                    randomNumbers.Add(asfd);
                }
            }

            foreach (int random in randomNumbers)
            {
                int column = (random / columns);
                int row = (random % columns);
                if (row == 0 && random != 0)
                {
                    column--;
                    row = columns;
                }
                else
                {
                    row++;
                }
                gameField[column, row - 1] = '*';
            }

            return gameField;
        }

        private static void Calculations(char[,] field)
        {
            int rows = field.GetLength(0);
            int columns = field.GetLength(1);

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < columns; j++)
                {
                    if (field[i, j] != '*')
                    {
                        char proximityMinesNumber = ProximityMinesCalculator(field, i, j);
                        field[i, j] = proximityMinesNumber;
                    }
                }
            }
        }

        private static char ProximityMinesCalculator(char[,] r, int gameRows, int gameCollumns)
        {
            int number = 0;
            int rows = r.GetLength(0);
            int columns = r.GetLength(1);

            if (gameRows - 1 >= 0)
            {
                if (r[gameRows - 1, gameCollumns] == '*')
                {
                    number++;
                }
            }
            if (gameRows + 1 < rows)
            {
                if (r[gameRows + 1, gameCollumns] == '*')
                {
                    number++;
                }
            }
            if (gameCollumns - 1 >= 0)
            {
                if (r[gameRows, gameCollumns - 1] == '*')
                {
                    number++;
                }
            }
            if (gameCollumns + 1 < columns)
            {
                if (r[gameRows, gameCollumns + 1] == '*')
                {
                    number++;
                }
            }
            if ((gameRows - 1 >= 0) && (gameCollumns - 1 >= 0))
            {
                if (r[gameRows - 1, gameCollumns - 1] == '*')
                {
                    number++;
                }
            }
            if ((gameRows - 1 >= 0) && (gameCollumns + 1 < columns))
            {
                if (r[gameRows - 1, gameCollumns + 1] == '*')
                {
                    number++;
                }
            }
            if ((gameRows + 1 < rows) && (gameCollumns - 1 >= 0))
            {
                if (r[gameRows + 1, gameCollumns - 1] == '*')
                {
                    number++;
                }
            }
            if ((gameRows + 1 < rows) && (gameCollumns + 1 < columns))
            {
                if (r[gameRows + 1, gameCollumns + 1] == '*')
                {
                    number++;
                }
            }
            return char.Parse(number.ToString());
        }
    }
}
