using System;
using System.Linq;

namespace _09._Kamino_Factory
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());

            int bestSequenceSize = 0;
            int bestSequenceStartingIndex = 0;
            int bestSequenceSum = 0;

            int[] bestSequence = new int[size];

            int bestSample = 1;

            int sampleCount = 0;

            while (true)
            {
                string line = Console.ReadLine();
                sampleCount++;

                if (line == "Clone them!")
                {
                    break;
                }

                int[] arr = line
                    .Split('!', StringSplitOptions.RemoveEmptyEntries)
                    .Select(int.Parse)
                    .ToArray();

                int sequenceSum = 0;
                for (int i = 0; i < arr.Length; i++)
                {
                    sequenceSum += arr[i];
                }

                for (int i = 0; i < arr.Length; i++)
                {
                    int currentNumber = arr[i];

                    if (currentNumber == 0)
                    {
                        continue;
                    }

                    int currentSequenceSize = 1;

                    for (int j = i + 1; j < arr.Length; j++)
                    {
                        if (currentNumber == arr[j])
                        {
                            currentSequenceSize++;
                        }
                        else
                        {
                            break;
                        }
                    }

                    if (currentSequenceSize>bestSequenceSize)
                    {
                        bestSequenceSize = currentSequenceSize;
                        bestSequenceStartingIndex = i;
                        bestSequenceSum = sequenceSum;
                        bestSequence = arr;
                        bestSample = sampleCount;
                    }
                    else if(currentSequenceSize==bestSequenceSize)
                    {
                        if (i < bestSequenceStartingIndex)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = arr;
                            bestSample = sampleCount;
                        }
                        else if (i == bestSequenceStartingIndex&&sequenceSum>bestSequenceSum)
                        {
                            bestSequenceSize = currentSequenceSize;
                            bestSequenceStartingIndex = i;
                            bestSequenceSum = sequenceSum;
                            bestSequence = arr;
                            bestSample = sampleCount;
                        }
                    }
                }
            }

            Console.WriteLine($"Best DNA sample {bestSample} with sum: {bestSequenceSum}.");
            Console.WriteLine(string.Join(" ", bestSequence));
        }
    }
}
