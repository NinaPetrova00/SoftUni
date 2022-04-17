using System;

namespace _02._Vowels_Count
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();

            Console.WriteLine(Vowels(str));
        }

        static int Vowels(string str)
        {
            str= str.ToLower();
            int counter = 0;

            foreach (char letter in str)
            {
                if (letter == 'a'
                    || letter == 'e'
                    || letter =='o'
                    || letter=='y'
                    || letter=='u'
                    || letter == 'i')
                {
                    counter++;
                }
            }
            return counter;
           
        }
    }
}
