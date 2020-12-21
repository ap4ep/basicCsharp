using System;

namespace lesson2._3
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// С клавиатуры вводятся числа, пока не будет введен 0. Подсчитать сумму всех нечетных положительных чисел.
            ///
            /// Наумов Илья
            ///

            int summary = 0;

            while (true)
            {
                int number;
                Console.WriteLine("Вводите числа:");
                number = Convert.ToInt32(Console.ReadLine());

                if(number > 0 && Convert.ToBoolean(number % 2))
                {
                    Console.WriteLine(summary);
                    summary += number;
                }
                else
                {
                    if(number == 0)
                    {
                        Console.WriteLine($"Сумма нечетных чисел {summary}");
                        break;
                    }
                }
            }
        }
    }
}
