using System;

namespace lesson4._1
{
    class Program
    {

        /// <summary>
        /// Дан  целочисленный  массив  из 20 элементов.  Элементы  массива  могут принимать  целые  значения  
        /// от –10 000 до 10 000 включительно. 
        /// Заполнить случайными числами.  Написать программу, позволяющую найти и вывести количество пар элементов массива, 
        /// в которых только одно число делится на 3. В данной задаче под парой подразумевается два подряд идущих элемента массива. 
        /// Например, для массива из пяти элементов: 6; 2; 9; –3; 6 ответ — 2.
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
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
