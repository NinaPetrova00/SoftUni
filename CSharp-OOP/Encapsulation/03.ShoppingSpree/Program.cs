using System;
using System.Collections.Generic;
using System.Linq;

namespace _03.ShoppingSpree
{
            
    class Program
    {
        static void Main(string[] args)
        {
            List<Person> persons = new List<Person>();
            List<Product> products = new List<Product>();

            try
            {
                var personTokens = Console.ReadLine()
                 .Split(";", StringSplitOptions.RemoveEmptyEntries)
                 .ToArray();

                for (int i = 0; i < personTokens.Length; i++)
                {
                    var parts = personTokens[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    string personName = parts[0];
                    double personMoney = double.Parse(parts[1]);

                    Person person = new Person(personName, personMoney);
                    persons.Add(person);
                }

                var productTokens = Console.ReadLine()
                     .Split(";", StringSplitOptions.RemoveEmptyEntries)
                     .ToArray();

                for (int i = 0; i < productTokens.Length; i++)
                {
                    var parts = personTokens[i]
                        .Split("=", StringSplitOptions.RemoveEmptyEntries);

                    string productName = parts[0];
                    double productPrice = double.Parse(parts[1]);

                    Product product = new Product(productName, productPrice);
                    products.Add(product);
                }
            }
            catch (Exception ex)
            {

                Console.WriteLine(ex.Message);
            }

        }
    }
}
