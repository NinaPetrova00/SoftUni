using System;
using System.Text;

namespace _07._Repeat_String
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = Console.ReadLine();
            int a = int.Parse(Console.ReadLine());

            Console.WriteLine(Repeat(str,a));

               
        }

        static string Repeat(string str,int num)
        {

            StringBuilder result = new StringBuilder();

            for(int i = 0; i < num; i++)
            {
                result.Append(str);
            }
            return result.ToString();
        }
    }
}
