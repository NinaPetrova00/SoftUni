using System;
using System.Collections.Generic;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
            /* Task 3 and 4
            { var numberOfLines = int.Parse(Console.ReadLine());
             var list = new List<int>();

             for (int i = 0; i < numberOfLines; i++)
             {
                 var input = int.Parse(Console.ReadLine());
                 list.Add(input);
             }

             var box = new Box<int>(list);
             var indexes = Console.ReadLine()
                 .Split()
                 .Select(int.Parse)
                 .ToArray();

             box.Swap(list, indexes[0], indexes[1]);

             Console.WriteLine(box); } */


            /*Task 5 and 6*/
            //var numberOfLines = int.Parse(Console.ReadLine());
            //var list = new List<double>();

            //for (int i = 0; i < numberOfLines; i++)
            //{
            //    var input = double.Parse(Console.ReadLine());
            //    list.Add(input);
            //}

            //var box = new Box<double>(list);
            //var elementToCompare = double.Parse(Console.ReadLine());
            //var count = box.CountOfGreaterElements(list, elementToCompare);
            //Console.WriteLine(count);

            /*Task 7*/
            //var personInfo = Console.ReadLine().Split();
            //var fullName = $"{personInfo[0]} {personInfo[1]}";
            //var city = $"{personInfo[2]}";

            //var nameAndBeer = Console.ReadLine().Split();
            //var name = nameAndBeer[0];
            //var numberOfLitters = int.Parse(nameAndBeer[1]);

            //var numbersInput = Console.ReadLine().Split();
            //var intNum = int.Parse(numbersInput[0]);
            //var doubleNum = double.Parse(numbersInput[1]);

            //Tuple<string, string> firstTuple = new Tuple<string, string>(fullName, city);
            //Tuple<string, int> secondTuple = new Tuple<string, int>(name, numberOfLitters);
            //Tuple<int, double> thirdTuple = new Tuple<int, double>(intNum, doubleNum);

            //Console.WriteLine(firstTuple);
            //Console.WriteLine(secondTuple);
            //Console.WriteLine(thirdTuple);

            /*Task 8*/
            var personInfo = Console.ReadLine().Split();
            var fullName = $"{personInfo[0]} {personInfo[1]}";
            var city = $"{personInfo[2]}";
            //  var town = $"{personInfo[3]} {personInfo[4]}";
            var town = $"{personInfo[3]}";

            var nameAndBeer = Console.ReadLine().Split();
            var name = nameAndBeer[0];
            var numberOfLitters = int.Parse(nameAndBeer[1]);
            var drunk = nameAndBeer[2];

            bool isDrunk;
            if (drunk == "drunk")
            {
                isDrunk = true;
            }
            else
            {
                isDrunk = false;
            }

            var bank = Console.ReadLine().Split();
            var userName = bank[0];
            var balance = double.Parse(bank[1]);
            var bankName = bank[2];

            Tuple<string, string,string> firstTuple = new Tuple<string, string,string>(fullName, city,town);
            Tuple<string, int, bool> secondTuple = new Tuple<string, int, bool>(name, numberOfLitters, isDrunk);
            Tuple<string,double, string> thirdTuple = new Tuple<string, double, string>(userName,balance, bankName);

            Console.WriteLine(firstTuple);
            Console.WriteLine(secondTuple);
            Console.WriteLine(thirdTuple);
        }
    }
}
