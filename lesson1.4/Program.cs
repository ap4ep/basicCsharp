using System;

namespace lesson1._4
{
    class Program
    {
        /// <summary>
        /// Написать программу обмена значениями двух переменных:
        ///  а) с использованием третьей переменной;
        ///  б) *без использования третьей переменной.
        ///  
        ///  Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Меняем переменые местами");
            Console.WriteLine("Введите переменную а");
            int a = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Введите переменную b");
            int b = Int32.Parse(Console.ReadLine());
            int t = 0;
            Console.WriteLine($"a = {a}, b = {b}, t = {t}");
            t = a; a = b; b = t;
            Console.WriteLine($"Меняем местами  и получаем a = {a}, b = {b}, а так же осталась временная переменная t = {t}");

            t = 0;
            Console.WriteLine($"a = {a}, b = {b}, t = {0}");
            (a, b) = (b, a);
            Console.WriteLine($"Меняем местами используя кортежи и получаем a = {a}, b = {b}, а тут мы ее не трогали t = {t}");
        }
    }
}
