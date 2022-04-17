using System;

namespace _09._Padawan_Equipment
{
    class Program
    {
        static void Main(string[] args)
        {
            double amountMoney = double.Parse(Console.ReadLine());
            int studentsCount = int.Parse(Console.ReadLine());
            double lightsabersPrice = double.Parse(Console.ReadLine());
            double robesPrice = double.Parse(Console.ReadLine());
            double beltsPrice = double.Parse(Console.ReadLine());


            int lightsabersCount = (int)Math.Ceiling(studentsCount * 1.1);

            int beltsCount = studentsCount - studentsCount / 6;

            double totalPrice = lightsabersPrice * lightsabersCount +
                                 robesPrice * studentsCount +
                                    beltsPrice * beltsCount;
             
            if (totalPrice <= amountMoney)
            {
                Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
            }
            else
            {
                Console.WriteLine($"Ivan Cho will need {(totalPrice - amountMoney):f2}lv more.");
            }
        }
    }
}
