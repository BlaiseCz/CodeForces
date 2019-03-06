using System;
using System.Collections.Generic;

namespace CodeForces
{
    public class ex3
    {
        public static void EX3()
        {
            int n, k;
            bool good = true;
            string[] values = Console.ReadLine().Split(' ');
            n = int.Parse(values[0]);
            k = int.Parse(values[1]);

            string s = Console.ReadLine();
            string[] tab = s.Split(' ');

            List<int> kolory = new List<int>(n);
            for (int i = 0; i < tab.Length; i++)
            {
                kolory.Add(Int32.Parse(tab[i]));
                if (kolory[i] > k)
                {
                    Console.WriteLine("Wrong input!");
                    good = false;
                    break;
                }
            }

            if (good)
                output(kolory);
        }
        public static void output(List<int> kolory)//1 2 3 3 2 1 2 2
        {
            int ile = 1;
            int max = 1;

            for (int i = 0; i < kolory.Count - 1; i++)
            {
                if (kolory[i] != kolory[i + 1])
                    ile++;
                else
                    ile = 1;

                if (ile > max)
                    max = ile;
            }

            Console.WriteLine(max);
        }
    }
}
