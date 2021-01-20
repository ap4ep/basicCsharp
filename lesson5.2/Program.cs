using System;

namespace lesson5._2
{
    class Program
    {
        /// <summary>
        /// 2. Разработать класс Message, содержащий следующие статические методы для обработки текста:
        /// а) Вывести только те слова сообщения, которые содержат не более n букв.
        /// б) Удалить из сообщения все слова, которые заканчиваются на заданный символ.
        /// в) Найти самое длинное слово сообщения.
        /// г) Сформировать строку с помощью StringBuilder из самых длинных слов сообщения.
        /// Продемонстрируйте работу программы на текстовом файле с вашей программой.
        /// 
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string message = Message.ReadMessageFromFile("message.txt");

            Console.WriteLine(Message.ShowWordsLess(message, 4));
            Console.WriteLine("=====================");
            Console.WriteLine(Message.DeleteWordsWithCharEnd(message, 'm'));
            Console.WriteLine("=====================");
            Console.WriteLine(Message.FindLongestWord(message));
            Console.WriteLine("=====================");
            Console.WriteLine(Message.FindLongestWords(message));
        }
    }
}
