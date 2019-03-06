using System;
namespace CodeForces
{
    public static class ex2    //Console.WriteLine("B. Decoding");
    {
        public static void EX2()
        {
            uint n = 0;
            String input = "";
            ex2.Set(ref input, ref n);
        }
        public static void Set(ref String input, ref uint n)
        {
            String output;
                   
            n = uint.Parse(Console.ReadLine());
            input = Console.ReadLine();


            output = Decode(input, n);
            Console.WriteLine(output);
                
        }
        private static String Decode(String input, uint n) //logva -> volga, no -> no, abba -> baba
        {
            String output = "", end = "", beg = "";

            int size = (int)n;
            if (size % 2 == 1)
            {
                for (int i = 0; i < size; i++)
                {
                    if (i % 2 == 0)
                    {
                        end += input[i];
                    }
                }
                for (int i = size - 1; i >= 0; i--)
                {
                    if (i % 2 == 1)
                    {
                        beg += input[i];
                    }
                }
            }
            else
            {
                for (int i = 0; i < size; i++)
                {
                    if (i % 2 == 1)
                    {
                        end += input[i];
                    }
                }
                for (int i = size - 1; i >= 0; i--)
                {
                    if (i % 2 == 0)
                    {
                        beg += input[i];
                    }
                }
            }
            output = beg + end;
            return output;

        }
    }
}
