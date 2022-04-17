using System;

namespace _02._Common_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] firstArr = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            string[] secondArr = Console.ReadLine()
            .Split(' ', StringSplitOptions.RemoveEmptyEntries);

            for (int j = 0; j < secondArr.Length; j++)
            {
                for (int i = 0; i < firstArr.Length; i++)
                {
                    if (firstArr[i] == secondArr[j])
                    {
                        Console.Write($"{firstArr[i]} ");
                        break;
                    }
                }
            }
        }
    }
}
