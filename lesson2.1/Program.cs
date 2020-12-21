using System;

namespace lesson2._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetMinimalValue(11, 20, 4));
            Console.ReadKey();
        }

        private static int GetMinimalValue(int a, int b, int c)
        {
            int minimal;
            if(a > b)
            {
                minimal = b;
            }
            else
            {
                minimal = a;
            }

            if(c < minimal)
            {
                minimal = c;
            }

            return minimal;
        }
    }
}
