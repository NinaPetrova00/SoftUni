using System;

namespace _06._Store_Boxes
{

    class Item
    {
        public string Name { get; set; }

        public double Price { get; set; }
    }

    class Box
    {
        public Box()
        {
            Item = new Item();
        }

       
        public int SerialNumber { get; set; }

        public Item Item { get; set; }

        public int ItemQuantity { get; set; }

        public int PricePerBox { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }

                string[] parts = line.Split();

                int serialNumber = int.Parse(parts[0]);
                string itemName = parts[1];
                int itemQuantity= int.Parse(parts[2]);
                int itemPrice= int.Parse(parts[3]);

                double totalPrice = itemPrice * itemQuantity;


            }
        }
    }
}
