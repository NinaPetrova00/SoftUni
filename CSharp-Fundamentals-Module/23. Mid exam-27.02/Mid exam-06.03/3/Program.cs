using System;
using System.Collections.Generic;
using System.Linq;

namespace _3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> products = Console.ReadLine()
                   .Split("|", StringSplitOptions.RemoveEmptyEntries)
                   .ToList();

            while (true)
            {
                string line = Console.ReadLine();

                if (line == "Shop!")
                {
                    break;
                }

                string[] parts = line.Split("%", StringSplitOptions.RemoveEmptyEntries);

                string command = parts[0];

                string product = parts[1];

                if (command == "Important")
                {
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                    products.Insert(0, product);

                }
                else if (command == "Add")
                {
                    if (products.Contains(product))
                    {
                        Console.WriteLine($"The product is already in the list.");
                    }
                    else
                    {
                        products.Add(product);
                    }
                }
                else if (command == "Swap")
                {
                    string secondProduct = parts[2];

                    if (products.Contains(product) && products.Contains(secondProduct))
                    {
                        /*int index1 = products.IndexOf(product);
                        int index2 = products.IndexOf(secondProduct);

                        products.Remove(product);
                        products.Remove(secondProduct);

                        int tmp = index1;
                        index1 = index2;
                        index2 = index1;

                        products.Insert(index2, secondProduct);
                        products.Insert(index1, product);
                        */
                        string temp = product;
                        product = secondProduct;
                        secondProduct = product;

                    }
                    else if (!products.Contains(product))
                    {
                        Console.WriteLine($"Product {product} missing!");
                    }
                    else if (!products.Contains(secondProduct))
                    {
                        Console.WriteLine($"Product {secondProduct} missing!");
                    }
                }
                else if (command == "Remove")
                {
                    if (products.Contains(product))
                    {
                        products.Remove(product);
                    }
                    else
                    {
                        Console.WriteLine($"Product {product} isn't in the list.");
                    }
                }
            }

            int n = 1;

            for (int i = 0; i < products.Count; i++)
            {
                Console.WriteLine($"{n}. {products[i]}");
                n++;
            }



        }

    }
}

