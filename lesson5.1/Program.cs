using System;
using System.Text.RegularExpressions;

namespace lesson5._1
{
    class Program
    {
        /// <summary>
        /// 1. Создать программу, которая будет проверять корректность ввода логина. 
        /// Корректным логином будет строка от 2 до 10 символов, содержащая только буквы латинского алфавита или цифры, 
        /// при этом цифра не может быть первой:
        /// а) без использования регулярных выражений;
        /// б) с использованием регулярных выражений.
        /// 
        /// Наумов Илья
        /// 
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            string login1 = "vasya123";
            string login2 = "1vasya123";
            string login3 = "Вася123";
            string login4 = "v";
            string login5 = "vasyaKeks";
            string login6 = "vasya1235678910";

            Console.WriteLine("Валидация на логике");
            Console.WriteLine(LoginValidation(login1));
            Console.WriteLine(LoginValidation(login2));
            Console.WriteLine(LoginValidation(login3));
            Console.WriteLine(LoginValidation(login4));
            Console.WriteLine(LoginValidation(login5));
            Console.WriteLine(LoginValidation(login6));

            Console.WriteLine("Валидация на регулярках");
            Console.WriteLine(LoginRegExValidation(login1));
            Console.WriteLine(LoginRegExValidation(login2));
            Console.WriteLine(LoginRegExValidation(login3));
            Console.WriteLine(LoginRegExValidation(login4));
            Console.WriteLine(LoginRegExValidation(login5));
            Console.WriteLine(LoginRegExValidation(login6));
        }

        static bool LoginValidation(string login)
        {
            var loginCharArr = login.ToCharArray();

            if (loginCharArr.Length >= 2 && loginCharArr.Length <= 10)
            {
                if(loginCharArr[0] >= '0' && loginCharArr[0] <= '9')
                {
                    return false;
                }

                foreach(char c in loginCharArr)
                {
                    if(c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z' || c >= '0' && c <= '9')
                    {
                        
                    } 
                    else
                    {
                        return false;
                    }
                }
            }
            else
            {
                return false;
            }

            return true;
        }

        static bool LoginRegExValidation(string login)
        {
            Regex regex = new Regex(@"^\D\w{1,9}$");
            
            return regex.IsMatch(login);
        }
    }
}
