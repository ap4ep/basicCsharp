﻿using System;

namespace lesson1._3
{
    class Program
    {

        /// <summary>
        /// а) Написать программу, которая подсчитывает расстояние между точками с координатами x1, y1 и x2,y2 
        /// по формуле r=Math.Sqrt(Math.Pow(x2-x1,2)+Math.Pow(y2-y1,2). Вывести результат, используя 
        /// спецификатор формата .2f (с двумя знаками после запятой);
        /// б) *Выполнить предыдущее задание, оформив вычисления расстояния между точками в виде метода.
        ///
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Введите x1");
            double x1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y1");
            double y1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите x2");
            double x2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Введите y2");
            double y2 = double.Parse(Console.ReadLine());

            double r = Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
      
            Console.WriteLine($"Растояние между точками {r:F2}");

            Console.WriteLine($"Растояние между точками с помощью метода {DistanceCalculation(x1, y1, x2, y2):F2}");
        }

        private static double DistanceCalculation(double x1, double y1, double x2, double y2)
        {
            return Math.Sqrt(Math.Pow(x2 - x1, 2) + Math.Pow(y2 - y1, 2));
        }
    }
}
