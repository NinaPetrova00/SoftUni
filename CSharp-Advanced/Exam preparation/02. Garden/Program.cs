using System;

namespace _02._Garden
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] parts = Console.ReadLine().Split(" ", StringSplitOptions.RemoveEmptyEntries);
            int N = int.Parse(parts[0]);
            int M = int.Parse(parts[1]);

            int[,] garden = new int[N, M];

            for (int row = 0; row < N; row++)
            {
                for (int col = 0; col < M; col++)
                {
                    garden[row, col] = 0;
                }
            }

            while (true)
            {
                string tokens = Console.ReadLine();

                if (tokens == "Bloom Bloom Plow")
                {
                    break;
                }

                int row = int.Parse(tokens[0].ToString());
                int col = int.Parse(tokens[2].ToString());

                if (row < 0 || row > garden.GetLongLength(0) && col < 0 || col > garden.GetLongLength(1))
                {
                    Console.WriteLine("Invalid coordinates.");
                    continue;
                }

                for (int i = 0; i < garden.GetLongLength(0); i++)
                {
                    garden[row, i]++;
                }

                for (int i = 0; i < garden.GetLongLength(1); i++)
                {
                    garden[i, col]++;
                }

                garden[row, col]--;
            }
            for (int i = 0; i < N; i++)
            {
                for (int j = 0; j < M; j++)
                {
                    Console.Write(garden[i,j]+" ");
                }
                Console.WriteLine();
            }
        }
    }
}
