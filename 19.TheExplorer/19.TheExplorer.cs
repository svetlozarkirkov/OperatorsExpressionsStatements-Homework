using System;

namespace TheExplorer
{
    class TheExplorer
    {
        static void Main()
        {
            int diamondWidth = int.Parse(Console.ReadLine());
            int k = (diamondWidth / 2) - 1;
            int m = 1;

            for (int i = 1; i <= diamondWidth; i++)
            {
                if (i == 1 || i == diamondWidth)
                {
                    Console.Write(new string('-', diamondWidth / 2));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', diamondWidth / 2));
                    Console.WriteLine();
                }
                else if (i > 1 && i < (diamondWidth / 2) + 1)
                {
                    Console.Write(new string('-', k));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', m));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', k));
                    Console.WriteLine();
                    k--;
                    m += 2;
                }
                else if (i == (diamondWidth / 2) + 1)
                {
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', diamondWidth - 2));
                    Console.Write(new string('*', 1));
                    Console.WriteLine();
                    k = 1;
                    m = diamondWidth - 4;
                }
                else if (i > (diamondWidth / 2) + 1 && i < diamondWidth)
                {
                    Console.Write(new string('-', k));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', m));
                    Console.Write(new string('*', 1));
                    Console.Write(new string('-', k));
                    Console.WriteLine();
                    k++;
                    m -= 2;
                }
            }
        }
    }
}