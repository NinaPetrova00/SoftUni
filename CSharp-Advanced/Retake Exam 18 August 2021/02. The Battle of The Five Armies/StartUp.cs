using System;
using System.Linq;

namespace _02._The_Battle_of_The_Five_Armies
{
    class StartUp
    {
        static void Main(string[] args)
        {
            int armor = int.Parse(Console.ReadLine());
            int n = int.Parse(Console.ReadLine());

            char[,] matrix = new char[n, n];

            bool win = false;

            //read matrix 
            for (int row = 0; row < n; row++)
            {
                string currentRow = Console.ReadLine();

                for (int col = 0; col < currentRow.Length; col++)
                {
                    matrix[row, col] = currentRow[col];
                }
            }

            int armyRow = 0;
            int armyCol = 0;

            for (int row = 0; row < n; row++)
            {
                for (int col = 0; col < n; col++)
                {
                    if (matrix[row, col] == 'A')
                    {
                        armyRow = row;
                        armyCol = col;
                    }
                }
            }

            while (true)
            {
                matrix[armyRow, armyCol] = '-';

                string[] input = Console.ReadLine()
               .Split(' ', StringSplitOptions.RemoveEmptyEntries)
               .ToArray();


                string direction = input[0];
                int spawnRow = int.Parse(input[1]);
                int spawnCol = int.Parse(input[2]);

                matrix[spawnRow, spawnCol] = 'O';

                armyRow = MoveRow(armyRow, direction);
                armyCol = MoveCol(armyCol, direction);

                armor--;

                if (!IsPositonValid(armyRow, armyCol, n, n))
                {
                    //TODO
                    continue;
                }

                if (matrix[armyRow, armyCol] == 'M')
                {
                    //win
                    matrix[armyRow, armyCol] = '-';
                    win = true;
                    break;
                }

                if (matrix[armyRow, armyCol] == 'O')
                {
                    //enemy 
                    armor -= 2;

                    if (armor <= 0)
                    {
                        matrix[armyRow, armyCol] = 'X';
                        break;
                    }
                }

                if (armor <= 0)
                {
                    matrix[armyRow, armyCol] = 'X';
                    break;
                }


                matrix[armyRow, armyCol] = 'A';
            }


            if (win)
            {
                Console.WriteLine($"The army managed to free the Middle World! Armor left: {armor}");
            }

            if (armor <= 0)
            {
                Console.WriteLine($"The army was defeated at {armyRow};{armyCol}.");
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

        public static int MoveRow(int row, string movement)
        {
            if (movement == "up")
            {
                return row - 1;
            }

            if (movement == "down")
            {
                return row + 1;
            }

            return row;
        }

        public static int MoveCol(int col, string movement)
        {
            if (movement == "left")
            {
                return col - 1;
            }

            if (movement == "right")
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