using System;
using System.Linq;

namespace _02.Super_Mario
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int marioLives = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];
            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int marioRow = 0;
            int marioCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'M')
                    {
                        marioRow = row;
                        marioCol = col;
                    }
                }
            }

            while (true)
            {
                var command = Console.ReadLine().Split().Select(char.Parse).ToArray();

                matrix[marioRow, marioCol] = '-';

                marioLives--;

                marioRow = MoveRow(marioRow, command);
                marioCol = MoveCol(marioCol, command);
              

                if (matrix[marioRow, marioCol] == 'B')
                {
                    marioLives--;
                    // matrix[marioRow, marioCol] = '-';
                    if (marioLives <= 0)
                    {
                        matrix[marioRow, marioCol] = 'X';
                        Console.WriteLine($"Mario died at {marioRow};{marioCol}.");
                        break;
                    }
                }

                if (matrix[marioRow, marioCol] == 'P')
                {
                    matrix[marioRow, marioCol] = '-';
                    Console.WriteLine($"Mario has successfully saved the princess! Lives left: {marioLives}");
                    break;
                }

                if (!IsPositonValid(marioRow, marioCol, n, n))
                {
                    continue;
                }

                matrix[marioRow, marioCol] = 'M';
            }

            //print matrix
            for (int row = 0; row < matrix.GetLength(0); row++)
            {
                for (int col = 0; col < matrix.GetLength(1); col++)
                {
                    Console.Write(matrix[row, col]);
                }
                Console.WriteLine();
            }
        }

        public static int MoveRow(int row, char[] movement)
        {
            char direction = movement[0];

            if (direction == 'W') //up
            {
                return row - 1;
            }

            if (direction == 'S') //down
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, char[] movement)
        {
            char direction = movement[0];
            if (direction == 'A') //left
            {
                return col - 1;
            }

            if (direction == 'D') //right
            {
                return col + 1;
            }

            return col;
        }
        public static bool IsPositonValid(int row, int col, int rows, int cols)
        {
            if (row < 0 || row >= rows)
            {
                return false;
            }

            if (col < 0 || col >= cols)
            {
                return false;
            }

            return true;
        }
    }
}
