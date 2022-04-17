using System;
using System.Linq;

namespace _02.Survivor
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            char[][] arr = new char[n][];

            for (int i = 0; i < n; i++)
            {
                char[] tokens = Console.ReadLine()
                   .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .Select(char.Parse)
                   .ToArray();
                arr[i] = tokens;
            }

            int collectedTokens = 0;
            int opponentTokens = 0;
            while (true)
            {
                string[] parts = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                   .ToArray();

                string command = parts[0];

                if (command == "Gong")
                {
                    break;
                }

                int row = int.Parse(parts[1]);
                int col = int.Parse(parts[2]);

                bool flag = row >= 0 && row < arr.Length && col >= 0 && col < arr[row].Length;

                if (command == "Find")
                {

                    if (flag)
                    {
                        if (arr[row][col] == 'T')
                        {
                            collectedTokens++;
                            arr[row][col] = '-';
                        }
                        else
                        {
                            opponentTokens++;
                        }
                    }

                }
                else if (command == "Opponent")
                {
                    string direciton = parts[3];

                    if (flag)
                    {
                        if (arr[row][col] == 'T')
                        {
                            // collectedTokens++;
                            opponentTokens++;
                            arr[row][col] = '-';
                        }
                        else
                        {
                            opponentTokens++;
                        }

                    }
                
                    for (int i = 0; i < 3; i++)
                    {
                        if (direciton == "up")
                        {

                            if (row - 1 >= 0 && row - 1 < arr.Length && col >= 0 && col < arr[row].Length)
                            {
                                row--;
                                if (arr[row][col] == 'T')
                                {
                                    //   collectedTokens++;
                                    arr[row][col] = '-';
                                }
                                else
                                {
                                    opponentTokens++;
                                }
                            }

                        }
                        else if (direciton == "down")
                        {

                            if (row + 1 >= 0 && row + 1 < arr.Length && col >= 0 && col < arr[row].Length)
                            {
                                row++;
                                if (arr[row][col] == 'T')
                                {
                                    //   collectedTokens++;
                                    arr[row][col] = '-';
                                }
                                else
                                {
                                    opponentTokens++;
                                }
                            }

                        }
                        else if (direciton == "left")
                        {

                            if (row >= 0 && row < arr.Length && col - 1 >= 0 && col - 1 < arr[row].Length)
                            {
                                col--;
                                if (arr[row][col] == 'T')
                                {
                                    //  collectedTokens++;
                                    arr[row][col] = '-';
                                }
                                else
                                {
                                    opponentTokens++;
                                }
                            }

                        }
                        else if (direciton == "right")
                        {
                            if (row >= 0 && row < arr.Length && col + 1 >= 0 && col + 1 < arr[row].Length)
                            {
                                col++;
                                if (arr[row][col] == 'T')
                                {
                                    // collectedTokens++;
                                    arr[row][col] = '-';
                                }
                                else
                                {
                                    opponentTokens++;
                                }
                            }
                        }
                    }

                }
            }
            foreach (var element in arr)
            {
                Console.WriteLine(string.Join(" ", element));
            }
            Console.WriteLine($"Collected tokens: {collectedTokens}");
            Console.WriteLine($"Opponent's tokens: {opponentTokens}");

        }
    }
}
