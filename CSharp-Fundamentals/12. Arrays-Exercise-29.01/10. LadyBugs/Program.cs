using System;
using System.Linq;

namespace _10._LadyBugs
{
    class Program
    {
        static void Main(string[] args)
        {
            int fieldSize = int.Parse(Console.ReadLine());

            bool[] field = new bool[fieldSize];//вс клетки са false 


            int[] intialIndexes = Console.ReadLine()
                .Split(' ', StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            foreach (var index in intialIndexes)
            {
                if (index < 0 || index >= field.Length )
                {
                    continue;
                }
                field[index] = true; //на тая клетка има калинка 
            }


            while (true)
            {
                string line = Console.ReadLine();

                if (line == "end")
                {
                    break;
                }
                string[] parts = line.Split();

                int index = int.Parse(parts[0]);
                string direction = parts[1];
                int lenght = int.Parse(parts[2]);

                if (index < 0 || index >= field.Length||field[index]==false)
                {
                    continue;
                }

                field[index] = false;

                //index + lenght -> filled cell
                while (true)
                {
                    if (direction == "right")
                    {
                        index += lenght;
                    }
                    else
                    {
                        index -= lenght;
                    }



                    //index+lenght->cell outside the field 
                    if (index >= field.Length || index < 0)
                    {
                        break;
                    }

                    //index + lenght -> empty cell
                    if (field[index] == false)
                    {
                        field[index] = true;
                        break;
                    }
                }
            }

            foreach (var cell in field)
            {
                if (cell == true)
                {
                    Console.Write("1 ");
                }
                else
                {
                    Console.Write("0 ");
                }
            }
        }
    }
}
