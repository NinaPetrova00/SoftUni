using System;
using System.Collections.Generic;

namespace _10._Crossroads
{
    class Program
    {
        static void Main(string[] args)
        {
            int greenLightSecond = int.Parse(Console.ReadLine());
            int secondsToPass = int.Parse(Console.ReadLine());

            Queue<string> carQueue = new Queue<string>();

            int totalCarsPassed = 0;

            while (true)
            {
                string command = Console.ReadLine();

                int greenLight = greenLightSecond;
                int passSecond = secondsToPass;

                if (command == "END")
                {
                    Console.WriteLine("Everyone is safe.");
                    Console.WriteLine($"{totalCarsPassed} total cars passed the crossroads.");
                    return;
                }

                if (command == "green")
                {
                    while (greenLight > 0 && carQueue.Count > 0)
                    {
                        string firstCarInQueue = carQueue.Dequeue();
                        greenLight -= firstCarInQueue.Length;

                        if (greenLight > 0)
                        {
                            totalCarsPassed++;
                        }
                        else
                        {
                            passSecond += greenLight;

                            if (passSecond < 0)
                            {
                                int hitCarIndex = firstCarInQueue.Length + passSecond;
                                Console.WriteLine($"A crash happened!{ Environment.NewLine}" +
                                  $"{firstCarInQueue} was hit at {firstCarInQueue[hitCarIndex]}.");
                                return;
                            }
                            else
                            {
                                totalCarsPassed++;
                            }
                        }
                    }
                }
                else
                {
                    carQueue.Enqueue(command);
                }
            }
        }
    }
}
