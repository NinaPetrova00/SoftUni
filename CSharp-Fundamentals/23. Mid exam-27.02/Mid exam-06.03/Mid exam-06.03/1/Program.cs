using System;

namespace _1
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            double budjet = double.Parse(Console.ReadLine());
            int groupOfPeople = int.Parse(Console.ReadLine());
            double fuelPriceKm = double.Parse(Console.ReadLine());
            double foodPerPerson = double.Parse(Console.ReadLine());
            double roomPrice = double.Parse(Console.ReadLine());


            double foodExpenses = foodPerPerson * groupOfPeople * days;

            double hotelPrice = roomPrice * groupOfPeople * days;

            if (groupOfPeople > 10)
            {
                hotelPrice = hotelPrice - hotelPrice * 0.25;

            }

            double currentExpenses = foodExpenses + hotelPrice;


            double totalFuel = 0.0;

            double totalExpenses;

            bool flag = false;

           // double totalFuel = 0.0;


            for (int i = 1; i <= days; i++)
            {

                double distance = double.Parse(Console.ReadLine());

                double fuelExpensesPerDay = distance * fuelPriceKm;

                currentExpenses += fuelExpensesPerDay;

                if(i==3 || i == 5)
                {
                    double additionalExpenses = 0.40 * currentExpenses;

                    currentExpenses += additionalExpenses;
                }

                if (i == 7)
                {
                    double receivedMoney = currentExpenses / groupOfPeople;

                    currentExpenses -= receivedMoney;

                }


                if (budjet < currentExpenses)
                {
                    Console.WriteLine($"Not enough money to continue the trip. You need {(currentExpenses - budjet):f2}$ more.");
                    flag = true;
                    break;
                }

                fuelExpensesPerDay = 0.0;

            }

            if (!flag)
            {
                Console.WriteLine($"You have reached the destination. You have {(budjet - currentExpenses):f2}$ budjet left.");
            }

        }
    }
}
