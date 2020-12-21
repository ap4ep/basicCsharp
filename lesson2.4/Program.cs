using System;

namespace lesson2._4
{
    class Program
    {
        static void Main(string[] args)
        {
            int tryCount = 0;
            string login;
            string password;
            bool authorized = false;

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
