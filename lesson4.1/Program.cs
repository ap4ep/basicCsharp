using System;

namespace lesson4._1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[20];
            int pairs = 0;

            for(int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }

            for(int i = 0; i < array.Length; i++)
            {
                if(array[i] % 3 == 0 && i < array.Length - 1)
                {
                    if(array[i + 1] % 3 != 0 )
                    {
                        pairs++;
                    }
                }
                
                if (array[i] % 3 != 0 && i < array.Length - 1)
                {
                    if (array[i + 1] % 3 == 0)
                    {
                        pairs++;
                    }
                }
            }

            Console.WriteLine($"{pairs} пар элементов");
        }

        
    }
}
