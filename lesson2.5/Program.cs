using System;

namespace lesson2._5
{
    class Program
    {

        /// <summary>
        /// а) Написать программу, которая запрашивает массу и рост человека, вычисляет его индекс массы и сообщает, нужно ли человеку похудеть, набрать вес или всё в норме.
        /// б) *Рассчитать, на сколько кг похудеть или сколько кг набрать для нормализации веса.
        ///
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            double height;
            double weigth;
            double bmi;


            Console.WriteLine("Введите свой рост");
            height = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine("Введите свой вес");
            weigth = Convert.ToDouble(Console.ReadLine());
            
            bmi = CalculateBMI(height, weigth);

            if (bmi < 18.5)
                Console.WriteLine($"Вам нужно набрать {CalculateMass(height, weigth, bmi) - weigth} кг, ИМТ = {bmi}");
            else if (bmi >= 25)
                Console.WriteLine($"Вам нужно сбросить {weigth - CalculateMass(height, weigth, bmi)} кг, ИМТ = {bmi}"); 
            else
                Console.WriteLine($"У вас нормальный вес ИМТ = {bmi}");
        }

        private static double CalculateBMI(double height, double weigth)
        {
            return Math.Round(weigth / Math.Pow(height, 2), 2);
        }

        // Костыль, но не могу вспомнить как это правильно считать :)
        private static double CalculateMass(double height, double weigth, double bmi)
        {
            double result = bmi;

            if (bmi < 18.5)
            {
                while(result < 18.5)
                {
                    result = (weigth++) / Math.Pow(height, 2);
                }
            }

            if (bmi >= 25)
            {
                while (result >= 25)
                {
                    result = (weigth--) / Math.Pow(height, 2);
                }
            }

            return Math.Round(weigth, 2);
        }
    }
}
