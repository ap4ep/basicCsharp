using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            /// Реализовать метод проверки логина и пароля. На вход метода подается логин и пароль. 
            /// На выходе истина, если прошел авторизацию, и ложь, если не прошел (Логин: root, Password: GeekBrains). 
            /// Используя метод проверки логина и пароля, написать программу: пользователь вводит логин и пароль, 
            /// программа пропускает его дальше или не пропускает. С помощью цикла do while ограничить ввод пароля тремя попытками.
            ///
            /// Наумов Илья
            ///

            int tryCount = 0;
            string login;
            string password;

            do
            {
                Console.Write("Логин:");
                login = Console.ReadLine();
                Console.Write("Пароль:");
                password = Console.ReadLine();

                if (Authorization(login, password))
                {
                    Console.WriteLine(true);
                    break;
                }
                else
                { 
                    Console.WriteLine(false);
                    tryCount++;
                }
            } while (tryCount < 3);
        }

        private static bool Authorization(string login, string password)
        {
            if (login == "root")
                if (password == "GeekBrains")
                    return true;

            return false;
        }
    }
}
