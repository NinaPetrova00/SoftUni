using System;
using System.Linq;

namespace _11._Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                string command = parts[0];

                if (command == "exchange")
                {
                    int index = int.Parse(parts[1]);
                    Exchange(numbers, index);
                }

              else  if (command == "max")
                {

                    string numType = parts[1];
                    int index = Max(numbers, numType);

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

               else if (command == "min")
                {
                    string numType = parts[1];
                    int index = Min(numbers, numType);

                    if (index == -1)
                    {
                        Console.WriteLine("No matches");
                    }
                    else
                    {
                        Console.WriteLine(index);
                    }
                }

              else  if (command == "first")
                {
                    int count = int.Parse(parts[1]);
                    string numType = parts[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] firstElement = First(numbers, count, numType);

                   

                    PrintArray(firstElement);
                }

               else if (command == "last")
                {

                    int count = int.Parse(parts[1]);
                    string numType = parts[2];

                    if (count > numbers.Length)
                    {
                        Console.WriteLine("Invalid count");
                        continue;
                    }

                    int[] lastElement = Last(numbers, count, numType);

                    PrintArray(lastElement);
                }
            }
            Console.WriteLine($"[{string.Join(", ",numbers)}]");
        }

        private static void PrintArray(int[] elements)
        {
            Console.Write("[");
            bool printed = false;

            foreach (var element in elements)
            {
                if (element != -1)
                {
                    if (printed)
                    {
                        Console.Write($", {element}");
                    }
                    else
                    {
                        Console.Write($"{element}");
                        printed = true;
                    }
                }
            }
            Console.WriteLine("]");
        }

        static void Exchange(int[] arr, int index)
        {
            if (index < 0 || index >= arr.Length)
            {
                Console.WriteLine("Invalid index");
                return;
            }

            for (int rotations = 0; rotations <= index; rotations++)
            {
                int firstNumber = arr[0];

                for (int i = 1; i < arr.Length; i++)
                {
                    arr[i - 1] = arr[i];
                }
                arr[arr.Length - 1] = firstNumber;
            }
        }


        static int Max(int[] arr, string numType)
        {

            int maxNumber = int.MinValue;
            int maxIndex = -1;

            int parity = GetParity(numType);

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] >= maxNumber && arr[i] % 2 == parity)
                {
                    maxNumber = arr[i];
                    maxIndex = i;
                }

            }
            return maxIndex;
        }


        static int Min(int[] arr, string numType)
        {
            int parity = GetParity(numType);

            int minNumber = int.MaxValue;
            int minIndex = -1;

            for (int i = 0; i < arr.Length; i++)
            {

                if (arr[i] <= minNumber && arr[i] % 2 == parity)
                {
                    minNumber = arr[i];
                    minIndex = i;
                }
            }
            return minIndex;
        }


        static int[] First(int[] arr, int count, string numType)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(numType);

            int index = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] % 2 == parity)
                {
                    result[index] = arr[i];
                    index++;

                    if (index >= result.Length)
                    {
                        break;
                    }
                }
            }
            return result;
        }

        private static int GetParity(string parameter)
        {
            if (parameter == "even")
            {
                return 0;
            }
            else
            {
                return 1;
            }

        }



        static int[] Last(int[] arr, int count, string numType)
        {
            int[] result = new int[count];

            for (int i = 0; i < result.Length; i++)
            {
                result[i] = -1;
            }

            int parity = GetParity(numType);

            int index = 0;

            for (int i = arr.Length-1; i >=0; i--)
            {
                if (arr[i] % 2 == parity)
                {
                    result[index] = arr[i];
                    index++;

                    if (index >= result.Length)
                    {
                        break;
                    }
                }
            }
            return result.Reverse().ToArray();
        }


    }
}
