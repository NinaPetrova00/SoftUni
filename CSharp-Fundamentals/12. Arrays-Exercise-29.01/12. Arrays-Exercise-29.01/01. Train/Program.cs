﻿using System;
using System.Linq;

namespace _01._Train
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            int[] arr = new int[n];

            int sum = 0;

            for (int i = 0; i < arr.Length; i++)
            {
                int num = int.Parse(Console.ReadLine());
                arr[i] = num;
                sum += num;
            }
            Console.WriteLine(string.Join(' ',arr));
            Console.WriteLine(sum);
        }
    }
}
