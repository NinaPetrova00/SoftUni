<<<<<<< HEAD
﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
       

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
=======
﻿using System;
using System.Collections.Generic;

namespace Generics
{
    class StartUp
    {
        static void Main(string[] args)
        {
       

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
>>>>>>> c1e42c0d51d56461dd637297dfe6ffd4191f2936
