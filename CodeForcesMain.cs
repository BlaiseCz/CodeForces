using System;
using System.Collections.Generic;

namespace CodeForces
{
    class MainClass
    {
        public static void Main(string[] args)
        {
            int n;
            n = int.Parse(Console.ReadLine());
            List<String> SuPr = new List<String>(2 * n - 2);

            for (int i = 0; i < 2 * n - 2; i++)
            {
                SuPr.Add(Console.ReadLine());
            }

            Console.WriteLine("end");
        }
    }
}
