using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace lesson5._2
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
    static class Message
    {
        public static string ReadMessageFromFile(string path)
        {
            return File.ReadAllText(path);
        }

        public static string ShowWordsLess(string message, int charCount)
        {
            var msgArr = message.Split(' ');
            string[] result = new string[1]{ "" };

            foreach(var w in msgArr)
            {
                if(w.Length <= charCount)
                {
                    int newSize = result.Length + 1;
                    Array.Resize(ref result,newSize);
                    result[newSize - 1] = w;
                }
            }

            return string.Join(" ", result);
        }

        public static string DeleteWordsWithCharEnd(string message, char patternChar)
        {
            Regex regEx = new Regex(@"\w*[" + patternChar + @"]$");
            var msgArray = message.Split(' ');
            string[] result = new string[1] { "" };
            
            foreach(var w in msgArray)
            {
                if(!regEx.IsMatch(w))
                {
                    int newSize = result.Length + 1;
                    Array.Resize(ref result, newSize);
                    result[newSize - 1] = w;
                }
            }

            return string.Join(" ", result);
        }

        public static string FindLongestWord(string message)
        {
            var msgArray = message.Split(' ');
            string result = "";

            foreach(var w in msgArray)
            {
                if (result.Length <= w.Length)
                {
                    result = w;
                }
            }

            return result;
        }

        public static string FindLongestWords(string message)
        {
            var msgArray = message.Split(' ');
            StringBuilder result = new StringBuilder();
            string longWord = "";

            foreach (var w in msgArray)
            {
                if (longWord.Length <= w.Length)
                {
                    longWord = w;
                }
            }

            foreach (var w in msgArray)
            {
                if(longWord.Length == w.Length)
                {
                    result.Append(" " + w);
                }
            }

            return result.ToString();
        }
    }
}
