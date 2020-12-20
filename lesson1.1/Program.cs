using System;

namespace lesson1._1
{
    class Program
    {
        ///
        /// <summary>
        /// Написать программу «Анкета». Последовательно задаются вопросы (имя, фамилия, возраст, рост, вес). В результате вся информация выводится в одну строчку:
        /// а) используя склеивание;
        /// б) используя форматированный вывод;
	    /// в) используя вывод со знаком $.
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            Console.WriteLine("Программа Анкета");
            Console.WriteLine("Ваше имя:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Ваша фамилия:");
            string lastName = Console.ReadLine();
            Console.WriteLine("Сколько вам полных лет?");
            byte age = byte.Parse(Console.ReadLine());
            Console.WriteLine("Какой у вас рост?");
            int height = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Какой у вас вес?");
            byte weight = byte.Parse(Console.ReadLine());

            Console.WriteLine("Имя: " + firstName + " Фамилия: " + lastName + " Возраст: " + age + " Рост: " + height + " Вес: " + weight);
            Console.WriteLine("Имя: {0} Фамилия: {1} Возраст: {2} Рост: {3} Вес: {4}", firstName, lastName, age, height, weight);
            Console.WriteLine($"Имя: {firstName} Фамилия: {lastName} Возраст: {age} Рост: {height} Вес: {weight}");
            Console.ReadKey();
        }
    }
}
