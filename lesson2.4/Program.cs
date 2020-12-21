using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Authoriaztion());
        }

        static bool Authoriaztion()
        {
            int tryCount = 0;
            string login;
            string password;

            do
            {
                tryCount++;
                Console.Write("Логин:");
                login = Console.ReadLine();
                Console.Write("Пароль:");
                password = Console.ReadLine();

                if (login == "root")
                    if (password == "GeekBrains")
                        return true;

            } while (tryCount < 3);

            return false;
        }
    }
}
