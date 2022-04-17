using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class StartUp
    {
        static void Main(string[] args)
        {
            var guests = new Queue<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            var plates = new Stack<int>(Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse));

            int wastedFood = 0;

            //Stack<int> resultPlates = new Stack<int>();
            //Queue<int> resultGuests = new Queue<int>();
          
            while (guests.Count > 0 && plates.Count > 0)
            {
                var lastPlate = plates.Peek();
                var firstGuestCapacity = guests.Peek();
                

                if (firstGuestCapacity <= 0)
                {
                    guests.Dequeue();
                }
                else if (firstGuestCapacity > lastPlate)
                {
                    firstGuestCapacity -= lastPlate;
              
                    plates.Pop();

                    
                    if (firstGuestCapacity > lastPlate)
                    {
                        while (firstGuestCapacity > 0)
                        {
                            lastPlate = plates.Peek();
                            firstGuestCapacity -= lastPlate;
                            plates.Pop();
                        }
                    }

                    if (lastPlate >= firstGuestCapacity)
                    {
                        wastedFood += (lastPlate - firstGuestCapacity);
                      
                        guests.Dequeue();
                        plates.Pop();                    
                    }

                    if (firstGuestCapacity == 0)
                    {
                        guests.Dequeue(); // firstGuestCapacity = 0  
                    }

                }
                else if (lastPlate >= firstGuestCapacity)
                {
                    wastedFood += (lastPlate - firstGuestCapacity);
                   

                    guests.Dequeue();
                    plates.Pop();               
                }
            }

            if (guests.Count <= 0)
            {
                Console.Write($"Plates: ");
                Console.WriteLine(string.Join(" ", plates));
            }
            else if (plates.Count <= 0)
            {
                Console.Write($"Guests: ");
                Console.WriteLine(string.Join(" ", guests));
            }

            Console.WriteLine($"Wasted grams of food: {wastedFood}");
        }
    }
}
