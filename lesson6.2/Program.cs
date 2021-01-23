using System;
using System.IO;

namespace lesson6._2
{
    /// <summary>
    /// 2. Модифицировать программу нахождения минимума функции так, чтобы можно было передавать функцию в виде делегата.
    /// а) Сделайте меню с различными функциями и предоставьте пользователю выбор, для какой функции и на каком отрезке находить минимум.
    /// б) Используйте массив(или список) делегатов, в котором хранятся различные функции.
    /// в) * Переделайте функцию Load, чтобы она возвращала массив считанных значений.Пусть она
    /// возвращает минимум через параметр.
    /// 
    /// Наумов Илья
    /// 
    /// </summary>
    /// <param name="path"></param>
    /// <returns></returns>

    delegate double Func(double arg);
    class Program
    {
        public static double F(double x)
        {
            return x * x - 50 * x + 10;
        }

        public static double F2(double x)
        {
            return x + x - 100 * x + 30;
        }

        public static void SaveFunc(string fileName, double a, double b, double h, Func f)
        {
            FileStream fs = new FileStream(fileName, FileMode.Create, FileAccess.Write);
            BinaryWriter bw = new BinaryWriter(fs);
            double x = a;
            while (x <= b)
            {
                bw.Write(f(x));
                x += h;
            }
            bw.Close();
            fs.Close();
        }

        public static double Load(string fileName)
        {
            FileStream fs = new FileStream(fileName, FileMode.Open, FileAccess.Read);
            BinaryReader bw = new BinaryReader(fs);
            double min = double.MaxValue;
            double d;
            for (int i = 0; i < fs.Length / sizeof(double); i++)
            {
                d = bw.ReadDouble();
                if (d < min) min = d;
            }
            bw.Close();
            fs.Close();
            return min;
        }

        static void Main(string[] args)
        {
            Func[] f = new Func[2] { F, F2 };

            Console.WriteLine("Выберите функцию:");
            Console.WriteLine("1 - f(x*x-50*x+10)    2 - x + x - 100 * x + 30");
            string menu = Console.ReadLine();
            Console.WriteLine("Укажите глубину:");
            double deep = Convert.ToDouble(Console.ReadLine());

            switch (menu)
            {
                case "1":
                    SaveFunc("data1.bin", deep, 100, 0.5, f[0]);
                    Console.WriteLine(Load("data1.bin"));
                    break;
                case "2":
                    SaveFunc("data2.bin", deep, 100, 0.5, f[1]);
                    Console.WriteLine(Load("data2.bin"));
                    break;

                default:
                    Console.WriteLine("Wrong input!");
                    break;
            }
        }
    }
}
