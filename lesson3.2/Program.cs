using System;

namespace lesson3._2
{
    class Program
    {
        static void Main(string[] args)
        {
            ///
            /// С клавиатуры вводятся числа, пока не будет введён 0 (каждое число в новой строке). 
            /// Требуется подсчитать сумму всех нечётных положительных чисел. 
            /// Сами числа и сумму вывести на экран, используя tryParse.
            ///
            /// Наумов Илья
            ///


            SummOddNumbers();

        }
        private static void SummOddNumbers()
        {
            int summary = 0;

            while (true)
            {
                int number;
                Console.WriteLine("Вводите числа:");
                if (Int32.TryParse(Console.ReadLine(), out number))
                {
                    if (number > 0 && Convert.ToBoolean(number % 2))
                    {
                        summary += number;
                    }
                    else
                    {
                        if (number == 0)
                        {
                            Console.WriteLine($"Сумма нечетных чисел {summary}");
                            break;
                        }
                    }
                }
                else
                {
                    Console.WriteLine("Введено не число");
                }
            }
        }
    }
}
