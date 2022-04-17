using System;

namespace _03._Vacation
{
    class Program
    {
        static void Main(string[] args)
        {
            int countOfPeople = int.Parse(Console.ReadLine());
            string typeOfPeople = Console.ReadLine();
            string day = Console.ReadLine();


            double pricePerDay = 0;
            double discountPercentage = 0;

            if (day == "Friday")
            {
                switch (typeOfPeople)
                {
                    case "Students":
                        if (countOfPeople >= 30)
                        {
                            discountPercentage = 15;
                        }
                        pricePerDay = 8.45;
                        break;

                    case "Business":
                        if (countOfPeople >= 100)
                        {
                            countOfPeople -= 10;
                        }
                        pricePerDay = 10.9;
                        break;

                    default:
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            discountPercentage = 5;
                        }
                        pricePerDay = 15;
                        break;
                }

            }
            else if (day == "Saturday")
            {
                switch (typeOfPeople)
                {
                    case "Students":
                        if (countOfPeople >= 30)
                        {
                            discountPercentage = 15;
                        }
                        pricePerDay = 9.8;
                        break;

                    case "Business":
                        if (countOfPeople >= 100)
                        {
                            countOfPeople -= 10;
                        }
                        pricePerDay = 15.6;
                        break;

                    default:
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            discountPercentage = 5;
                        }
                        pricePerDay = 20;
                        break;
                }
            }
            else if (day == "Sunday")
            {
                switch (typeOfPeople)
                {
                    case "Students":
                        if (countOfPeople >= 30)
                        {
                            discountPercentage = 15;
                        }
                        pricePerDay = 10.46;
                        break;

                    case "Business":
                        if (countOfPeople >= 100)
                        {
                            countOfPeople -= 10;
                        }
                        pricePerDay = 16;
                        break;

                    default:
                        if (countOfPeople >= 10 && countOfPeople <= 20)
                        {
                            discountPercentage = 5;
                        }
                        pricePerDay = 22.5;
                        break;
                }
            }

            double totalPrice = countOfPeople * pricePerDay;

            if (discountPercentage != 0)
            {
                totalPrice -= totalPrice * discountPercentage / 100;
            }

            Console.WriteLine($"Total price: {totalPrice:F2}");
        }
    }
}
