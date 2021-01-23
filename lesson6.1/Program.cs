
using System;


namespace lesson6._1
{
    class Program
    {
        /// <summary>
        /// Изменить программу вывода таблицы функции так, чтобы можно было передавать функции типа double (double, double). 
        /// Продемонстрировать работу на функции с функцией a*x^2 и функцией a*sin(x).
        ///
        /// Наумов Илья
        /// Не уверен что правильно понял задание
        /// 
        /// </summary>
        /// <param name="x"></param>
        /// <returns></returns>

        public delegate double Fun(double x);
        public delegate double Fun2(double x, double a);

        //Было
        static void Table(Fun F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        static double MyFunc(double x)
        {
            return x * x * x;
        }

        //Стало
        static void Table2(Fun2 F, double x, double b)
        {
            Console.WriteLine("----- X ----- Y -----");
            while (x <= b)
            {
                Console.WriteLine("| {0,8:0.000} | {1,8:0.000} |", x, F(x, b));
                x += 1;
            }
            Console.WriteLine("---------------------");
        }

        static double Square(double x, double a)
        {
            return a * Math.Pow(x, 2);
        }

        static double SinX(double x, double a)
        {
            return a * Math.Sin(x);
        }

        static void Main()
        {
            Console.WriteLine("Было");
            Table(new Fun(MyFunc), -2, 2);
            Console.WriteLine("Стало");
            Table2(Square, -2, 2);
            Table2(SinX, -2, 2);
        }
    }
}
