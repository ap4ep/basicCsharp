using System;

namespace lesson1._2
{
    class Program
    {
        /// <summary>
        /// Ввести вес и рост человека. Рассчитать и вывести индекс массы тела (ИМТ) по формуле I=m/(h*h); 
        /// где m — масса тела в килограммах, h — рост в метрах.
        /// 
        ///Наумов Илья
        ///
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Программ расчет индекса массы тела");
            Console.WriteLine("Какой у вас рост в метрах? Например 1,50");
            float h = float.Parse(Console.ReadLine());
            Console.WriteLine("Какой у вас вес в кг?");
            int m = Int32.Parse(Console.ReadLine());

            float i = m / (h * h);

            Console.WriteLine($"Ваш ИМТ равен {i}");
            Console.ReadKey();
        }
    }
}
