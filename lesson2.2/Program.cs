using System;

namespace lesson2._2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(GetNumberCount(123456789));
            Console.ReadKey();
        }

        private static int GetNumberCount(int x)
        {
            int count = 0; 

            while(x != 0)
            {
                count++;
                x /= 10;
            }

            return count;
        }
    }
}
