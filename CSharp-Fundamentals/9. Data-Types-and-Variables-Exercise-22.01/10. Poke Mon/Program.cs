using System;

namespace _10._Poke_Mon
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int m = int.Parse(Console.ReadLine());
            int y = int.Parse(Console.ReadLine());

            int orginN = n;
            int target = 0;

          
            while (n >= m)
            {
                n-= m;
                target++;

                if (n ==(orginN * 0.5))
                {
                    if (n != 0 && y != 0 && n > y)
                    {
                        n /= y;
                    }
                    else
                    {
                        n -= m;
                        target++;
                    }
                }
            }
            Console.WriteLine(n);
            Console.WriteLine(target);
        }
    }
}
