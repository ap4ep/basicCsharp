using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp19
{
    class Program
    {
        /// <summary>
        /// а) Дописать структуру Complex, добавив метод вычитания комплексных чисел. Продемонстрировать работу структуры.
        ///б) Дописать класс Complex, добавив методы вычитания и произведения чисел.Проверить работу класса.
        ///в) Добавить диалог с использованием switch демонстрирующий работу класса.
        ///
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {            
            Console.WriteLine("Введите первое комплексное число:");
            Complex z1 = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));
            Console.WriteLine("Введите второе комплексное число:");
            Complex z2 = new Complex(Convert.ToDouble(Console.ReadLine()), Convert.ToDouble(Console.ReadLine()));

            z1.Print();
            z2.Print();

            Console.WriteLine("Введите операцию над числами(+, -, *)");
            switch(Console.ReadLine())
            {
                case "+":
                    Complex a = Complex.Addition(z1, z2);
                    a.Print();
                    break;
                case "-":
                    Complex s = Complex.Subtraction(z1, z2);
                    s.Print();
                    break;
                case "*":
                    Complex m = Complex.Multiplication(z1, z2);
                    m.Print();
                    break;
                default:
                    Console.WriteLine("Нет такой операции");
                    break;
            }
        }
    }
}
