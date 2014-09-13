using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _06.Horse
{
    class Program
    {
        static void Main()
        {
            int N = int.Parse(Console.ReadLine());
            string[,] matrix = new string[N, N];
            int posRow = 0;
            int posCol = 0;

            for (int i = 0; i < N; i++)
            {
                string[] currLine = Console.ReadLine().Split(new char[]{' '},StringSplitOptions.RemoveEmptyEntries);

                for (int j = 0; j < currLine.Length; j++)
                {
                    matrix[i, j] = currLine[j];

                    if (currLine[j] == "s")
                    {
                        posRow = i;
                        posCol = j;
                    }
                }
            }

            Queue<Cell> queue = new Queue<Cell>();
            Cell startCell = new Cell(posRow, posCol, 0);
            bool[,] usedCells = new bool[N, N];

            queue.Enqueue(startCell);

            while (queue.Count > 0)
            {
                Cell cell = queue.Dequeue();

                if (matrix[cell.Row, cell.Col] == "e")
                {
                    Console.WriteLine(cell.QueueLevel);
                    return;
                }

                //go one right, two down
                if (cell.Col < N - 1 && cell.Row < N - 2)
                {
                    int newRow = cell.Row + 2;
                    int newCol = cell.Col + 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go one left, two down
                if (cell.Col > 0 && cell.Row < N - 2)
                {
                    int newRow = cell.Row + 2;
                    int newCol = cell.Col - 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two right, one down
                if (cell.Col < N - 2 && cell.Row < N - 1)
                {
                    int newRow = cell.Row + 1;
                    int newCol = cell.Col + 2;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two left, one down
                if (cell.Col > 1 && cell.Row < N - 1)
                {
                    int newRow = cell.Row + 1;
                    int newCol = cell.Col - 2;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two down, one right
                if (cell.Col < N - 1 && cell.Row < N - 2)
                {
                    int newRow = cell.Row + 2;
                    int newCol = cell.Col + 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two down, one left
                if (cell.Col > 0 && cell.Row < N - 2)
                {
                    int newRow = cell.Row + 2;
                    int newCol = cell.Col - 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }

                //go one right, two up
                if (cell.Col < N - 1 && cell.Row > 1)
                {
                    int newRow = cell.Row - 2;
                    int newCol = cell.Col + 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go one left, two up
                if (cell.Col > 0 && cell.Row > 1)
                {
                    int newRow = cell.Row - 2;
                    int newCol = cell.Col - 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two right, one up
                if (cell.Col < N - 2 && cell.Row > 0)
                {
                    int newRow = cell.Row - 1;
                    int newCol = cell.Col + 2;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two left, one up
                if (cell.Col > 1 && cell.Row > 0)
                {
                    int newRow = cell.Row - 1;
                    int newCol = cell.Col - 2;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two up, one right
                if (cell.Col < N - 1 && cell.Row > 1)
                {
                    int newRow = cell.Row - 2;
                    int newCol = cell.Col + 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
                //go two up, one left
                if (cell.Col > 0 && cell.Row > 1)
                {
                    int newRow = cell.Row - 2;
                    int newCol = cell.Col - 1;

                    var newCell = new Cell(newRow, newCol, cell.QueueLevel + 1);

                    if (!(usedCells[newRow, newCol]) && matrix[newRow, newCol] != "x")
                    {
                        usedCells[newRow, newCol] = true;
                        queue.Enqueue(newCell);
                    }

                }
            }

            Console.WriteLine(-1);
            return;
        }

        class Cell
        {
            public int Row { get; set; }

            public int Col { get; set; }

            public int QueueLevel { get; set; }

            public Cell(int row, int col, int queueLevel)
            {
                this.Row = row;
                this.Col = col;
                this.QueueLevel = queueLevel;
            }
        }
    }
}
