using System;

namespace lesson1._5
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введит ваше Имя");
            string firstName = Console.ReadLine();
            Console.WriteLine("Введит вашу Фамилию");
            string lastName = Console.ReadLine();
            Console.WriteLine("Введит ваш Город");
            string city = Console.ReadLine();

            Console.WriteLine($"Имя: {firstName}\nФамилия: {lastName}\nГород: {city}");

            ClearScreen();

            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2);
            Console.WriteLine($"Имя: {firstName}");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 1);
            Console.WriteLine($"Фамилия: {lastName}");
            Console.SetCursorPosition(Console.WindowWidth / 2, Console.WindowHeight / 2 + 2);
            Console.WriteLine($"Город: {city}");

            ClearScreen();

            PrintLineInPosition($"Имя: {firstName} Фамилия: {lastName} Город: {city}", Console.WindowWidth / 2, Console.WindowHeight / 2);
        }

        static void PrintLineInPosition(string text, int x, int y) 
        {
            Console.SetCursorPosition(x, y);
            Console.Write(text);
        }

        static void ClearScreen()
        {
            Console.WriteLine("Нажмите пробел что бы обновить экран");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
