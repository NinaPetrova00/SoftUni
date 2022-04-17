using System;
using System.Collections.Generic;
using System.Linq;

namespace _01.Warm_Winter
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var hats = new Stack<int>(Console.ReadLine()
                 .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse));

            var scarfs = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                 .Select(int.Parse));

            int set = 0;        

            Queue<int> setQueue = new Queue<int>();

            while (hats.Count > 0 && scarfs.Count > 0)
            {
                var lastHat = hats.Peek();
                var firstScarf = scarfs.Peek();
                if (lastHat > firstScarf)
                {
                    //set = 0;
                    set = lastHat + firstScarf;
                    setQueue.Enqueue(set);
                    hats.Pop();
                    scarfs.Dequeue();
                }
                else if (lastHat < firstScarf)
                {
                    hats.Pop();
                }
                else //equal
                {
                    scarfs.Dequeue();
                    hats.Pop();
                    lastHat++;
                    hats.Push(lastHat);
                }
            }

            Console.WriteLine($"The most expensive set is: {setQueue.Max()}");
            Console.WriteLine(string.Join(" ",setQueue));
        }
    }
}
