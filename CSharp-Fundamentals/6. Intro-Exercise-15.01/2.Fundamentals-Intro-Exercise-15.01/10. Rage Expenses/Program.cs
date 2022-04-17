using System;

namespace _10._Rage_Expenses
{
    class Program
    {
        static void Main(string[] args)
        {
            int lostGamesCount = int.Parse(Console.ReadLine());
            double headsetPrice= double.Parse(Console.ReadLine());
            double mousePrice = double.Parse(Console.ReadLine());
            double keyboardPrice = double.Parse(Console.ReadLine());
            double displayPrice = double.Parse(Console.ReadLine());

            int trashedHeadset = 0;
            int trashedMouse = 0;
            int trashedKeyboard = 0;
            int trashedDisplay = 0;

            for(int i = 1; i <= lostGamesCount; i++)
            {
                if (i%2==0)
                {
                    trashedHeadset++;
                }

                if (i%3==0)
                {
                    trashedMouse++;
                }

                if (i%6==0)
                {
                    trashedKeyboard++;
                }

                if (i%12==0)
                {
                    trashedDisplay++;
                }

            }

            double headsetSum = headsetPrice * trashedHeadset;
            double mouseSum = mousePrice * trashedMouse;
            double keyboardSum = keyboardPrice * trashedKeyboard;
            double displaySum = displayPrice * trashedDisplay;

            double totalSum = headsetSum + mouseSum + keyboardSum + displaySum;
            Console.WriteLine($"Rage expenses: {totalSum:f2} lv.");
        }
    }
}
