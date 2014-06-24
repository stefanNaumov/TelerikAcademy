using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace minesweepers
{
	public class minite
	{
		public class Point
		{
			private string name;
			private int points;

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

			public Point() { }

			public Point(string name, int points)
			{
				this.name = name;
				this.points = points;
			}
		}

		static void Main(string[] args)
		{
			string command = string.Empty;
			char[,] field = CreateGameField();
			char[,] bombs = PlaceBombs();
			int counter = 0;
			bool explosion = false;
			List<Point> champions = new List<Point>(6);
			int row = 0;
			int column = 0;
			bool isBeginningOfGame = true;
			const int maxPoints = 35;
			bool hasReachedMaxPoints = false;

			do
			{
				if (isBeginningOfGame)
				{
					Console.WriteLine("Let's play MineSweeper. Try your luck and find the cells without mines." +
					" The 'top' command shows the highscore, 'restart' command starts a new game, 'exit' command exits from the game and Goodbye!");
					PrintField(field);
					isBeginningOfGame = false;
				}
				Console.Write("Enter row and col : ");
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
						HighScore(champions);
						break;
					case "restart":
						field = CreateGameField();
						bombs = PlaceBombs();
						PrintField(field);
						explosion = false;
						isBeginningOfGame = false;
						break;
					case "exit":
						Console.WriteLine("Bye,bye,bye!");
						break;
					case "turn":
						if (bombs[row, column] != '*')
						{
							if (bombs[row, column] == '-')
							{
								HandleUserInput(field, bombs, row, column);
								counter++;
							}
							if (maxPoints == counter)
							{
								hasReachedMaxPoints = true;
							}
							else
							{
								PrintField(field);
							}
						}
						else
						{
							explosion = true;
						}
						break;
					default:
						Console.WriteLine("\nError! Invalid command\n");
						break;
				}
				if (explosion)
				{
					PrintField(bombs);
					Console.Write("\nYou died honorably with {0} points. " +
						"Enter nickname: ", counter);
					string nickName = Console.ReadLine();
					Point t = new Point(nickName, counter);
					if (champions.Count < 5)
					{
						champions.Add(t);
					}
					else
					{
						for (int i = 0; i < champions.Count; i++)
						{
							if (champions[i].Points < t.Points)
							{
								champions.Insert(i, t);
								champions.RemoveAt(champions.Count - 1);
								break;
							}
						}
					}
                    champions.Sort((Point r1, Point r2) => r2.Name.CompareTo(r1.Name));
                    champions.Sort((Point r1, Point r2) => r2.Points.CompareTo(r1.Points));
                    HighScore(champions);

					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					explosion = false;
					isBeginningOfGame = true;
				}
				if (hasReachedMaxPoints)
				{
					Console.WriteLine("\nCongrats! You opened 35 cells without a blood drop.");
					PrintField(bombs);
					Console.WriteLine("Enter your name,mate: ");
					string name = Console.ReadLine();
                    Point newPoint = new Point(name, counter);
					champions.Add(newPoint);
					HighScore(champions);
					field = CreateGameField();
					bombs = PlaceBombs();
					counter = 0;
					hasReachedMaxPoints = false;
					isBeginningOfGame = true;
				}
			}
			while (command != "exit");
			Console.WriteLine("Made in Bulgaria - Uauahahahahaha!");
			Console.WriteLine("AREEEEEEeeeeeee.");
			Console.Read();
		}

		private static void HighScore(List<Point> points)
		{
			Console.WriteLine("\nPoints:");
			if (points.Count > 0)
			{
				for (int i = 0; i < points.Count; i++)
				{
					Console.WriteLine("{0}. {1} --> {2} kutii",
						i + 1, points[i].Name, points[i].Points);
				}
				Console.WriteLine();
			}
			else
			{
				Console.WriteLine("Empty highscores!\n");
			}
		}

		private static void HandleUserInput(char[,] field,
			char[,] bombs, int row, int columns)
		{
			char bombsCount = CalculateBombsCount(bombs, row, columns);
			bombs[row, columns] = bombsCount;
			field[row, columns] = bombsCount;
		}

		private static void PrintField(char[,] board)
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
			char[,] playField = new char[rows, columns];

			for (int i = 0; i < rows; i++)
			{
				for (int j = 0; j < columns; j++)
				{
					playField[i, j] = '-';
				}
			}

			List<int> bombsList = new List<int>();
			while (bombsList.Count < 15)
			{
				Random random = new Random();
				int bomb = random.Next(50);
				if (!bombsList.Contains(bomb))
				{
					bombsList.Add(bomb);
				}
			}

			foreach (int bomb in bombsList)
			{
				int col = (bomb / columns);
				int row = (bomb % columns);
				if (row == 0 && bomb != 0)
				{
					col--;
					row = columns;
				}
				else
				{
					row++;
				}
				playField[col, row - 1] = '*';
			}

			return playField;
		}

		private static void LoopThroughFieldElements(char[,] playField)
		{
			int column = playField.GetLength(0);
			int row = playField.GetLength(1);

			for (int i = 0; i < column; i++)
			{
				for (int j = 0; j < row; j++)
				{
					if (playField[i, j] != '*')
					{
                        char bombsCount = CalculateBombsCount(playField, i, j);
						playField[i, j] = bombsCount;
					}
				}
			}
		}

        private static char CalculateBombsCount(char[,] playField, int row, int col)
		{
			int bombsCount = 0;
			int rows = playField.GetLength(0);
			int cols = playField.GetLength(1);

			if (row - 1 >= 0)
			{
				if (playField[row - 1, col] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (row + 1 < rows)
			{
				if (playField[row + 1, col] == '*')
				{ 
					bombsCount++; 
				}
			}
			if (col - 1 >= 0)
			{
				if (playField[row, col - 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if (col + 1 < cols)
			{
				if (playField[row, col + 1] == '*')
				{ 
					bombsCount++;
				}
			}
			if ((row - 1 >= 0) && (col - 1 >= 0))
			{
				if (playField[row - 1, col - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row - 1 >= 0) && (col + 1 < cols))
			{
				if (playField[row - 1, col + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row + 1 < rows) && (col - 1 >= 0))
			{
				if (playField[row + 1, col - 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			if ((row + 1 < rows) && (col + 1 < cols))
			{
				if (playField[row + 1, col + 1] == '*')
				{ 
					bombsCount++; 
				}
			}
			return char.Parse(bombsCount.ToString());
		}
	}
}
