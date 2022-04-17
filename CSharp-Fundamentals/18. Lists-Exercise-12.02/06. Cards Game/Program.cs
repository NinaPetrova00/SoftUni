using System;
using System.Collections.Generic;
using System.Linq;

namespace _06._Cards_Game
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> firstPlayer = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();

            List<int> secondPlayer = Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse)
                 .ToList();


            while (true)
            {

                int currentFirstCard = firstPlayer[0];
                int currentSecondCard = secondPlayer[0];

                if (currentFirstCard > currentSecondCard)
                {         
                    firstPlayer.Add(currentFirstCard);
                    firstPlayer.Add(currentSecondCard);
                
                }
                else if (currentFirstCard < currentSecondCard)
                {         
                    secondPlayer.Add(currentSecondCard);
                    secondPlayer.Add(currentFirstCard);
 
                }
               
                    firstPlayer.Remove(currentFirstCard);
                    secondPlayer.Remove(currentSecondCard);
               
                if (firstPlayer.Count == 0)
                {
                    int sum = secondPlayer.Sum();
                    Console.WriteLine($"Second player wins! Sum: {sum}");
                    break;

                }
                else if (secondPlayer.Count == 0)
                {
                    int sum = firstPlayer.Sum();
                    Console.WriteLine($"First player wins! Sum: {sum}");
                    break;
                }
               
            }
       
        }
    }
}
