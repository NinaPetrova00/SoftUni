using System;
using System.Linq;
using _03.Telephony.Models;
using _03.Telephony.Exceptions;

namespace _03.Telephony
{
    public class StartUp
    {
        static void Main(string[] args)
        {
            string[] phoneNumbers = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            string[] urls = Console.ReadLine()
                  .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                  .ToArray();

            Smartphone smartphone = new Smartphone();
            StationaryPhone stationaryPhone = new StationaryPhone();

            for (int i = 0; i < phoneNumbers.Length; i++)
            {
                string currentPhoneNumber = phoneNumbers[i];

                try
                {
                    if (currentPhoneNumber.Length == 7)
                    {
                        Console.WriteLine(stationaryPhone.Call(currentPhoneNumber));
                    }
                    else if (currentPhoneNumber.Length == 10)
                    {
                        Console.WriteLine(smartphone.Call(currentPhoneNumber));
                    }
                }
                catch (InvalidPhoneNumberException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }

            for (int i = 0; i < urls.Length; i++)
            {
                string currentURL = urls[i];

                try
                {
                    Console.WriteLine(smartphone.Browse(currentURL));
                }
                catch (InvalidURLException ex)
                {

                    Console.WriteLine(ex.Message);
                }
            }
        }
    }
}
