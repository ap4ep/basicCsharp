using lesson4._2;
using System;

namespace lesson_4._2
{
    class Program
    {
        /// <summary>
        /// Реализуйте задачу 1 в виде статического класса StaticClass;
        /// а) Класс должен содержать статический метод, который принимает на вход массив и решает задачу 1;
        /// б) *Добавьте статический метод для считывания массива из текстового файла.Метод должен возвращать массив целых чисел;
        /// в)**Добавьте обработку ситуации отсутствия файла на диске.
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Random rnd = new Random();

            int[] array = new int[20];

            for (int i = 0; i <= array.Length - 1; i++)
            {
                array[i] = rnd.Next(-10000, 10000);
            }

            StaticClass.ReadArrayFromFile("C://text.txt");

            StaticClass.CalculatePairsInArray(array);

        }
    }
}
