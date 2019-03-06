using System;

namespace CodeForces
{
  public static class ex1  //Console.WriteLine("A. Wrong Subtraction");
    {
        public static void Set(ref uint n, ref uint k)
        {
            string[] values = Console.ReadLine().Split(' ');
            if (values.Length > 1)
            {
                n = uint.Parse(values[0]);
                k = uint.Parse(values[1]);
                Check(ref n, ref k);
            }
            else
                Set(ref n, ref k);
        }

        private static void Check(ref uint n,ref uint k)
        {
            if (n < 2 || k < 1 || n > Math.Pow(10, 9) || k > 50)
            {
                Console.WriteLine("Wrong numbers!");
                Set(ref n, ref k);
            }
        }

        public static void Subtraction(ref uint n, ref uint k)
        {
            uint buff;

            for (int i = 0; i < k; i++)
            {
                if (n > 0 && k > 0)
                {
                    buff = n % 10;

                    if (buff == 0)
                    {
                        n /= 10;
                    }
                    else
                    {
                        n -= 1;
                    }
                    if (i + 1 != k)
                    {
                        Console.Write("");
                    }
                    else
                    {
                       Console.WriteLine("{0}", n);
                    }
                }
                else
                {
                    Console.WriteLine("The result must be positive integer number");
                    break;
                }
            }
        }
    }
}
